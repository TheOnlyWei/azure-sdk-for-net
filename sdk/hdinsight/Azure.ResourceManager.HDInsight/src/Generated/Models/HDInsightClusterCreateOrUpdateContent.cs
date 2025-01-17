// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The CreateCluster request parameters.
    /// Serialized Name: ClusterCreateParametersExtended
    /// </summary>
    public partial class HDInsightClusterCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of HDInsightClusterCreateOrUpdateContent. </summary>
        public HDInsightClusterCreateOrUpdateContent()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary>
        /// The location of the cluster.
        /// Serialized Name: ClusterCreateParametersExtended.location
        /// </summary>
        public AzureLocation? Location { get; set; }
        /// <summary>
        /// The resource tags.
        /// Serialized Name: ClusterCreateParametersExtended.tags
        /// </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary>
        /// The availability zones.
        /// Serialized Name: ClusterCreateParametersExtended.zones
        /// </summary>
        public IList<string> Zones { get; }
        /// <summary>
        /// The cluster create parameters.
        /// Serialized Name: ClusterCreateParametersExtended.properties
        /// </summary>
        public HDInsightClusterCreateOrUpdateProperties Properties { get; set; }
        /// <summary>
        /// The identity of the cluster, if configured.
        /// Serialized Name: ClusterCreateParametersExtended.identity
        /// </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
