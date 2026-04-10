#nullable enable

namespace Dust
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Create an app run<br/>
        /// Create and execute a run for an app in the space specified by {spaceId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="aId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWSpacesAppsRunsResponse> CreateWByWIdSpacesBySpaceIdAppsByAIdRunsAsync(
            string wId,
            string spaceId,
            string aId,

            global::Dust.CreateWSpacesAppsRunsRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an app run<br/>
        /// Create and execute a run for an app in the space specified by {spaceId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="aId"></param>
        /// <param name="specificationHash">
        /// Hash of the app specification. Ensures API compatibility across app iterations.
        /// </param>
        /// <param name="config">
        /// Configuration for the app run
        /// </param>
        /// <param name="inputs">
        /// Array of input objects for the app
        /// </param>
        /// <param name="stream">
        /// If true, the response will be streamed
        /// </param>
        /// <param name="blocking">
        /// If true, the request will block until the run is complete
        /// </param>
        /// <param name="blockFilter">
        /// Array of block names to filter the response
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWSpacesAppsRunsResponse> CreateWByWIdSpacesBySpaceIdAppsByAIdRunsAsync(
            string wId,
            string spaceId,
            string aId,
            string specificationHash,
            global::Dust.CreateWSpacesAppsRunsRequestConfig config,
            global::System.Collections.Generic.IList<object> inputs,
            bool? stream = default,
            bool? blocking = default,
            global::System.Collections.Generic.IList<string>? blockFilter = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}