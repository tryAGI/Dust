#nullable enable

namespace Dust
{
    public partial interface IPrivateSpacesClient
    {
        /// <summary>
        /// Update a space<br/>
        /// Updates the properties of a specific space.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWSpacesResponse> EditWByWIdSpacesBySpaceIdAsync(
            string wId,
            string spaceId,

            global::Dust.PatchWSpacesRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a space<br/>
        /// Updates the properties of a specific space.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWSpacesResponse> EditWByWIdSpacesBySpaceIdAsync(
            string wId,
            string spaceId,
            string? name = default,
            global::System.Collections.Generic.IList<global::Dust.PatchWSpacesRequestContentItem>? content = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}