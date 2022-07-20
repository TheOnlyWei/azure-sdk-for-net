using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Tests
{
    [ClientTestFixture(true, "2021-04-01", "2016-06-01")]
    public class TenantOperationTests : ResourceManagerTestBase
    {
        public TenantOperationTests(bool isAsync, string apiVersion)
            : base(isAsync, TenantResource.ResourceType, apiVersion)//, RecordedTestMode.Record)
        {
        }

        [RecordedTest]
        public async Task ValidateResourceType()
        {
            await foreach (var provider in Client.GetTenantResourceProvidersAsync())
            {
                foreach (var providerResourceType in provider.ResourceTypes)
                {
                    Assert.DoesNotThrow(() => new ResourceType($"{provider.Namespace}/{providerResourceType.ResourceType}"), $"{provider.Namespace}/{providerResourceType.ResourceType} was not able to convert to a ResourceType struct");
                }
            }
        }
    }
}
