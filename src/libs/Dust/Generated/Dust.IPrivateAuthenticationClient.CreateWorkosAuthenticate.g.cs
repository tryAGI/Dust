#nullable enable

namespace Dust
{
    public partial interface IPrivateAuthenticationClient
    {
        /// <summary>
        /// Exchange code or refresh token<br/>
        /// Exchanges an authorization code or refresh token for access tokens via WorkOS.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWorkosAuthenticateResponse> CreateWorkosAuthenticateAsync(

            global::Dust.CreateWorkosAuthenticateRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exchange code or refresh token<br/>
        /// Exchanges an authorization code or refresh token for access tokens via WorkOS.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="grantType"></param>
        /// <param name="refreshToken"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWorkosAuthenticateResponse> CreateWorkosAuthenticateAsync(
            string? code = default,
            global::Dust.CreateWorkosAuthenticateRequestGrantType? grantType = default,
            string? refreshToken = default,
            string? codeVerifier = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}