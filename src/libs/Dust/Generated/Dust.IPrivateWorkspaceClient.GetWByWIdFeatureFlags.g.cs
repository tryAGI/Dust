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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PrivateFeatureFlags> GetWByWIdFeatureFlagsAsync(
            string wId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}