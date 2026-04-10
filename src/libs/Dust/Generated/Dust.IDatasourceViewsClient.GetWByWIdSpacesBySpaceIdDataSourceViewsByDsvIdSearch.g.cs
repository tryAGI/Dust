#nullable enable

namespace Dust
{
    public partial interface IDatasourceViewsClient
    {
        /// <summary>
        /// Search the data source view<br/>
        /// Search the data source view identified by {dsvId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsvId"></param>
        /// <param name="query"></param>
        /// <param name="topK"></param>
        /// <param name="fullText"></param>
        /// <param name="targetDocumentTokens"></param>
        /// <param name="timestampGt"></param>
        /// <param name="timestampLt"></param>
        /// <param name="tagsIn"></param>
        /// <param name="tagsNot"></param>
        /// <param name="parentsIn"></param>
        /// <param name="parentsNot"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesDataSourceViewsSearchResponse> GetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdSearchAsync(
            string wId,
            string spaceId,
            string dsvId,
            string query,
            double topK,
            bool fullText,
            double? targetDocumentTokens = default,
            double? timestampGt = default,
            double? timestampLt = default,
            string? tagsIn = default,
            string? tagsNot = default,
            string? parentsIn = default,
            string? parentsNot = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}