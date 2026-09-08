#nullable enable

namespace Dust
{
    public partial interface IPrivateSpacesClient
    {
        /// <summary>
        /// Create a space<br/>
        /// Creates a new space in the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWSpacesResponse> CreateWByWIdSpacesAsync(
            string wId,

            global::Dust.CreateWSpacesRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a space<br/>
        /// Creates a new space in the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.CreateWSpacesResponse>> CreateWByWIdSpacesAsResponseAsync(
            string wId,

            global::Dust.CreateWSpacesRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a space<br/>
        /// Creates a new space in the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="isRestricted"></param>
        /// <param name="name"></param>
        /// <param name="spaceKind"></param>
        /// <param name="memberIds">
        /// The space's manual member list. Omitted or empty means the space starts with no manual member.
        /// </param>
        /// <param name="groupIds">
        /// The groups given access to the space. Omitted or empty means no group has access to it.
        /// </param>
        /// <param name="managementMode">
        /// Deprecated and ignored. A space's members are its manual member list plus the members of the groups given access to it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWSpacesResponse> CreateWByWIdSpacesAsync(
            string wId,
            bool isRestricted,
            string name,
            global::Dust.CreateWSpacesRequestSpaceKind spaceKind,
            global::System.Collections.Generic.IList<string>? memberIds = default,
            global::System.Collections.Generic.IList<string>? groupIds = default,
            global::Dust.CreateWSpacesRequestManagementMode? managementMode = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}