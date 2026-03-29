#nullable enable

namespace Dust
{
    public partial interface IPrivateUserClient
    {
        /// <summary>
        /// Get current user<br/>
        /// Returns the authenticated user with their workspaces and subscriber hash.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.GetUserResponse> GetUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}