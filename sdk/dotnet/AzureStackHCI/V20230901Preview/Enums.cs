// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AzureNative.AzureStackHCI.V20230901Preview
{
    /// <summary>
    /// Datasource for the gallery image when provisioning with cloud-init [NoCloud, Azure]
    /// </summary>
    [EnumType]
    public readonly struct CloudInitDataSource : IEquatable<CloudInitDataSource>
    {
        private readonly string _value;

        private CloudInitDataSource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static CloudInitDataSource NoCloud { get; } = new CloudInitDataSource("NoCloud");
        public static CloudInitDataSource Azure { get; } = new CloudInitDataSource("Azure");

        public static bool operator ==(CloudInitDataSource left, CloudInitDataSource right) => left.Equals(right);
        public static bool operator !=(CloudInitDataSource left, CloudInitDataSource right) => !left.Equals(right);

        public static explicit operator string(CloudInitDataSource value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is CloudInitDataSource other && Equals(other);
        public bool Equals(CloudInitDataSource other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The format of the actual VHD file [vhd, vhdx]
    /// </summary>
    [EnumType]
    public readonly struct DiskFileFormat : IEquatable<DiskFileFormat>
    {
        private readonly string _value;

        private DiskFileFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static DiskFileFormat Vhdx { get; } = new DiskFileFormat("vhdx");
        public static DiskFileFormat Vhd { get; } = new DiskFileFormat("vhd");

        public static bool operator ==(DiskFileFormat left, DiskFileFormat right) => left.Equals(right);
        public static bool operator !=(DiskFileFormat left, DiskFileFormat right) => !left.Equals(right);

        public static explicit operator string(DiskFileFormat value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is DiskFileFormat other && Equals(other);
        public bool Equals(DiskFileFormat other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The type of the extended location.
    /// </summary>
    [EnumType]
    public readonly struct ExtendedLocationTypes : IEquatable<ExtendedLocationTypes>
    {
        private readonly string _value;

        private ExtendedLocationTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ExtendedLocationTypes CustomLocation { get; } = new ExtendedLocationTypes("CustomLocation");

        public static bool operator ==(ExtendedLocationTypes left, ExtendedLocationTypes right) => left.Equals(right);
        public static bool operator !=(ExtendedLocationTypes left, ExtendedLocationTypes right) => !left.Equals(right);

        public static explicit operator string(ExtendedLocationTypes value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ExtendedLocationTypes other && Equals(other);
        public bool Equals(ExtendedLocationTypes other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The hypervisor generation of the Virtual Machine [V1, V2]
    /// </summary>
    [EnumType]
    public readonly struct HyperVGeneration : IEquatable<HyperVGeneration>
    {
        private readonly string _value;

        private HyperVGeneration(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static HyperVGeneration V1 { get; } = new HyperVGeneration("V1");
        public static HyperVGeneration V2 { get; } = new HyperVGeneration("V2");

        public static bool operator ==(HyperVGeneration left, HyperVGeneration right) => left.Equals(right);
        public static bool operator !=(HyperVGeneration left, HyperVGeneration right) => !left.Equals(right);

        public static explicit operator string(HyperVGeneration value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is HyperVGeneration other && Equals(other);
        public bool Equals(HyperVGeneration other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Type of the IP Pool [vm, vippool]
    /// </summary>
    [EnumType]
    public readonly struct IPPoolTypeEnum : IEquatable<IPPoolTypeEnum>
    {
        private readonly string _value;

        private IPPoolTypeEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static IPPoolTypeEnum Vm { get; } = new IPPoolTypeEnum("vm");
        public static IPPoolTypeEnum Vippool { get; } = new IPPoolTypeEnum("vippool");

        public static bool operator ==(IPPoolTypeEnum left, IPPoolTypeEnum right) => left.Equals(right);
        public static bool operator !=(IPPoolTypeEnum left, IPPoolTypeEnum right) => !left.Equals(right);

        public static explicit operator string(IPPoolTypeEnum value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is IPPoolTypeEnum other && Equals(other);
        public bool Equals(IPPoolTypeEnum other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// IPAllocationMethod - The IP address allocation method. Possible values include: 'Static', 'Dynamic'
    /// </summary>
    [EnumType]
    public readonly struct IpAllocationMethodEnum : IEquatable<IpAllocationMethodEnum>
    {
        private readonly string _value;

        private IpAllocationMethodEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static IpAllocationMethodEnum Dynamic { get; } = new IpAllocationMethodEnum("Dynamic");
        public static IpAllocationMethodEnum Static { get; } = new IpAllocationMethodEnum("Static");

        public static bool operator ==(IpAllocationMethodEnum left, IpAllocationMethodEnum right) => left.Equals(right);
        public static bool operator !=(IpAllocationMethodEnum left, IpAllocationMethodEnum right) => !left.Equals(right);

        public static explicit operator string(IpAllocationMethodEnum value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is IpAllocationMethodEnum other && Equals(other);
        public bool Equals(IpAllocationMethodEnum other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD. Possible values are: **Windows,** **Linux.**
    /// </summary>
    [EnumType]
    public readonly struct OperatingSystemTypes : IEquatable<OperatingSystemTypes>
    {
        private readonly string _value;

        private OperatingSystemTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static OperatingSystemTypes Linux { get; } = new OperatingSystemTypes("Linux");
        public static OperatingSystemTypes Windows { get; } = new OperatingSystemTypes("Windows");

        public static bool operator ==(OperatingSystemTypes left, OperatingSystemTypes right) => left.Equals(right);
        public static bool operator !=(OperatingSystemTypes left, OperatingSystemTypes right) => !left.Equals(right);

        public static explicit operator string(OperatingSystemTypes value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is OperatingSystemTypes other && Equals(other);
        public bool Equals(OperatingSystemTypes other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The guest agent provisioning action.
    /// </summary>
    [EnumType]
    public readonly struct ProvisioningAction : IEquatable<ProvisioningAction>
    {
        private readonly string _value;

        private ProvisioningAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ProvisioningAction Install { get; } = new ProvisioningAction("install");
        public static ProvisioningAction Uninstall { get; } = new ProvisioningAction("uninstall");
        public static ProvisioningAction Repair { get; } = new ProvisioningAction("repair");

        public static bool operator ==(ProvisioningAction left, ProvisioningAction right) => left.Equals(right);
        public static bool operator !=(ProvisioningAction left, ProvisioningAction right) => !left.Equals(right);

        public static explicit operator string(ProvisioningAction value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ProvisioningAction other && Equals(other);
        public bool Equals(ProvisioningAction other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The identity type.
    /// </summary>
    [EnumType]
    public readonly struct ResourceIdentityType : IEquatable<ResourceIdentityType>
    {
        private readonly string _value;

        private ResourceIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ResourceIdentityType SystemAssigned { get; } = new ResourceIdentityType("SystemAssigned");

        public static bool operator ==(ResourceIdentityType left, ResourceIdentityType right) => left.Equals(right);
        public static bool operator !=(ResourceIdentityType left, ResourceIdentityType right) => !left.Equals(right);

        public static explicit operator string(ResourceIdentityType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ResourceIdentityType other && Equals(other);
        public bool Equals(ResourceIdentityType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies the SecurityType of the virtual machine. EnableTPM and SecureBootEnabled must be set to true for SecurityType to function.
    /// </summary>
    [EnumType]
    public readonly struct SecurityTypes : IEquatable<SecurityTypes>
    {
        private readonly string _value;

        private SecurityTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static SecurityTypes TrustedLaunch { get; } = new SecurityTypes("TrustedLaunch");
        public static SecurityTypes ConfidentialVM { get; } = new SecurityTypes("ConfidentialVM");

        public static bool operator ==(SecurityTypes left, SecurityTypes right) => left.Equals(right);
        public static bool operator !=(SecurityTypes left, SecurityTypes right) => !left.Equals(right);

        public static explicit operator string(SecurityTypes value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SecurityTypes other && Equals(other);
        public bool Equals(SecurityTypes other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct VmSizeEnum : IEquatable<VmSizeEnum>
    {
        private readonly string _value;

        private VmSizeEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static VmSizeEnum Default { get; } = new VmSizeEnum("Default");
        public static VmSizeEnum Standard_A2_v2 { get; } = new VmSizeEnum("Standard_A2_v2");
        public static VmSizeEnum Standard_A4_v2 { get; } = new VmSizeEnum("Standard_A4_v2");
        public static VmSizeEnum Standard_D2s_v3 { get; } = new VmSizeEnum("Standard_D2s_v3");
        public static VmSizeEnum Standard_D4s_v3 { get; } = new VmSizeEnum("Standard_D4s_v3");
        public static VmSizeEnum Standard_D8s_v3 { get; } = new VmSizeEnum("Standard_D8s_v3");
        public static VmSizeEnum Standard_D16s_v3 { get; } = new VmSizeEnum("Standard_D16s_v3");
        public static VmSizeEnum Standard_D32s_v3 { get; } = new VmSizeEnum("Standard_D32s_v3");
        public static VmSizeEnum Standard_DS2_v2 { get; } = new VmSizeEnum("Standard_DS2_v2");
        public static VmSizeEnum Standard_DS3_v2 { get; } = new VmSizeEnum("Standard_DS3_v2");
        public static VmSizeEnum Standard_DS4_v2 { get; } = new VmSizeEnum("Standard_DS4_v2");
        public static VmSizeEnum Standard_DS5_v2 { get; } = new VmSizeEnum("Standard_DS5_v2");
        public static VmSizeEnum Standard_DS13_v2 { get; } = new VmSizeEnum("Standard_DS13_v2");
        public static VmSizeEnum Standard_K8S_v1 { get; } = new VmSizeEnum("Standard_K8S_v1");
        public static VmSizeEnum Standard_K8S2_v1 { get; } = new VmSizeEnum("Standard_K8S2_v1");
        public static VmSizeEnum Standard_K8S3_v1 { get; } = new VmSizeEnum("Standard_K8S3_v1");
        public static VmSizeEnum Standard_K8S4_v1 { get; } = new VmSizeEnum("Standard_K8S4_v1");
        public static VmSizeEnum Standard_NK6 { get; } = new VmSizeEnum("Standard_NK6");
        public static VmSizeEnum Standard_NK12 { get; } = new VmSizeEnum("Standard_NK12");
        public static VmSizeEnum Standard_NV6 { get; } = new VmSizeEnum("Standard_NV6");
        public static VmSizeEnum Standard_NV12 { get; } = new VmSizeEnum("Standard_NV12");
        public static VmSizeEnum Standard_K8S5_v1 { get; } = new VmSizeEnum("Standard_K8S5_v1");
        public static VmSizeEnum Custom { get; } = new VmSizeEnum("Custom");

        public static bool operator ==(VmSizeEnum left, VmSizeEnum right) => left.Equals(right);
        public static bool operator !=(VmSizeEnum left, VmSizeEnum right) => !left.Equals(right);

        public static explicit operator string(VmSizeEnum value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is VmSizeEnum other && Equals(other);
        public bool Equals(VmSizeEnum other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
