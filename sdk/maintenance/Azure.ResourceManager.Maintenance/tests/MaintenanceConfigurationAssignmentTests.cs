using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.Maintenance.Tests
{
    internal class MaintenanceConfigurationAssignmentTests : MaintenanceManagementTestBase
    {
        private string rgGroupNamePrefix;
        private string assetName;

        protected MaintenanceConfigurationAssignmentTests(bool isAsync) : base(isAsync)
        {
        }

        protected MaintenanceConfigurationAssignmentTests(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
        }

        [SetUp]
        public void SetUp()
        {
            rgGroupNamePrefix = "testRg";
            assetName = "resource";
        }
    }
}
