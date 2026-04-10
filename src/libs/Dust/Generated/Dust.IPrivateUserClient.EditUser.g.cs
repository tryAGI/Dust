#nullable enable

namespace Dust
{
    public partial interface IPrivateUserClient
    {
        /// <summary>
        /// Update current user<br/>
        /// Update the authenticated user's profile (name, job type, favorite platforms, image).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchUserResponse> EditUserAsync(

            global::Dust.PatchUserRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update current user<br/>
        /// Update the authenticated user's profile (name, job type, favorite platforms, image).
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="jobType"></param>
        /// <param name="imageUrl"></param>
        /// <param name="favoritePlatforms"></param>
        /// <param name="emailProvider"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PatchUserResponse> EditUserAsync(
            string firstName,
            string lastName,
            string? jobType = default,
            string? imageUrl = default,
            global::System.Collections.Generic.IList<string>? favoritePlatforms = default,
            string? emailProvider = default,
            string? workspaceId = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}