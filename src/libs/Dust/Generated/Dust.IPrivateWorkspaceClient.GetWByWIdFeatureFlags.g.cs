#nullable enable

namespace Dust
{
    public partial interface IPrivateWorkspaceClient
    {
        /// <summary>
        /// Get workspace feature flags<br/>
        /// Returns the list of enabled feature flags for the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PrivateFeatureFlags> GetWByWIdFeatureFlagsAsync(
            string wId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}