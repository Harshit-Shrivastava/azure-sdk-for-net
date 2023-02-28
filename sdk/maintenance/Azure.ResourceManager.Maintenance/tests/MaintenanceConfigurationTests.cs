// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Maintenance.Models;
using Azure.ResourceManager.Resources;
using NUnit.Compatibility;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Azure.ResourceManager.Maintenance.Tests
{
    /// <summary>
    /// Tests for maintenance SDK - Maintenance Configuration
    /// </summary>
    public class MaintenanceConfigurationTests : MaintenanceManagementTestBase
    {
        private string rgGroupNamePrefix;
        private string assetName;

        public MaintenanceConfigurationTests(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
        }

        public MaintenanceConfigurationTests(bool isAsync) : base(isAsync) { }

        [SetUp]
        public void SetUp()
        {
            rgGroupNamePrefix = "testRg";
            assetName = "resource";
        }

        [Test]
        [RecordedTest]
        public async Task UpdateMaintenanceConfigurationTest()
        {
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroupResource rg = await CreateResourceGroup(subscription, rgGroupNamePrefix, AzureLocation.WestUS);
            string resourceName = Recording.GenerateAssetName(assetName);

            // this example assumes you already have this MaintenanceConfigurationResource created on azure
            // for more information of creating MaintenanceConfigurationResource, please refer to the document of MaintenanceConfigurationResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            ResourceIdentifier maintenanceConfigurationResourceId = MaintenanceConfigurationResource.CreateResourceIdentifier(subscriptionId, rg.Data.Name, resourceName);
            MaintenanceConfigurationResource maintenanceConfiguration = Client.GetMaintenanceConfigurationResource(maintenanceConfigurationResourceId);

            // invoke the operation
            MaintenanceConfigurationData data = new MaintenanceConfigurationData(new AzureLocation("westus2"))
            {
                Namespace = "Microsoft.Maintenance",
                MaintenanceScope = MaintenanceScope.Host,
                Visibility = MaintenanceConfigurationVisibility.Custom,
                StartOn = DateTimeOffset.Parse("2020-04-30 08:00"),
                ExpireOn = DateTimeOffset.Parse("9999-12-31 00:00"),
                Duration = TimeSpan.Parse("05:00"),
                TimeZone = "Pacific Standard Time",
                RecurEvery = "Month Third Sunday",
            };
            MaintenanceConfigurationResource result = await maintenanceConfiguration.UpdateAsync(data);

            Assert.AreEqual(resourceName, result.Data.Name);
            Assert.AreEqual(data.Namespace, result.Data.Namespace);
            Assert.AreEqual(data.MaintenanceScope, result.Data.MaintenanceScope);
            Assert.AreEqual(data.Visibility, result.Data.Visibility);
            Assert.AreEqual(data.StartOn, result.Data.StartOn);
            Assert.AreEqual(data.ExpireOn, result.Data.ExpireOn);
            Assert.AreEqual(data.Duration, result.Data.Duration);
            Assert.AreEqual(data.TimeZone, result.Data.TimeZone);
            Assert.AreEqual(data.RecurEvery, result.Data.RecurEvery);
        }

        [Test]
        [RecordedTest]
        public async Task DeleteMaintenanceConfigurationTest()
        {
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroupResource rg = await CreateResourceGroup(subscription, rgGroupNamePrefix, AzureLocation.WestUS);
            string resourceName = Recording.GenerateAssetName(assetName);

            // this example assumes you already have this MaintenanceConfigurationResource created on azure
            // for more information of creating MaintenanceConfigurationResource, please refer to the document of MaintenanceConfigurationResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            ResourceIdentifier maintenanceConfigurationResourceId = MaintenanceConfigurationResource.CreateResourceIdentifier(subscriptionId, rg.Data.Name, resourceName);
            MaintenanceConfigurationResource maintenanceConfiguration = Client.GetMaintenanceConfigurationResource(maintenanceConfigurationResourceId);

            // invoke the operation
            ArmOperation<MaintenanceConfigurationResource> armOperation = await maintenanceConfiguration.DeleteAsync(WaitUntil.Completed);
            MaintenanceConfigurationResource result = armOperation.Value;
            MaintenanceConfigurationData resourceData = result.Data;
            Assert.IsNotNull(resourceData);
        }

        [Test]
        [RecordedTest]
        public async Task GetMaintenanceConfigurationTest()
        {
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroupResource rg = await CreateResourceGroup(subscription, rgGroupNamePrefix, AzureLocation.WestUS);
            string resourceName = Recording.GenerateAssetName(assetName);

            // this example assumes you already have this MaintenanceConfigurationResource created on azure
            // for more information of creating MaintenanceConfigurationResource, please refer to the document of MaintenanceConfigurationResource
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            ResourceIdentifier maintenanceConfigurationResourceId = MaintenanceConfigurationResource.CreateResourceIdentifier(subscriptionId, rg.Data.Name, resourceName);
            MaintenanceConfigurationResource maintenanceConfiguration = Client.GetMaintenanceConfigurationResource(maintenanceConfigurationResourceId);

            // invoke the operation
            MaintenanceConfigurationResource result = await maintenanceConfiguration.GetAsync();
            MaintenanceConfigurationData resourceData = result.Data;
            Assert.IsNotNull(resourceData);
        }

        [Test]
        [RecordedTest]
        public async Task CreateMaintenanceConfigurationTest()
        {
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroupResource rg = await CreateResourceGroup(subscription, rgGroupNamePrefix, AzureLocation.WestUS);
            string resourceName = Recording.GenerateAssetName(assetName);

            // invoke the operation
            ArmOperation<MaintenanceConfigurationResource> result = await rg.GetMaintenanceConfigurations().CreateOrUpdateAsync(WaitUntil.Completed, resourceName, new MaintenanceConfigurationData(AzureLocation.WestUS));
            Assert.AreEqual(resourceName, result.Value.Data.Name);
        }
    }
}
