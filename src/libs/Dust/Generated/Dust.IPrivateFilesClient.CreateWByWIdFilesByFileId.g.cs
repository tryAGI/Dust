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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWFilesResponse2> CreateWByWIdFilesByFileIdAsync(
            string wId,
            string fileId,

            global::Dust.CreateWFilesRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload file content<br/>
        /// Process and store the uploaded file content.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="fileId"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWFilesResponse2> CreateWByWIdFilesByFileIdAsync(
            string wId,
            string fileId,
            byte[]? file = default,
            string? filename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}