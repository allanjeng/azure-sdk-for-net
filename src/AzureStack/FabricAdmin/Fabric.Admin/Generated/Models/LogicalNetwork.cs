// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.Fabric;
    using Microsoft.AzureStack.Management.Fabric.Admin;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This resource represents a logical partition of physical network that
    /// is dedicated for a particular purpose.  A logical network comprises of
    /// a collection of logical subnets.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LogicalNetwork : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LogicalNetwork class.
        /// </summary>
        public LogicalNetwork()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogicalNetwork class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region Location of resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="metadata">Metadata related to this Logical
        /// Network.</param>
        /// <param name="networkVirtualizationEnabled">Is Network
        /// Virtualization is enabled on this Logical Network.</param>
        /// <param name="subnets">List of subnets belonging to this Logical
        /// Network.</param>
        public LogicalNetwork(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IDictionary<string, string> metadata = default(IDictionary<string, string>), bool? networkVirtualizationEnabled = default(bool?), IList<string> subnets = default(IList<string>))
            : base(id, name, type, location, tags)
        {
            Metadata = metadata;
            NetworkVirtualizationEnabled = networkVirtualizationEnabled;
            Subnets = subnets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets metadata related to this Logical Network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets is Network Virtualization is enabled on this Logical
        /// Network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkVirtualizationEnabled")]
        public bool? NetworkVirtualizationEnabled { get; set; }

        /// <summary>
        /// Gets or sets list of subnets belonging to this Logical Network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnets")]
        public IList<string> Subnets { get; set; }

    }
}
