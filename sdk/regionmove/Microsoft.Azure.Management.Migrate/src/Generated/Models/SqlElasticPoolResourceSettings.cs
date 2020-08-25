// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Migrate.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the Sql ElasticPool resource settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Sql/servers/elasticPools")]
    public partial class SqlElasticPoolResourceSettings : ResourceSettings
    {
        /// <summary>
        /// Initializes a new instance of the SqlElasticPoolResourceSettings
        /// class.
        /// </summary>
        public SqlElasticPoolResourceSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlElasticPoolResourceSettings
        /// class.
        /// </summary>
        /// <param name="targetResourceName">Gets or sets the target Resource
        /// name.</param>
        /// <param name="zoneRedundant">Possible values include: 'Enable',
        /// 'Disable'</param>
        public SqlElasticPoolResourceSettings(string targetResourceName, string zoneRedundant = default(string))
            : base(targetResourceName)
        {
            ZoneRedundant = zoneRedundant;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Enable', 'Disable'
        /// </summary>
        [JsonProperty(PropertyName = "zoneRedundant")]
        public string ZoneRedundant { get; set; }

    }
}