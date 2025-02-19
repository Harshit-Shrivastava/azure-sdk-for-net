// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The supported disk size details for a disk type. </summary>
    public partial class SupportedConfigurationsDiskDetails
    {
        /// <summary> Initializes a new instance of SupportedConfigurationsDiskDetails. </summary>
        internal SupportedConfigurationsDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of SupportedConfigurationsDiskDetails. </summary>
        /// <param name="sku"> The disk sku. </param>
        /// <param name="sizeGB"> The disk size in GB. </param>
        /// <param name="minimumSupportedDiskCount"> The minimum supported disk count. </param>
        /// <param name="maximumSupportedDiskCount"> The maximum supported disk count. </param>
        /// <param name="iopsReadWrite"> The disk Iops. </param>
        /// <param name="mbpsReadWrite"> The disk provisioned throughput in MBps. </param>
        /// <param name="diskTier"> The disk tier, e.g. P10, E10. </param>
        internal SupportedConfigurationsDiskDetails(DiskSku sku, long? sizeGB, long? minimumSupportedDiskCount, long? maximumSupportedDiskCount, long? iopsReadWrite, long? mbpsReadWrite, string diskTier)
        {
            Sku = sku;
            SizeGB = sizeGB;
            MinimumSupportedDiskCount = minimumSupportedDiskCount;
            MaximumSupportedDiskCount = maximumSupportedDiskCount;
            IopsReadWrite = iopsReadWrite;
            MbpsReadWrite = mbpsReadWrite;
            DiskTier = diskTier;
        }

        /// <summary> The disk sku. </summary>
        internal DiskSku Sku { get; }
        /// <summary> Defines the disk sku name. </summary>
        public DiskDetailsDiskSkuName? SkuName
        {
            get => Sku?.Name;
        }

        /// <summary> The disk size in GB. </summary>
        public long? SizeGB { get; }
        /// <summary> The minimum supported disk count. </summary>
        public long? MinimumSupportedDiskCount { get; }
        /// <summary> The maximum supported disk count. </summary>
        public long? MaximumSupportedDiskCount { get; }
        /// <summary> The disk Iops. </summary>
        public long? IopsReadWrite { get; }
        /// <summary> The disk provisioned throughput in MBps. </summary>
        public long? MbpsReadWrite { get; }
        /// <summary> The disk tier, e.g. P10, E10. </summary>
        public string DiskTier { get; }
    }
}
