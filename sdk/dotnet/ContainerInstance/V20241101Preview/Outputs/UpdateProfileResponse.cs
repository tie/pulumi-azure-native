// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.ContainerInstance.V20241101Preview.Outputs
{

    /// <summary>
    /// Used by the customer to specify the way to update the Container Groups in NGroup.
    /// </summary>
    [OutputType]
    public sealed class UpdateProfileResponse
    {
        /// <summary>
        /// This profile allows the customers to customize the rolling update.
        /// </summary>
        public readonly Outputs.UpdateProfileResponseRollingUpdateProfile? RollingUpdateProfile;
        public readonly string? UpdateMode;

        [OutputConstructor]
        private UpdateProfileResponse(
            Outputs.UpdateProfileResponseRollingUpdateProfile? rollingUpdateProfile,

            string? updateMode)
        {
            RollingUpdateProfile = rollingUpdateProfile;
            UpdateMode = updateMode;
        }
    }
}
