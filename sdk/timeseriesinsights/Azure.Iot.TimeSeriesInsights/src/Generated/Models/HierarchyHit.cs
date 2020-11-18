// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.TimeSeriesInsights.Models
{
    /// <summary> The hierarchy node which contains the instances matching the query based on the input. May be empty or null. </summary>
    public partial class HierarchyHit
    {
        /// <summary> Initializes a new instance of HierarchyHit. </summary>
        internal HierarchyHit()
        {
        }

        /// <summary> Initializes a new instance of HierarchyHit. </summary>
        /// <param name="name"> Name of the hierarchy node. May be empty, cannot be null. </param>
        /// <param name="cumulativeInstanceCount"> Total number of instances that belong to this node and it&apos;s subtrees matching the query. </param>
        /// <param name="hierarchyNodes"> Child hierarchy nodes of this node. May be empty or null. </param>
        internal HierarchyHit(string name, int? cumulativeInstanceCount, SearchHierarchyNodesResponse hierarchyNodes)
        {
            Name = name;
            CumulativeInstanceCount = cumulativeInstanceCount;
            HierarchyNodes = hierarchyNodes;
        }

        /// <summary> Name of the hierarchy node. May be empty, cannot be null. </summary>
        public string Name { get; }
        /// <summary> Total number of instances that belong to this node and it&apos;s subtrees matching the query. </summary>
        public int? CumulativeInstanceCount { get; }
        /// <summary> Child hierarchy nodes of this node. May be empty or null. </summary>
        public SearchHierarchyNodesResponse HierarchyNodes { get; }
    }
}
