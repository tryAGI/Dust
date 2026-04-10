#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Get tables<br/>
        /// Get tables in the data source identified by {dsId} in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dust.Table>> GetWByWIdSpacesBySpaceIdDataSourcesByDsIdTablesAsync(
            string wId,
            string spaceId,
            string dsId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}