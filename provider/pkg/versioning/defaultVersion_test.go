package versioning

import (
	"testing"
	"time"

	"github.com/pulumi/pulumi-azure-native/v2/provider/pkg/collections"
	"github.com/pulumi/pulumi-azure-native/v2/provider/pkg/openapi"
	"github.com/pulumi/pulumi-azure-native/v2/provider/pkg/providerlist"
	"github.com/stretchr/testify/assert"
)

func TestFindMinimalVersionSet(t *testing.T) {
	t.Run("empty", func(t *testing.T) {
		actual := findMinimalVersionSet(VersionResources{})
		expected := collections.NewOrderableSet[openapi.ApiVersion]()
		assert.Equal(t, expected, actual)
	})
	t.Run("latest superset", func(t *testing.T) {
		actual := findMinimalVersionSet(VersionResources{
			"2020-01-01": {
				"Resource A": {},
			},
			"2021-02-02": {
				"Resource A": {},
				"Resource B": {},
			},
		})
		expected := collections.NewOrderableSet[openapi.ApiVersion](
			"2021-02-02",
		)
		assert.Equal(t, expected, actual)
	})
	t.Run("rollup", func(t *testing.T) {
		actual := findMinimalVersionSet(VersionResources{
			"2020-01-01": {
				"Resource A": {},
				"Resource B": {},
			},
			"2021-02-02": {
				"Resource A": {},
			},
		})
		expected := collections.NewOrderableSet[openapi.ApiVersion](
			"2020-01-01", "2021-02-02",
		)
		assert.Equal(t, expected, actual)
	})
}

func TestFilterCandidateVersions(t *testing.T) {
	emptyBuilder := moduleSpecBuilder{
		moduleName:           "",
		activeVersionChecker: providerlist.ProviderList{}.Index(),
	}
	someResources := map[openapi.DefinitionName]openapi.DefinitionVersion{
		"ResourceA": {
			RpNamespace: "Microsoft.Fake",
		},
	}
	t.Run("empty spec", func(t *testing.T) {
		actual := emptyBuilder.filterCandidateVersions(VersionResources{}, "")
		expected := collections.NewOrderableSet[openapi.ApiVersion]()
		assert.Equal(t, expected, actual)
	})
	t.Run("skips recent preview after recent stable", func(t *testing.T) {
		twoMonthsAgo := openapi.ApiVersion(time.Now().Add(-time.Hour * 24 * 30).Format("2006-01-02"))
		oneMonthAgo := openapi.ApiVersion(time.Now().Add(-time.Hour * 24 * 30).Format("2006-01-02"))
		recentPreview := oneMonthAgo + "-preview"
		actual := emptyBuilder.filterCandidateVersions(VersionResources{
			twoMonthsAgo:  someResources,
			recentPreview: someResources,
		}, "")
		expected := collections.NewOrderableSet(twoMonthsAgo)
		assert.Equal(t, expected, actual)
	})
	t.Run("skips preview which is now stable", func(t *testing.T) {
		actual := emptyBuilder.filterCandidateVersions(VersionResources{
			"2020-01-01":         someResources,
			"2020-01-01-preview": someResources,
			"2022-02-02":         someResources,
		}, "")
		expected := collections.NewOrderableSet[openapi.ApiVersion]("2020-01-01", "2022-02-02")
		assert.Equal(t, expected, actual)
	})
	t.Run("skips multiple previews recently after a stable", func(t *testing.T) {
		actual := emptyBuilder.filterCandidateVersions(VersionResources{
			"2020-01-01":         someResources,
			"2020-01-01-preview": someResources,
			"2020-06-01-preview": someResources,
			"2022-02-02":         someResources,
		}, "")
		expected := collections.NewOrderableSet[openapi.ApiVersion]("2020-01-01", "2022-02-02")
		assert.Equal(t, expected, actual)
	})
	t.Run("single preview", func(t *testing.T) {
		actual := emptyBuilder.filterCandidateVersions(VersionResources{
			"2020-01-01-preview": someResources,
		}, "")
		expected := collections.NewOrderableSet[openapi.ApiVersion]("2020-01-01-preview")
		assert.Equal(t, expected, actual)
	})
	t.Run("only previews", func(t *testing.T) {
		actual := emptyBuilder.filterCandidateVersions(VersionResources{
			"2020-01-01-preview": someResources,
			"2021-01-01-preview": someResources,
		}, "")
		expected := collections.NewOrderableSet[openapi.ApiVersion]("2020-01-01-preview", "2021-01-01-preview")
		assert.Equal(t, expected, actual)
	})
	t.Run("remove private previews", func(t *testing.T) {
		actual := emptyBuilder.filterCandidateVersions(VersionResources{
			"2015-01-14-preview":        someResources,
			"2015-01-14-privatepreview": someResources,
		}, "")
		expected := collections.NewOrderableSet[openapi.ApiVersion]("2015-01-14-preview")
		assert.Equal(t, expected, actual)
	})
}
