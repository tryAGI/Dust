#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Get documents<br/>
        /// Get documents in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="documentIds"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesDataSourcesDocumentsResponse2> GetWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsAsync(
            string wId,
            string spaceId,
            string dsId,
            global::System.Collections.Generic.IList<string>? documentIds = default,
            int? limit = default,
            int? offset = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}