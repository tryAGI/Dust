#nullable enable

namespace Dust
{
    public partial interface IPrivateFilesClient
    {
        /// <summary>
        /// Create a file upload<br/>
        /// Creates a file record and returns a pre-signed upload URL. The file content should then be uploaded to the returned URL.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWFilesResponse3> CreateWByWIdFilesAsync(
            string wId,

            global::Dust.CreateWFilesRequest3 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a file upload<br/>
        /// Creates a file record and returns a pre-signed upload URL. The file content should then be uploaded to the returned URL.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="contentType"></param>
        /// <param name="fileName"></param>
        /// <param name="fileSize"></param>
        /// <param name="useCase"></param>
        /// <param name="useCaseMetadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWFilesResponse3> CreateWByWIdFilesAsync(
            string wId,
            string contentType,
            string fileName,
            double fileSize,
            global::Dust.CreateWFilesRequestUseCase useCase,
            object? useCaseMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}