// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

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
        protected MaintenanceConfigurationAssignmentTests(bool isAsync) : base(isAsync)
        {
        }

        protected MaintenanceConfigurationAssignmentTests(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
        }
    }
}
