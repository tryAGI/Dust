#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Create a new conversation<br/>
        /// Create a new conversation in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.Conversation> CreateWByWIdAssistantConversationsAsync(
            string wId,

            global::Dust.CreateWAssistantConversationsRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new conversation<br/>
        /// Create a new conversation in the workspace identified by {wId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="message"></param>
        /// <param name="contentFragments">
        /// The list of content fragments to attach to this conversation (optional)
        /// </param>
        /// <param name="title">
        /// The title of the conversation<br/>
        /// Example: My conversation
        /// </param>
        /// <param name="skipToolsValidation">
        /// Whether to skip the tools validation of the agent messages triggered by this user message (optional, defaults to false)<br/>
        /// Example: false
        /// </param>
        /// <param name="blocking">
        /// Whether to wait for the agent to generate the initial message. If true the query will wait for the agent's answer. If false (default), the API will return a conversation ID directly and you will need to use streaming events to get the messages.<br/>
        /// Example: true
        /// </param>
        /// <param name="spaceId">
        /// The sId of the space (project) in which to create the conversation (optional). If not provided, the conversation is created outside projects<br/>
        /// Example: space_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.Conversation> CreateWByWIdAssistantConversationsAsync(
            string wId,
            global::Dust.Message message,
            global::System.Collections.Generic.IList<global::Dust.ContentFragment>? contentFragments = default,
            string? title = default,
            bool? skipToolsValidation = default,
            bool? blocking = default,
            string? spaceId = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}