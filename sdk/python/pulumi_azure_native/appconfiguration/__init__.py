# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from .. import _utilities
import typing
# Export this package's modules as members:
from ._enums import *
from .configuration_store import *
from .get_configuration_store import *
from .get_key_value import *
from .get_private_endpoint_connection import *
from .get_replica import *
from .key_value import *
from .list_configuration_store_keys import *
from .private_endpoint_connection import *
from .replica import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumi_azure_native.appconfiguration.v20230301 as __v20230301
    v20230301 = __v20230301
    import pulumi_azure_native.appconfiguration.v20230801preview as __v20230801preview
    v20230801preview = __v20230801preview
    import pulumi_azure_native.appconfiguration.v20230901preview as __v20230901preview
    v20230901preview = __v20230901preview
    import pulumi_azure_native.appconfiguration.v20240501 as __v20240501
    v20240501 = __v20240501
else:
    v20230301 = _utilities.lazy_import('pulumi_azure_native.appconfiguration.v20230301')
    v20230801preview = _utilities.lazy_import('pulumi_azure_native.appconfiguration.v20230801preview')
    v20230901preview = _utilities.lazy_import('pulumi_azure_native.appconfiguration.v20230901preview')
    v20240501 = _utilities.lazy_import('pulumi_azure_native.appconfiguration.v20240501')

