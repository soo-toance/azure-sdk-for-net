// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// What is this?
    /// </summary>
    public partial class OperationMetaMetricDimensionSpecification
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OperationMetaMetricDimensionSpecification class.
        /// </summary>
        public OperationMetaMetricDimensionSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OperationMetaMetricDimensionSpecification class.
        /// </summary>
        /// <param name="displayName">Dimension display name</param>
        /// <param name="name">Dimension unique name</param>
        /// <param name="toBeExportedForShoebox">Whether this metric should be
        /// exported for Shoebox</param>
        public OperationMetaMetricDimensionSpecification(string displayName = default(string), string name = default(string), bool? toBeExportedForShoebox = default(bool?))
        {
            DisplayName = displayName;
            Name = name;
            ToBeExportedForShoebox = toBeExportedForShoebox;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets dimension display name
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets dimension unique name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets whether this metric should be exported for Shoebox
        /// </summary>
        [JsonProperty(PropertyName = "toBeExportedForShoebox")]
        public bool? ToBeExportedForShoebox { get; set; }

    }
}