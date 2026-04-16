#nullable enable

namespace Dust
{
    public partial interface IPrivateSpacesClient
    {
        /// <summary>
        /// Set project notification preference<br/>
        /// Sets the current user's notification preference for a project space.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWSpacesProjectNotificationPreferencesResponse> EditWByWIdSpacesBySpaceIdProjectNotificationPreferencesAsync(
            string wId,
            string spaceId,

            global::Dust.PatchWSpacesProjectNotificationPreferencesRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set project notification preference<br/>
        /// Sets the current user's notification preference for a project space.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="preference"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchWSpacesProjectNotificationPreferencesResponse> EditWByWIdSpacesBySpaceIdProjectNotificationPreferencesAsync(
            string wId,
            string spaceId,
            global::Dust.PatchWSpacesProjectNotificationPreferencesRequestPreference preference,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}