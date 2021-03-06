// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IndexersOperations.
    /// </summary>
    public static partial class IndexersOperationsExtensions
    {
            /// <summary>
            /// Resets the change tracking state associated with an Azure Search indexer.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Reset-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer to reset.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static void Reset(this IIndexersOperations operations, string indexerName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                operations.ResetAsync(indexerName, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resets the change tracking state associated with an Azure Search indexer.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Reset-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer to reset.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ResetAsync(this IIndexersOperations operations, string indexerName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ResetWithHttpMessagesAsync(indexerName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Runs an Azure Search indexer on-demand.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Run-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer to run.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static void Run(this IIndexersOperations operations, string indexerName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                operations.RunAsync(indexerName, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Runs an Azure Search indexer on-demand.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Run-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer to run.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RunAsync(this IIndexersOperations operations, string indexerName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RunWithHttpMessagesAsync(indexerName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new Azure Search indexer or updates an indexer if it already
            /// exists.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Create-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer to create or update.
            /// </param>
            /// <param name='indexer'>
            /// The definition of the indexer to create or update.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            public static Indexer CreateOrUpdate(this IIndexersOperations operations, string indexerName, Indexer indexer, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition))
            {
                return operations.CreateOrUpdateAsync(indexerName, indexer, searchRequestOptions, accessCondition).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Azure Search indexer or updates an indexer if it already
            /// exists.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Create-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer to create or update.
            /// </param>
            /// <param name='indexer'>
            /// The definition of the indexer to create or update.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Indexer> CreateOrUpdateAsync(this IIndexersOperations operations, string indexerName, Indexer indexer, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(indexerName, indexer, searchRequestOptions, accessCondition, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an Azure Search indexer.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Delete-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer to delete.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            public static void Delete(this IIndexersOperations operations, string indexerName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition))
            {
                operations.DeleteAsync(indexerName, searchRequestOptions, accessCondition).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an Azure Search indexer.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Delete-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer to delete.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIndexersOperations operations, string indexerName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(indexerName, searchRequestOptions, accessCondition, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves an indexer definition from Azure Search.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer to retrieve.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Indexer Get(this IIndexersOperations operations, string indexerName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.GetAsync(indexerName, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves an indexer definition from Azure Search.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer to retrieve.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Indexer> GetAsync(this IIndexersOperations operations, string indexerName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(indexerName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all indexers available for an Azure Search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/List-Indexers" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IndexerListResult List(this IIndexersOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.ListAsync(searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all indexers available for an Azure Search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/List-Indexers" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IndexerListResult> ListAsync(this IIndexersOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Azure Search indexer.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Create-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexer'>
            /// The definition of the indexer to create.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Indexer Create(this IIndexersOperations operations, Indexer indexer, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.CreateAsync(indexer, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Azure Search indexer.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Create-Indexer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexer'>
            /// The definition of the indexer to create.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Indexer> CreateAsync(this IIndexersOperations operations, Indexer indexer, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(indexer, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the current status and execution history of an indexer.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Indexer-Status" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer for which to retrieve status.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IndexerExecutionInfo GetStatus(this IIndexersOperations operations, string indexerName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.GetStatusAsync(indexerName, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the current status and execution history of an indexer.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Indexer-Status" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexerName'>
            /// The name of the indexer for which to retrieve status.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IndexerExecutionInfo> GetStatusAsync(this IIndexersOperations operations, string indexerName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatusWithHttpMessagesAsync(indexerName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
