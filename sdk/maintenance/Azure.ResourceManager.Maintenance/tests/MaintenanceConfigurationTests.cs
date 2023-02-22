using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using NUnit.Framework;
using Xunit;

namespace Azure.ResourceManager.Maintenance.Tests
{
    /// <summary>
    /// Tests for maintenance SDK - Maintenance Configuration
    /// </summary>
    public class MaintenanceConfigurationTests : MaintenanceManagementTestBase
    {

        private const string rgGroupNamePrefix = "testRg";
        private const string assetName = "resource";

        protected MaintenanceConfigurationTests(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
        }

        [OneTimeSetUp]


        [Test]
        [RecordedTest]
        public async Task CreateMaintenanceConfigurationTest()
        {
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            ResourceGroupResource rg = await CreateResourceGroup(subscription, "testRg", AzureLocation.WestUS);
            string resourceName = Recording.GenerateAssetName("resource");
            MaintenanceConfigurationResource resource = await rg.Get().CreateOrUpdateAsync(WaitUntil.Completed, resourceName, new MaintenanceConfigurationData());
            Assert.AreEqual(resourceName, resource.Data.Name);
        }
    }
}
