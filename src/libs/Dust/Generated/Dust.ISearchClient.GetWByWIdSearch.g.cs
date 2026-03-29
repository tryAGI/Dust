#nullable enable

namespace Dust
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search for nodes in the workspace (streaming)<br/>
        /// Search for nodes in the workspace with SSE streaming
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="viewType"></param>
        /// <param name="spaceIds"></param>
        /// <param name="includeDataSources"></param>
        /// <param name="searchSourceUrls"></param>
        /// <param name="includeTools"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> GetWByWIdSearchAsync(
            string wId,
            string query,
            int? limit = default,
            string? cursor = default,
            global::Dust.GetWSearchViewType? viewType = default,
            string? spaceIds = default,
            bool? includeDataSources = default,
            bool? searchSourceUrls = default,
            bool? includeTools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}