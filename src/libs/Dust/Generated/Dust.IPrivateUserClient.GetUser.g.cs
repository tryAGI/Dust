#nullable enable

namespace Dust
{
    public partial interface IPrivateUserClient
    {
        /// <summary>
        /// Get current user<br/>
        /// Returns the authenticated user with their workspaces and subscriber hash.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetUserResponse> GetUserAsync(
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}