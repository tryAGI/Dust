#nullable enable

namespace Dust
{
    public partial interface IPrivateAuthenticationClient
    {
        /// <summary>
        /// Revoke a session<br/>
        /// Revokes a WorkOS session by session ID. Used by the Chrome extension for logout.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWorkosRevokeSessionResponse> CreateWorkosRevokeSessionAsync(

            global::Dust.CreateWorkosRevokeSessionRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke a session<br/>
        /// Revokes a WorkOS session by session ID. Used by the Chrome extension for logout.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWorkosRevokeSessionResponse> CreateWorkosRevokeSessionAsync(
            string sessionId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}