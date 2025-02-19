// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.AzureStackHCI.Outputs
{

    [OutputType]
    public sealed class LogicalNetworkStatusResponseProvisioningStatus
    {
        /// <summary>
        /// The ID of the operation performed on the logical network
        /// </summary>
        public readonly string? OperationId;
        /// <summary>
        /// The status of the operation performed on the logical network [Succeeded, Failed, InProgress]
        /// </summary>
        public readonly string? Status;

        [OutputConstructor]
        private LogicalNetworkStatusResponseProvisioningStatus(
            string? operationId,

            string? status)
        {
            OperationId = operationId;
            Status = status;
        }
    }
}
