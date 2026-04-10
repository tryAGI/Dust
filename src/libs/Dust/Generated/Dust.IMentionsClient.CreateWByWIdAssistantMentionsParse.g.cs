#nullable enable

namespace Dust
{
    public partial interface IMentionsClient
    {
        /// <summary>
        /// Parse mentions in markdown text<br/>
        /// Parses pasted text containing @ mentions and converts them to the proper mention format.<br/>
        /// Matches @agentName or @userName patterns against available agents and users.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantMentionsParseResponse> CreateWByWIdAssistantMentionsParseAsync(
            string wId,

            global::Dust.CreateWAssistantMentionsParseRequest request,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Parse mentions in markdown text<br/>
        /// Parses pasted text containing @ mentions and converts them to the proper mention format.<br/>
        /// Matches @agentName or @userName patterns against available agents and users.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="markdown">
        /// Markdown text containing @ mentions to parse<br/>
        /// Example: Hello @JohnDoe, can you help with @MyAgent?
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.CreateWAssistantMentionsParseResponse> CreateWByWIdAssistantMentionsParseAsync(
            string wId,
            string markdown,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}