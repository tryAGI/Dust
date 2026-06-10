#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Create a content fragment<br/>
        /// Create a new content fragment in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.ContentFragment> CreateWByWIdAssistantConversationsByCIdContentFragmentsAsync(
            string wId,
            string cId,

            global::Dust.ContentFragment request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a content fragment<br/>
        /// Create a new content fragment in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.ContentFragment>> CreateWByWIdAssistantConversationsByCIdContentFragmentsAsResponseAsync(
            string wId,
            string cId,

            global::Dust.ContentFragment request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a content fragment<br/>
        /// Create a new content fragment in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="title">
        /// The title of the content fragment<br/>
        /// Example: My content fragment
        /// </param>
        /// <param name="content">
        /// The content of the content fragment (optional if `fileId` is set)<br/>
        /// Example: This is my content fragment extracted text
        /// </param>
        /// <param name="contentType">
        /// The content type of the content fragment (optional if `fileId` is set)<br/>
        /// Example: text/plain
        /// </param>
        /// <param name="url">
        /// The URL of the content fragment<br/>
        /// Example: https://example.com/content
        /// </param>
        /// <param name="fileId">
        /// The id of the previously uploaded file (optional if `content` and `contentType` are set)<br/>
        /// Example: fil_123456
        /// </param>
        /// <param name="path">
        /// Path of this file inside the sandbox conversation mount.<br/>
        /// Example: conversation/report.csv
        /// </param>
        /// <param name="skipDataSourceIndexing">
        /// Whether data source indexing was skipped for this file.
        /// </param>
        /// <param name="skipFileProcessing">
        /// Whether upload-time file processing was skipped.
        /// </param>
        /// <param name="nodeId">
        /// The id of the content node (optional if `content` and `contentType` are set)<br/>
        /// Example: node_123456
        /// </param>
        /// <param name="nodeDataSourceViewId">
        /// The id of the data source view (optional if `content` and `contentType` are set)<br/>
        /// Example: dsv_123456
        /// </param>
        /// <param name="context"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.ContentFragment> CreateWByWIdAssistantConversationsByCIdContentFragmentsAsync(
            string wId,
            string cId,
            string title,
            string? content = default,
            string? contentType = default,
            string? url = default,
            string? fileId = default,
            string? path = default,
            bool? skipDataSourceIndexing = default,
            bool? skipFileProcessing = default,
            string? nodeId = default,
            string? nodeDataSourceViewId = default,
            global::Dust.Context? context = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}