using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Tests
{
    [ClientTestFixture(true, "2021-04-01", "2016-06-01")]
    [Parallelizable]
    public class HttpPipelineTests : ResourceManagerTestBase
    {
        private ArmClient _client;
        private string _rgName;

        public HttpPipelineTests(bool isAsync, string apiVersion)
            : base(isAsync, SubscriptionResource.ResourceType, apiVersion) //, RecordedTestMode.Record)
        {
        }

        [SetUp]
        public void SetUp()
        {
            _client = GetArmClient();
            _rgName = Recording.GenerateAssetName("test-CacheHttpPipeline");
        }

        [Test]
        [RecordedTest]
        public async Task ValidateHttpPipelines()
        {
            SubscriptionResource subscription = await _client.GetDefaultSubscriptionAsync().ConfigureAwait(false);
            await subscription.GetResourceGroups().Construct(AzureLocation.WestUS)
                .CreateOrUpdateAsync(_rgName);
            await foreach (var rg in subscription.GetResourceGroups().GetAllAsync())
            {
                Assert.AreEqual(rg.Pipeline.GetHashCode(), subscription.Pipeline.GetHashCode());
            }
        }
    }
}
