#nullable enable

namespace Dust
{
    public partial interface IPrivateAuthenticationClient
    {
        /// <summary>
        /// Initiate WorkOS login<br/>
        /// Redirects to WorkOS AuthKit for authentication. Supports PKCE flow for extensions.
        /// </summary>
        /// <param name="redirectUri"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task GetWorkosLoginAsync(
            string? redirectUri = default,
            string? codeChallenge = default,
            string? codeChallengeMethod = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}