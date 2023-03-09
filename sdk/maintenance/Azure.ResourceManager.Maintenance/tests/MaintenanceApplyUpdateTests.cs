// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Diagnostics;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Maintenance.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Maintenance.Tests
{
    public class MaintenanceApplyUpdateTests : MaintenanceManagementTestBase
    {
        private string rgGroupNamePrefix;
        private string assetName;
        private string providerName;
        private string resourceType;
        private string applyUpdateName;
        private string resourceParentType;

        public MaintenanceApplyUpdateTests(bool isAsync) : base(isAsync)
        {
        }

        public MaintenanceApplyUpdateTests(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
        }

        [SetUp]
        public void SetUp()
        {
            rgGroupNamePrefix = "testRg";
            assetName = "resource";
            providerName = "Microsoft.Compute";
            resourceType = "virtualNMachineScaleSets";
            applyUpdateName = "e9b9685d-78e4-44c4-a81c-64a14f9b87b6";
            resourceParentType = "virtualMachineScaleSets";
        }

        [Test]
        [RecordedTest]
        public async Task ApplyUpdatesGetParentTest()
        {
            using AzureEventSourceListener listener = AzureEventSourceListener.CreateConsoleLogger();
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroupResource rg = await CreateResourceGroup(subscription, rgGroupNamePrefix, new AzureLocation("EastUS2EUAP"));
            string resourceName = Recording.GenerateAssetName(assetName);
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceParentName = "smdtest1";
            ResourceIdentifier resourceIdentifier = MaintenanceApplyUpdateResource.CreateResourceIdentifier(subscriptionId, rg.Data.Name, providerName, resourceType, resourceName, applyUpdateName);

            // invoke the operation
            ResourceGroupResourceGetApplyUpdatesByParentOptions options = new ResourceGroupResourceGetApplyUpdatesByParentOptions(providerName, resourceParentType, resourceParentName, resourceType, resourceName, applyUpdateName);
            MaintenanceApplyUpdateResource result = await rg.GetApplyUpdatesByParentAsync(options);
            MaintenanceApplyUpdateData resourceData = result.Data;
            Assert.AreEqual(resourceName, resourceData.Name);
            Assert.AreEqual(resourceType, resourceData.ResourceType);
            Assert.AreEqual((string)subscriptionId, resourceData.ResourceId);
        }

        [Test]
        [RecordedTest]
        public async Task ApplyUpdatesGetTest()
        {
            using AzureEventSourceListener listener = AzureEventSourceListener.CreateConsoleLogger();
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroupResource rg = await CreateResourceGroup(subscription, rgGroupNamePrefix, new AzureLocation("EastUS2EUAP"));
            string resourceName = Recording.GenerateAssetName(assetName);
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            ResourceIdentifier resourceIdentifier = MaintenanceApplyUpdateResource.CreateResourceIdentifier(subscriptionId, rg.Data.Name, providerName, resourceType, resourceName, applyUpdateName);
            MaintenanceApplyUpdateResource maintenanceApplyUpdate = Client.GetMaintenanceApplyUpdateResource(resourceIdentifier);

            // invoke the operation
            MaintenanceApplyUpdateResource result = await maintenanceApplyUpdate.GetAsync();

            MaintenanceApplyUpdateData resourceData = result.Data;

            Assert.AreEqual(resourceName, resourceData.Name);
            Assert.AreEqual(resourceType, resourceData.ResourceType);
            Assert.AreEqual(((string)subscriptionId), resourceData.ResourceId);
        }

        [Test]
        [RecordedTest]
        public async Task ApplyUpdatesCreateOrUpdateParentTest()
        {
            using AzureEventSourceListener listener = AzureEventSourceListener.CreateConsoleLogger();
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroupResource rg = await CreateResourceGroup(subscription, rgGroupNamePrefix, new AzureLocation("EastUS2EUAP"));
            string resourceName = Recording.GenerateAssetName(assetName);
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            string resourceParentName = "smdtest1";
            ResourceIdentifier resourceIdentifier = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, rg.Data.Name);

            MaintenanceApplyUpdateResource result = await rg.CreateOrUpdateApplyUpdateByParentAsync(providerName, resourceParentType,
                resourceParentName, resourceType, resourceName);

            MaintenanceApplyUpdateData resourceData = result.Data;

            Assert.AreEqual(resourceName, resourceData.Name);
            Assert.AreEqual(resourceType, resourceData.ResourceType);
            Assert.AreEqual(((string)subscriptionId), resourceData.ResourceId);
        }

        [Test]
        [RecordedTest]
        public async Task ApplyUpdatesCreateOrUpdateTest()
        {
            using AzureEventSourceListener listener = AzureEventSourceListener.CreateConsoleLogger();
            string subscriptionId = "5b4b650e-28b9-4790-b3ab-ddbd88d727c4";
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            string resourceName = Recording.GenerateAssetName(assetName);
            ResourceGroupResource rg = await CreateResourceGroup(subscription, rgGroupNamePrefix, new AzureLocation("EastUS2EUAP"));
            ResourceIdentifier resourceIdentifier = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, rg.Data.Name);

            // invoke the operation
            MaintenanceApplyUpdateResource result = await rg.CreateOrUpdateApplyUpdateAsync(providerName, resourceType, resourceName);

            MaintenanceApplyUpdateData resourceData = result.Data;

            Assert.AreEqual((string)subscriptionId, resourceData.ResourceId);
            Assert.AreEqual(resourceName, resourceData.Name);
            Assert.AreEqual(resourceType, resourceData.ResourceType);
        }
    }
}
