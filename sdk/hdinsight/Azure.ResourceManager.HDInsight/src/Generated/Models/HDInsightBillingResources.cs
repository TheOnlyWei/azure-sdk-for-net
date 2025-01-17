// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The billing resources.
    /// Serialized Name: BillingResources
    /// </summary>
    public partial class HDInsightBillingResources
    {
        /// <summary> Initializes a new instance of HDInsightBillingResources. </summary>
        internal HDInsightBillingResources()
        {
            BillingMeters = new ChangeTrackingList<HDInsightBillingMeters>();
            DiskBillingMeters = new ChangeTrackingList<HDInsightDiskBillingMeters>();
        }

        /// <summary> Initializes a new instance of HDInsightBillingResources. </summary>
        /// <param name="region">
        /// The region or location.
        /// Serialized Name: BillingResources.region
        /// </param>
        /// <param name="billingMeters">
        /// The billing meter information.
        /// Serialized Name: BillingResources.billingMeters
        /// </param>
        /// <param name="diskBillingMeters">
        /// The managed disk billing information.
        /// Serialized Name: BillingResources.diskBillingMeters
        /// </param>
        internal HDInsightBillingResources(string region, IReadOnlyList<HDInsightBillingMeters> billingMeters, IReadOnlyList<HDInsightDiskBillingMeters> diskBillingMeters)
        {
            Region = region;
            BillingMeters = billingMeters;
            DiskBillingMeters = diskBillingMeters;
        }

        /// <summary>
        /// The region or location.
        /// Serialized Name: BillingResources.region
        /// </summary>
        public string Region { get; }
        /// <summary>
        /// The billing meter information.
        /// Serialized Name: BillingResources.billingMeters
        /// </summary>
        public IReadOnlyList<HDInsightBillingMeters> BillingMeters { get; }
        /// <summary>
        /// The managed disk billing information.
        /// Serialized Name: BillingResources.diskBillingMeters
        /// </summary>
        public IReadOnlyList<HDInsightDiskBillingMeters> DiskBillingMeters { get; }
    }
}
