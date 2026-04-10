#nullable enable

namespace Dust
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search for nodes in the workspace<br/>
        /// Search for nodes in the workspace
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdSearchAsync(
            string wId,

            global::Dust.CreateWSearchRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for nodes in the workspace<br/>
        /// Search for nodes in the workspace
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="query">
        /// The search query
        /// </param>
        /// <param name="includeDataSources">
        /// List of data source IDs to include in search
        /// </param>
        /// <param name="viewType">
        /// Type of view to filter results
        /// </param>
        /// <param name="spaceIds">
        /// List of space IDs to search in
        /// </param>
        /// <param name="nodeIds">
        /// List of specific node IDs to search
        /// </param>
        /// <param name="searchSourceUrls">
        /// Whether to search source URLs
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateWByWIdSearchAsync(
            string wId,
            string query,
            bool? includeDataSources = default,
            string? viewType = default,
            global::System.Collections.Generic.IList<string>? spaceIds = default,
            global::System.Collections.Generic.IList<string>? nodeIds = default,
            bool? searchSourceUrls = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}