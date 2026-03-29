#nullable enable

namespace Dust
{
    public partial interface IPrivateFilesClient
    {
        /// <summary>
        /// Get or download a file<br/>
        /// View or download a file. Use query parameters `version` (original, processed, public) and `action` (view, download).
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="fileId"></param>
        /// <param name="version"></param>
        /// <param name="action"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetWByWIdFilesByFileIdAsync(
            string wId,
            string fileId,
            global::Dust.GetWFilesVersion? version = default,
            global::Dust.GetWFilesAction? action = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}