#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Create a file upload URL
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWFilesResponse> CreateWByWIdFilesAsync(
            string wId,

            global::Dust.CreateWFilesRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a file upload URL
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="contentType">
        /// MIME type of the file
        /// </param>
        /// <param name="fileName">
        /// Name of the file
        /// </param>
        /// <param name="fileSize">
        /// Size of the file in bytes
        /// </param>
        /// <param name="useCase">
        /// Intended use case for the file, use "conversation"
        /// </param>
        /// <param name="useCaseMetadata">
        /// (optional) Metadata for the use case, for conversation useCase should be dictionary with conversationId stringified
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWFilesResponse> CreateWByWIdFilesAsync(
            string wId,
            string contentType,
            string fileName,
            int fileSize,
            string useCase,
            string useCaseMetadata,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}