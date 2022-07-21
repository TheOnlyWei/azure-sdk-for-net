using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Tests
{
    [ClientTestFixture(true, "2021-04-01", "2016-06-01")]
    public class RestApiCollectionTests : ResourceManagerTestBase
    {
        public RestApiCollectionTests(bool isAsync, string apiVersion)
        : base(isAsync, SubscriptionResource.ResourceType, apiVersion)//, RecordedTestMode.Record)
        {
        }

        [RecordedTest]
        public async Task ListComputeTest()
        {
            bool foundVirtualMachine = false;
            SubscriptionResource sub = await Client.GetDefaultSubscriptionAsync();
            var restApiCollection = sub.GetArmRestApis("Microsoft.Compute");
            await foreach (var restApi in restApiCollection.GetAllAsync())
            {
                if (restApi.Resource == "Virtual Machines")
                {
                    foundVirtualMachine = true;
                    break;
                }
            }
            Assert.IsTrue(foundVirtualMachine);
        }

        [RecordedTest]
        public async Task ListNetworkTest()
        {
            bool foundPrivateEndpoint = false;
            SubscriptionResource sub = await Client.GetDefaultSubscriptionAsync();
            var restApiCollection = sub.GetArmRestApis("Microsoft.Network");
            await foreach (var restApi in restApiCollection.GetAllAsync())
            {
                if (restApi.Resource == "Private Endpoint")
                {
                    foundPrivateEndpoint = true;
                    break;
                }
            }
            Assert.IsTrue(foundPrivateEndpoint);
        }
    }
}
