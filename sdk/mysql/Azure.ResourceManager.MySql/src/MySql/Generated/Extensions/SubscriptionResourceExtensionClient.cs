// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql.Models;

namespace Azure.ResourceManager.MySql
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _mySqlServerServersClientDiagnostics;
        private ServersRestOperations _mySqlServerServersRestClient;
        private ClientDiagnostics _locationBasedPerformanceTierClientDiagnostics;
        private LocationBasedPerformanceTierRestOperations _locationBasedPerformanceTierRestClient;
        private ClientDiagnostics _checkNameAvailabilityClientDiagnostics;
        private CheckNameAvailabilityRestOperations _checkNameAvailabilityRestClient;
        private ClientDiagnostics _locationBasedRecommendedActionSessionsOperationStatusClientDiagnostics;
        private LocationBasedRecommendedActionSessionsOperationStatusRestOperations _locationBasedRecommendedActionSessionsOperationStatusRestClient;
        private ClientDiagnostics _locationBasedRecommendedActionSessionsResultClientDiagnostics;
        private LocationBasedRecommendedActionSessionsResultRestOperations _locationBasedRecommendedActionSessionsResultRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics MySqlServerServersClientDiagnostics => _mySqlServerServersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql", MySqlServerResource.ResourceType.Namespace, Diagnostics);
        private ServersRestOperations MySqlServerServersRestClient => _mySqlServerServersRestClient ??= new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(MySqlServerResource.ResourceType));
        private ClientDiagnostics LocationBasedPerformanceTierClientDiagnostics => _locationBasedPerformanceTierClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationBasedPerformanceTierRestOperations LocationBasedPerformanceTierRestClient => _locationBasedPerformanceTierRestClient ??= new LocationBasedPerformanceTierRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CheckNameAvailabilityClientDiagnostics => _checkNameAvailabilityClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckNameAvailabilityRestOperations CheckNameAvailabilityRestClient => _checkNameAvailabilityRestClient ??= new CheckNameAvailabilityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics LocationBasedRecommendedActionSessionsOperationStatusClientDiagnostics => _locationBasedRecommendedActionSessionsOperationStatusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationBasedRecommendedActionSessionsOperationStatusRestOperations LocationBasedRecommendedActionSessionsOperationStatusRestClient => _locationBasedRecommendedActionSessionsOperationStatusRestClient ??= new LocationBasedRecommendedActionSessionsOperationStatusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics LocationBasedRecommendedActionSessionsResultClientDiagnostics => _locationBasedRecommendedActionSessionsResultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationBasedRecommendedActionSessionsResultRestOperations LocationBasedRecommendedActionSessionsResultRestClient => _locationBasedRecommendedActionSessionsResultRestClient ??= new LocationBasedRecommendedActionSessionsResultRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/servers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlServerResource> GetMySqlServersAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MySqlServerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MySqlServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMySqlServers");
                scope.Start();
                try
                {
                    var response = await MySqlServerServersRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlServerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/servers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlServerResource> GetMySqlServers(CancellationToken cancellationToken = default)
        {
            Page<MySqlServerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = MySqlServerServersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetMySqlServers");
                scope.Start();
                try
                {
                    var response = MySqlServerServersRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlServerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all the performance tiers at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/performanceTiers
        /// Operation Id: LocationBasedPerformanceTier_List
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlPerformanceTier" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlPerformanceTier> GetLocationBasedPerformanceTiersAsync(string locationName, CancellationToken cancellationToken = default)
        {
            async Task<Page<MySqlPerformanceTier>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = LocationBasedPerformanceTierClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetLocationBasedPerformanceTiers");
                scope.Start();
                try
                {
                    var response = await LocationBasedPerformanceTierRestClient.ListAsync(Id.SubscriptionId, locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all the performance tiers at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/performanceTiers
        /// Operation Id: LocationBasedPerformanceTier_List
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlPerformanceTier" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlPerformanceTier> GetLocationBasedPerformanceTiers(string locationName, CancellationToken cancellationToken = default)
        {
            Page<MySqlPerformanceTier> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = LocationBasedPerformanceTierClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetLocationBasedPerformanceTiers");
                scope.Start();
                try
                {
                    var response = LocationBasedPerformanceTierRestClient.List(Id.SubscriptionId, locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlNameAvailabilityResult>> CheckMySqlNameAvailabilityAsync(MySqlNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMySqlNameAvailability");
            scope.Start();
            try
            {
                var response = await CheckNameAvailabilityRestClient.ExecuteAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of name for resource
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlNameAvailabilityResult> CheckMySqlNameAvailability(MySqlNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMySqlNameAvailability");
            scope.Start();
            try
            {
                var response = CheckNameAvailabilityRestClient.Execute(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Recommendation action session operation status.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/recommendedActionSessionsAzureAsyncOperation/{operationId}
        /// Operation Id: LocationBasedRecommendedActionSessionsOperationStatus_Get
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="operationId"> The operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlRecommendedActionSessionsOperationStatus>> GetRecommendedActionSessionsOperationStatusAsync(string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = LocationBasedRecommendedActionSessionsOperationStatusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRecommendedActionSessionsOperationStatus");
            scope.Start();
            try
            {
                var response = await LocationBasedRecommendedActionSessionsOperationStatusRestClient.GetAsync(Id.SubscriptionId, locationName, operationId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Recommendation action session operation status.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/recommendedActionSessionsAzureAsyncOperation/{operationId}
        /// Operation Id: LocationBasedRecommendedActionSessionsOperationStatus_Get
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="operationId"> The operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlRecommendedActionSessionsOperationStatus> GetRecommendedActionSessionsOperationStatus(string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            using var scope = LocationBasedRecommendedActionSessionsOperationStatusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRecommendedActionSessionsOperationStatus");
            scope.Start();
            try
            {
                var response = LocationBasedRecommendedActionSessionsOperationStatusRestClient.Get(Id.SubscriptionId, locationName, operationId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Recommendation action session operation result.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/recommendedActionSessionsOperationResults/{operationId}
        /// Operation Id: LocationBasedRecommendedActionSessionsResult_List
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="operationId"> The operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlRecommendationActionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlRecommendationActionResource> GetRecommendedActionSessionsOperationResultsAsync(string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            async Task<Page<MySqlRecommendationActionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = LocationBasedRecommendedActionSessionsResultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRecommendedActionSessionsOperationResults");
                scope.Start();
                try
                {
                    var response = await LocationBasedRecommendedActionSessionsResultRestClient.ListAsync(Id.SubscriptionId, locationName, operationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlRecommendationActionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MySqlRecommendationActionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = LocationBasedRecommendedActionSessionsResultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRecommendedActionSessionsOperationResults");
                scope.Start();
                try
                {
                    var response = await LocationBasedRecommendedActionSessionsResultRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, locationName, operationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlRecommendationActionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Recommendation action session operation result.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/recommendedActionSessionsOperationResults/{operationId}
        /// Operation Id: LocationBasedRecommendedActionSessionsResult_List
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="operationId"> The operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlRecommendationActionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlRecommendationActionResource> GetRecommendedActionSessionsOperationResults(string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Page<MySqlRecommendationActionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = LocationBasedRecommendedActionSessionsResultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRecommendedActionSessionsOperationResults");
                scope.Start();
                try
                {
                    var response = LocationBasedRecommendedActionSessionsResultRestClient.List(Id.SubscriptionId, locationName, operationId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlRecommendationActionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MySqlRecommendationActionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = LocationBasedRecommendedActionSessionsResultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRecommendedActionSessionsOperationResults");
                scope.Start();
                try
                {
                    var response = LocationBasedRecommendedActionSessionsResultRestClient.ListNextPage(nextLink, Id.SubscriptionId, locationName, operationId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MySqlRecommendationActionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
