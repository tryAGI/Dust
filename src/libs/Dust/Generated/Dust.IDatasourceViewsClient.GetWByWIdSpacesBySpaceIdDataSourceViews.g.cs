#nullable enable

namespace Dust
{
    public partial interface IDatasourceViewsClient
    {
        /// <summary>
        /// List Data Source Views<br/>
        /// Retrieves a list of data source views for the specified space
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetWSpacesDataSourceViewsResponse> GetWByWIdSpacesBySpaceIdDataSourceViewsAsync(
            string wId,
            string spaceId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}