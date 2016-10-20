// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Search
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ServicesOperations.
    /// </summary>
    public static partial class ServicesOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a Search service in the given resource group. If the
            /// Search service already exists, all properties will be updated with the
            /// given values.
            /// <see href="https://msdn.microsoft.com/library/azure/dn832687.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='service'>
            /// The properties to set or update on the Search service.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SearchService CreateOrUpdate(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchService service, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicesOperations)s).CreateOrUpdateAsync(resourceGroupName, searchServiceName, service, searchManagementRequestOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Search service in the given resource group. If the
            /// Search service already exists, all properties will be updated with the
            /// given values.
            /// <see href="https://msdn.microsoft.com/library/azure/dn832687.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='service'>
            /// The properties to set or update on the Search service.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SearchService> CreateOrUpdateAsync(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchService service, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, searchServiceName, service, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the Search service with the given name in the given resource group.
            /// <see href="https://msdn.microsoft.com/library/azure/dn832694.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SearchService Get(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicesOperations)s).GetAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the Search service with the given name in the given resource group.
            /// <see href="https://msdn.microsoft.com/library/azure/dn832694.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SearchService> GetAsync(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Search service in the given resource group, along with its
            /// associated resources.
            /// <see href="https://msdn.microsoft.com/library/azure/dn832692.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static void Delete(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicesOperations)s).DeleteAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Search service in the given resource group, along with its
            /// associated resources.
            /// <see href="https://msdn.microsoft.com/library/azure/dn832692.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Search service associated with the specified
            /// resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IServicesOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns a list of all Search services in the given resource group.
            /// <see href="https://msdn.microsoft.com/library/azure/dn832688.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static System.Collections.Generic.IEnumerable<SearchService> ListByResourceGroup(this IServicesOperations operations, string resourceGroupName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicesOperations)s).ListByResourceGroupAsync(resourceGroupName, searchManagementRequestOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of all Search services in the given resource group.
            /// <see href="https://msdn.microsoft.com/library/azure/dn832688.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Collections.Generic.IEnumerable<SearchService>> ListByResourceGroupAsync(this IServicesOperations operations, string resourceGroupName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks the availability of a resource name without creating the resource.
            /// This is needed for resources where name is globally unique, such as an
            /// Azure Search service.
            /// <see href="https://msdn.microsoft.com/library/azure/mt574113.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// The resource name to validate.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static CheckNameAvailabilityOutput CheckNameAvailability(this IServicesOperations operations, string name, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IServicesOperations)s).CheckNameAvailabilityAsync(name, searchManagementRequestOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the availability of a resource name without creating the resource.
            /// This is needed for resources where name is globally unique, such as an
            /// Azure Search service.
            /// <see href="https://msdn.microsoft.com/library/azure/mt574113.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// The resource name to validate.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CheckNameAvailabilityOutput> CheckNameAvailabilityAsync(this IServicesOperations operations, string name, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(name, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
