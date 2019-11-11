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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// outlookTaskFolder
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphOutlooktaskfolderallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphOutlooktaskfolderallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphOutlooktaskfolderallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphOutlooktaskfolderallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphOutlooktaskfolderallof1(string changeKey = default(string), string name = default(string), bool? isDefaultFolder = default(bool?), System.Guid? parentGroupKey = default(System.Guid?), IList<MicrosoftgraphoutlookTask> tasks = default(IList<MicrosoftgraphoutlookTask>), IList<MicrosoftgraphsingleValueLegacyExtendedProperty> singleValueExtendedProperties = default(IList<MicrosoftgraphsingleValueLegacyExtendedProperty>), IList<MicrosoftgraphmultiValueLegacyExtendedProperty> multiValueExtendedProperties = default(IList<MicrosoftgraphmultiValueLegacyExtendedProperty>))
        {
            ChangeKey = changeKey;
            Name = name;
            IsDefaultFolder = isDefaultFolder;
            ParentGroupKey = parentGroupKey;
            Tasks = tasks;
            SingleValueExtendedProperties = singleValueExtendedProperties;
            MultiValueExtendedProperties = multiValueExtendedProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "changeKey")]
        public string ChangeKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isDefaultFolder")]
        public bool? IsDefaultFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentGroupKey")]
        public System.Guid? ParentGroupKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tasks")]
        public IList<MicrosoftgraphoutlookTask> Tasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "singleValueExtendedProperties")]
        public IList<MicrosoftgraphsingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "multiValueExtendedProperties")]
        public IList<MicrosoftgraphmultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }

    }
}