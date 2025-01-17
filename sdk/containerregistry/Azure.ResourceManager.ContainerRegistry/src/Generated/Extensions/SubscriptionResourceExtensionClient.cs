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
using Azure.ResourceManager.ContainerRegistry.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _registriesClientDiagnostics;
        private RegistriesRestOperations _registriesRestClient;
        private ClientDiagnostics _registryClientDiagnostics;
        private RegistriesRestOperations _registryRestClient;

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

        private ClientDiagnostics RegistriesClientDiagnostics => _registriesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private RegistriesRestOperations RegistriesRestClient => _registriesRestClient ??= new RegistriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics RegistryClientDiagnostics => _registryClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", RegistryResource.ResourceType.Namespace, Diagnostics);
        private RegistriesRestOperations RegistryRestClient => _registryRestClient ??= new RegistriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(RegistryResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Checks whether the container registry name is available for use. The name must contain only alphanumeric characters, be globally unique, and between 5 and 50 characters in length.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/checkNameAvailability
        /// Operation Id: Registries_CheckNameAvailability
        /// </summary>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RegistryNameStatus>> CheckNameAvailabilityRegistryAsync(RegistryNameCheckContent content, CancellationToken cancellationToken = default)
        {
            using var scope = RegistriesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityRegistry");
            scope.Start();
            try
            {
                var response = await RegistriesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks whether the container registry name is available for use. The name must contain only alphanumeric characters, be globally unique, and between 5 and 50 characters in length.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/checkNameAvailability
        /// Operation Id: Registries_CheckNameAvailability
        /// </summary>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RegistryNameStatus> CheckNameAvailabilityRegistry(RegistryNameCheckContent content, CancellationToken cancellationToken = default)
        {
            using var scope = RegistriesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityRegistry");
            scope.Start();
            try
            {
                var response = RegistriesRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the container registries under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/registries
        /// Operation Id: Registries_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RegistryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RegistryResource> GetRegistriesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RegistryResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = RegistryClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRegistries");
                scope.Start();
                try
                {
                    var response = await RegistryRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RegistryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RegistryResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = RegistryClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRegistries");
                scope.Start();
                try
                {
                    var response = await RegistryRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RegistryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the container registries under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/registries
        /// Operation Id: Registries_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RegistryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RegistryResource> GetRegistries(CancellationToken cancellationToken = default)
        {
            Page<RegistryResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = RegistryClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRegistries");
                scope.Start();
                try
                {
                    var response = RegistryRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RegistryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RegistryResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = RegistryClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRegistries");
                scope.Start();
                try
                {
                    var response = RegistryRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RegistryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
