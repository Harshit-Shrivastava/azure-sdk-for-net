using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Maintenance.Tests
{
    public class MaintenancePublicConfigurationTests : MaintenanceManagementTestBase
    {
        public MaintenancePublicConfigurationTests(bool isAsync) : base(isAsync)
        {
        }

        public MaintenancePublicConfigurationTests(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
        }

        public async Task MaintenancePublicConfigurationGetForResourceTest()
        {
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string assetName = "resource";
            string rgGroupNamePrefix = "testRg";
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroupResource rg = await CreateResourceGroup(subscription, rgGroupNamePrefix, AzureLocation.WestUS);
            string resourceName = Recording.GenerateAssetName(assetName);
            ResourceIdentifier maintenanceConfigurationResourceId = MaintenancePublicConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceName);
            MaintenancePublicConfigurationResource maintenancePublicConfiguration = Client.GetMaintenancePublicConfigurationResource(maintenanceConfigurationResourceId);

            // invoke the operation
            MaintenancePublicConfigurationResource result = await maintenancePublicConfiguration.GetAsync();

            MaintenanceConfigurationData resourceData = result.Data;
            Assert.NotNull(resourceData);
        }
    }
}
