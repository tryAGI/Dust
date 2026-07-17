#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Create a message<br/>
        /// Create a message in the workspace identified by {wId} in the conversation identified by {cId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.Message> CreateWByWIdAssistantConversationsByCIdMessagesAsync(
            string wId,
            string cId,

            global::Dust.Message request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a message<br/>
        /// Create a message in the workspace identified by {wId} in the conversation identified by {cId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<global::Dust.Message>> CreateWByWIdAssistantConversationsByCIdMessagesAsResponseAsync(
            string wId,
            string cId,

            global::Dust.Message request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a message<br/>
        /// Create a message in the workspace identified by {wId} in the conversation identified by {cId}.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="content">
        /// The content of the message. Should not be empty.<br/>
        /// Example: This is my message
        /// </param>
        /// <param name="mentions">
        /// Empty array is accepted but won't trigger any agent.
        /// </param>
        /// <param name="context"></param>
        /// <param name="modelSelection">
        /// Optional per-message model and reasoning-effort override applied to the<br/>
        /// mentioned agent(s). When omitted, each agent runs its configured model.<br/>
        /// If the requested model is not available to the workspace, the agent's<br/>
        /// configured model is used instead. An unknown provider, model, or<br/>
        /// reasoning effort results in a 400.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.Message> CreateWByWIdAssistantConversationsByCIdMessagesAsync(
            string wId,
            string cId,
            string content,
            global::System.Collections.Generic.IList<global::Dust.Mention> mentions,
            global::Dust.Context? context = default,
            global::Dust.ModelSelection? modelSelection = default,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}