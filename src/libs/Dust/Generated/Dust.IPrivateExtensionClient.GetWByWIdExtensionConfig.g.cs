#nullable enable

namespace Dust
{
    public partial interface IPrivateExtensionClient
    {
        /// <summary>
        /// Get extension configuration<br/>
        /// Returns the extension configuration for the workspace, including blacklisted domains.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.PrivateExtensionConfig> GetWByWIdExtensionConfigAsync(
            string wId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}