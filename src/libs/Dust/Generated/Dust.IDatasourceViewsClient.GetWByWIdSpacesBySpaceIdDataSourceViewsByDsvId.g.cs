#nullable enable

namespace Dust
{
    public partial interface IDatasourceViewsClient
    {
        /// <summary>
        /// Get a data source view
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsvId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.DatasourceView> GetWByWIdSpacesBySpaceIdDataSourceViewsByDsvIdAsync(
            string wId,
            string spaceId,
            string dsvId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}