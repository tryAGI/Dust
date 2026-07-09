#nullable enable

namespace Dust
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Download a conversation-scoped file by path<br/>
        /// Download a file from a conversation's file system by its scoped path. Pass the<br/>
        /// canonical `filePath` surfaced in a message action's `generatedFiles` (the legacy<br/>
        /// `conversation/foo.pdf` form is also accepted). The file content is streamed<br/>
        /// directly from the conversation mount.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="rel"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetWByWIdAssistantConversationsByCIdFilesByRelAsync(
            string wId,
            string cId,
            string rel,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download a conversation-scoped file by path<br/>
        /// Download a file from a conversation's file system by its scoped path. Pass the<br/>
        /// canonical `filePath` surfaced in a message action's `generatedFiles` (the legacy<br/>
        /// `conversation/foo.pdf` form is also accepted). The file content is streamed<br/>
        /// directly from the conversation mount.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="rel"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetWByWIdAssistantConversationsByCIdFilesByRelAsStreamAsync(
            string wId,
            string cId,
            string rel,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download a conversation-scoped file by path<br/>
        /// Download a file from a conversation's file system by its scoped path. Pass the<br/>
        /// canonical `filePath` surfaced in a message action's `generatedFiles` (the legacy<br/>
        /// `conversation/foo.pdf` form is also accepted). The file content is streamed<br/>
        /// directly from the conversation mount.
        /// </summary>
        /// <param name="wId"></param>
        /// <param name="cId"></param>
        /// <param name="rel"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dust.AutoSDKHttpResponse<byte[]>> GetWByWIdAssistantConversationsByCIdFilesByRelAsResponseAsync(
            string wId,
            string cId,
            string rel,
            global::Dust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}