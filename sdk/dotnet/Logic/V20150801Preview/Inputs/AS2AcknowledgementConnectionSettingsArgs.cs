// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Logic.V20150801Preview.Inputs
{

    public sealed class AS2AcknowledgementConnectionSettingsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The value indicating whether to ignore mismatch in certificate name.
        /// </summary>
        [Input("ignoreCertificateNameMismatch")]
        public Input<bool>? IgnoreCertificateNameMismatch { get; set; }

        /// <summary>
        /// The value indicating whether to keep the connection alive.
        /// </summary>
        [Input("keepHttpConnectionAlive")]
        public Input<bool>? KeepHttpConnectionAlive { get; set; }

        /// <summary>
        /// The value indicating whether to support HTTP status code 'CONTINUE'.
        /// </summary>
        [Input("supportHttpStatusCodeContinue")]
        public Input<bool>? SupportHttpStatusCodeContinue { get; set; }

        /// <summary>
        /// The value indicating whether to unfold the HTTP headers.
        /// </summary>
        [Input("unfoldHttpHeaders")]
        public Input<bool>? UnfoldHttpHeaders { get; set; }

        public AS2AcknowledgementConnectionSettingsArgs()
        {
        }
        public static new AS2AcknowledgementConnectionSettingsArgs Empty => new AS2AcknowledgementConnectionSettingsArgs();
    }
}
