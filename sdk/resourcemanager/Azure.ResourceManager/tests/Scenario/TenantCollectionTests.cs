using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Tests
{
    [ClientTestFixture(true, "2021-04-01", "2016-06-01")]
    public class TenantCollectionTests : ResourceManagerTestBase
    {
        public TenantCollectionTests(bool isAsync, string apiVersion)
            : base(isAsync, TenantResource.ResourceType, apiVersion)//, RecordedTestMode.Record)
        {
        }

        [TestCase]
        [RecordedTest]
        public async Task List()
        {
            int count = 0;
            await foreach (var tenant in Client.GetTenants().GetAllAsync())
            {
                count++;
            }
            Assert.GreaterOrEqual(count, 1);
        }
    }
}
