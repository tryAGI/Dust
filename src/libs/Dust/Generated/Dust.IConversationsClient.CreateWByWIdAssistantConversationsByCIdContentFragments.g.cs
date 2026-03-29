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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.ContentFragment> CreateWByWIdAssistantConversationsByCIdContentFragmentsAsync(
            string wId,
            string cId,

            global::Dust.ContentFragment request,
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
        /// <param name="nodeId">
        /// The id of the content node (optional if `content` and `contentType` are set)<br/>
        /// Example: node_123456
        /// </param>
        /// <param name="nodeDataSourceViewId">
        /// The id of the data source view (optional if `content` and `contentType` are set)<br/>
        /// Example: dsv_123456
        /// </param>
        /// <param name="context"></param>
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
            string? nodeId = default,
            string? nodeDataSourceViewId = default,
            global::Dust.Context? context = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}