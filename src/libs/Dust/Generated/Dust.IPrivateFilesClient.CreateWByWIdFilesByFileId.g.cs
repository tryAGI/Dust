#nullable enable

namespace Dust
{
    public partial interface IPrivateFilesClient
    {
        /// <summary>
        /// Upload file content<br/>
        /// Process and store the uploaded file content.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="fileId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWFilesResponse2> CreateWByWIdFilesByFileIdAsync(
            string wId,
            string fileId,

            global::Dust.CreateWFilesRequest2 request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload file content<br/>
        /// Process and store the uploaded file content.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="fileId"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWFilesResponse2> CreateWByWIdFilesByFileIdAsync(
            string wId,
            string fileId,
            byte[]? file = default,
            string? filename = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}