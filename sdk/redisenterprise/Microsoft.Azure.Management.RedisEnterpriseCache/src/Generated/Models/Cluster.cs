// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RedisEnterprise.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes the RedisEnterprise cluster
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Cluster : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        public Cluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="sku">The SKU to create, which affects price,
        /// performance, and features.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="zones">The zones where this cluster will be
        /// deployed.</param>
        /// <param name="minimumTlsVersion">The minimum TLS version for the
        /// cluster to support, e.g. '1.2'</param>
        /// <param name="hostName">DNS name of the cluster endpoint</param>
        /// <param name="provisioningState">Current provisioning status of the
        /// cluster. Possible values include: 'Succeeded', 'Failed',
        /// 'Canceled', 'Creating', 'Updating', 'Deleting'</param>
        /// <param name="resourceState">Current resource status of the cluster.
        /// Possible values include: 'Running', 'Creating', 'CreateFailed',
        /// 'Updating', 'UpdateFailed', 'Deleting', 'DeleteFailed', 'Enabling',
        /// 'EnableFailed', 'Disabling', 'DisableFailed', 'Disabled'</param>
        /// <param name="redisVersion">Version of redis the cluster supports,
        /// e.g. '6'</param>
        /// <param name="privateEndpointConnections">List of private endpoint
        /// connections associated with the specified RedisEnterprise
        /// cluster</param>
        public Cluster(string location, Sku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<string> zones = default(IList<string>), string minimumTlsVersion = default(string), string hostName = default(string), string provisioningState = default(string), string resourceState = default(string), string redisVersion = default(string), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            Zones = zones;
            MinimumTlsVersion = minimumTlsVersion;
            HostName = hostName;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            RedisVersion = redisVersion;
            PrivateEndpointConnections = privateEndpointConnections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU to create, which affects price, performance,
        /// and features.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the zones where this cluster will be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Gets or sets the minimum TLS version for the cluster to support,
        /// e.g. '1.2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.minimumTlsVersion")]
        public string MinimumTlsVersion { get; set; }

        /// <summary>
        /// Gets DNS name of the cluster endpoint
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; private set; }

        /// <summary>
        /// Gets current provisioning status of the cluster. Possible values
        /// include: 'Succeeded', 'Failed', 'Canceled', 'Creating', 'Updating',
        /// 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets current resource status of the cluster. Possible values
        /// include: 'Running', 'Creating', 'CreateFailed', 'Updating',
        /// 'UpdateFailed', 'Deleting', 'DeleteFailed', 'Enabling',
        /// 'EnableFailed', 'Disabling', 'DisableFailed', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; private set; }

        /// <summary>
        /// Gets version of redis the cluster supports, e.g. '6'
        /// </summary>
        [JsonProperty(PropertyName = "properties.redisVersion")]
        public string RedisVersion { get; private set; }

        /// <summary>
        /// Gets list of private endpoint connections associated with the
        /// specified RedisEnterprise cluster
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

    }
}
