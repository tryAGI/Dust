#nullable enable

namespace Dust
{
    public partial interface IPrivateFilesClient
    {
        /// <summary>
        /// Delete a file<br/>
        /// Delete a file from the workspace.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteWByWIdFilesByFileIdAsync(
            string wId,
            string fileId,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}