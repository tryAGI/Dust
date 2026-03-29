#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Search the data source<br/>
        /// Search the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesDataSourcesSearchResponse> GetWByWIdSpacesBySpaceIdDataSourcesByDsIdSearchAsync(
            string wId,
            string spaceId,
            string dsId,
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}