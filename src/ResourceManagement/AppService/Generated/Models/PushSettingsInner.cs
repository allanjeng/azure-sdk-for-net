// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Push settings for the App.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PushSettingsInner : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the PushSettingsInner class.
        /// </summary>
        public PushSettingsInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PushSettingsInner class.
        /// </summary>
        /// <param name="isPushEnabled">Gets or sets a flag indicating whether
        /// the Push endpoint is enabled.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tagWhitelistJson">Gets or sets a JSON string
        /// containing a list of tags that are whitelisted for use by the push
        /// registration endpoint.</param>
        /// <param name="tagsRequiringAuth">Gets or sets a JSON string
        /// containing a list of tags that require user authentication to be
        /// used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'.
        /// Validation should be performed at the PushRequestHandler.</param>
        /// <param name="dynamicTagsJson">Gets or sets a JSON string containing
        /// a list of dynamic tags that will be evaluated from user claims in
        /// the push registration endpoint.</param>
        /// <param name="isPushEnabled1">Gets or sets a flag indicating whether
        /// the Push endpoint is enabled.</param>
        /// <param name="tagWhitelistJson1">Gets or sets a JSON string
        /// containing a list of tags that are whitelisted for use by the push
        /// registration endpoint.</param>
        /// <param name="tagsRequiringAuth1">Gets or sets a JSON string
        /// containing a list of tags that require user authentication to be
        /// used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'.
        /// Validation should be performed at the PushRequestHandler.</param>
        /// <param name="dynamicTagsJson1">Gets or sets a JSON string
        /// containing a list of dynamic tags that will be evaluated from user
        /// claims in the push registration endpoint.</param>
        public PushSettingsInner(bool isPushEnabled, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string tagWhitelistJson = default(string), string tagsRequiringAuth = default(string), string dynamicTagsJson = default(string), bool? isPushEnabled1 = default(bool?), string tagWhitelistJson1 = default(string), string tagsRequiringAuth1 = default(string), string dynamicTagsJson1 = default(string))
            : base(id, name, kind, type)
        {
            IsPushEnabled = isPushEnabled;
            TagWhitelistJson = tagWhitelistJson;
            TagsRequiringAuth = tagsRequiringAuth;
            DynamicTagsJson = dynamicTagsJson;
            IsPushEnabled1 = isPushEnabled1;
            TagWhitelistJson1 = tagWhitelistJson1;
            TagsRequiringAuth1 = tagsRequiringAuth1;
            DynamicTagsJson1 = dynamicTagsJson1;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a flag indicating whether the Push endpoint is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "isPushEnabled")]
        public bool IsPushEnabled { get; set; }

        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that are
        /// whitelisted for use by the push registration endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "tagWhitelistJson")]
        public string TagWhitelistJson { get; set; }

        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that require
        /// user authentication to be used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'.
        /// Validation should be performed at the PushRequestHandler.
        /// </summary>
        [JsonProperty(PropertyName = "tagsRequiringAuth")]
        public string TagsRequiringAuth { get; set; }

        /// <summary>
        /// Gets or sets a JSON string containing a list of dynamic tags that
        /// will be evaluated from user claims in the push registration
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicTagsJson")]
        public string DynamicTagsJson { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether the Push endpoint is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isPushEnabled")]
        public bool? IsPushEnabled1 { get; set; }

        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that are
        /// whitelisted for use by the push registration endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tagWhitelistJson")]
        public string TagWhitelistJson1 { get; set; }

        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that require
        /// user authentication to be used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'.
        /// Validation should be performed at the PushRequestHandler.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tagsRequiringAuth")]
        public string TagsRequiringAuth1 { get; set; }

        /// <summary>
        /// Gets or sets a JSON string containing a list of dynamic tags that
        /// will be evaluated from user claims in the push registration
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dynamicTagsJson")]
        public string DynamicTagsJson1 { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}