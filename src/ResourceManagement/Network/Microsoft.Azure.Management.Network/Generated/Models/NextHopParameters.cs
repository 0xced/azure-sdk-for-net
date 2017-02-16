// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Azure;
    using Management;
    using Network;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters that define the source and destination endpoint.
    /// </summary>
    public partial class NextHopParameters
    {
        /// <summary>
        /// Initializes a new instance of the NextHopParameters class.
        /// </summary>
        public NextHopParameters() { }

        /// <summary>
        /// Initializes a new instance of the NextHopParameters class.
        /// </summary>
        /// <param name="targetResourceId">The resource identifier of the
        /// target resource against which the action is to be
        /// performed.</param>
        /// <param name="sourceIPAddress">The source IP address.</param>
        /// <param name="destinationIPAddress">The destination IP
        /// address.</param>
        /// <param name="targetNicResourceId">The NIC ID. (If VM has multiple
        /// NICs and IP forwarding is enabled on any of the nics, then this
        /// parameter must be specified. Otherwise optional).</param>
        public NextHopParameters(string targetResourceId, string sourceIPAddress, string destinationIPAddress, string targetNicResourceId = default(string))
        {
            TargetResourceId = targetResourceId;
            SourceIPAddress = sourceIPAddress;
            DestinationIPAddress = destinationIPAddress;
            TargetNicResourceId = targetNicResourceId;
        }

        /// <summary>
        /// Gets or sets the resource identifier of the target resource against
        /// which the action is to be performed.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Gets or sets the source IP address.
        /// </summary>
        [JsonProperty(PropertyName = "sourceIPAddress")]
        public string SourceIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the destination IP address.
        /// </summary>
        [JsonProperty(PropertyName = "destinationIPAddress")]
        public string DestinationIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the NIC ID. (If VM has multiple NICs and IP forwarding
        /// is enabled on any of the nics, then this parameter must be
        /// specified. Otherwise optional).
        /// </summary>
        [JsonProperty(PropertyName = "targetNicResourceId")]
        public string TargetNicResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetResourceId");
            }
            if (SourceIPAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceIPAddress");
            }
            if (DestinationIPAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestinationIPAddress");
            }
        }
    }
}

