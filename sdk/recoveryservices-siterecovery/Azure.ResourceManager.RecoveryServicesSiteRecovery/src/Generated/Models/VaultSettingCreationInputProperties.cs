// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input to create vault setting. </summary>
    public partial class VaultSettingCreationInputProperties
    {
        /// <summary> Initializes a new instance of VaultSettingCreationInputProperties. </summary>
        public VaultSettingCreationInputProperties()
        {
        }

        /// <summary> The migration solution Id. </summary>
        public string MigrationSolutionId { get; set; }
        /// <summary> VMware to Azure provider type. </summary>
        public string VMwareToAzureProviderType { get; set; }
    }
}
