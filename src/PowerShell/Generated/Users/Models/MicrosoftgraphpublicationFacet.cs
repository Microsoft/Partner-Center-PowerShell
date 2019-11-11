// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Store.PartnerCenter.PowerShell.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// publicationFacet
    /// </summary>
    public partial class MicrosoftgraphpublicationFacet
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphpublicationFacet
        /// class.
        /// </summary>
        public MicrosoftgraphpublicationFacet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphpublicationFacet
        /// class.
        /// </summary>
        public MicrosoftgraphpublicationFacet(string level = default(string), string versionId = default(string))
        {
            Level = level;
            VersionId = versionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionId")]
        public string VersionId { get; set; }

    }
}