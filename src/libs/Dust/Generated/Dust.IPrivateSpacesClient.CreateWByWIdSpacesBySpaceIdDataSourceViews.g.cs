#nullable enable

namespace Dust
{
    public partial interface IPrivateSpacesClient
    {
        /// <summary>
        /// Create a data source view<br/>
        /// Creates a new data source view in a specific space.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWSpacesDataSourceViewsResponse> CreateWByWIdSpacesBySpaceIdDataSourceViewsAsync(
            string wId,
            string spaceId,

            global::Dust.CreateWSpacesDataSourceViewsRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a data source view<br/>
        /// Creates a new data source view in a specific space.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dataSourceId"></param>
        /// <param name="parentsIn"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWSpacesDataSourceViewsResponse> CreateWByWIdSpacesBySpaceIdDataSourceViewsAsync(
            string wId,
            string spaceId,
            string dataSourceId,
            global::System.Collections.Generic.IList<string>? parentsIn = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}