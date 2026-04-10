#nullable enable

namespace Dust
{
    public partial interface IDatasourcesClient
    {
        /// <summary>
        /// Upsert a document in a data source<br/>
        /// Upsert a document in a data source in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWSpacesDataSourcesDocumentsResponse> CreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdAsync(
            string wId,
            string spaceId,
            string dsId,
            string documentId,

            global::Dust.CreateWSpacesDataSourcesDocumentsRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert a document in a data source<br/>
        /// Upsert a document in a data source in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="spaceId"></param>
        /// <param name="dsId"></param>
        /// <param name="documentId"></param>
        /// <param name="title">
        /// The title of the document to upsert.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the document to upsert.
        /// </param>
        /// <param name="text">
        /// The text content of the document to upsert.
        /// </param>
        /// <param name="section">
        /// A section of a document that can contain nested sections
        /// </param>
        /// <param name="sourceUrl">
        /// The source URL for the document to upsert.
        /// </param>
        /// <param name="tags">
        /// Tags to associate with the document.
        /// </param>
        /// <param name="timestamp">
        /// Unix timestamp (in milliseconds) for the document (e.g. 1736365559000).
        /// </param>
        /// <param name="lightDocumentOutput">
        /// If true, a lightweight version of the document will be returned in the response (excluding the text, chunks and vectors). Defaults to false.
        /// </param>
        /// <param name="async">
        /// If true, the upsert operation will be performed asynchronously.
        /// </param>
        /// <param name="upsertContext">
        /// Additional context for the upsert operation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWSpacesDataSourcesDocumentsResponse> CreateWByWIdSpacesBySpaceIdDataSourcesByDsIdDocumentsByDocumentIdAsync(
            string wId,
            string spaceId,
            string dsId,
            string documentId,
            string? title = default,
            string? mimeType = default,
            string? text = default,
            global::Dust.Section? section = default,
            string? sourceUrl = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            double? timestamp = default,
            bool? lightDocumentOutput = default,
            bool? async = default,
            object? upsertContext = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}