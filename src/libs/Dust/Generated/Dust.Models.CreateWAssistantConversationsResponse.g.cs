
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsResponse
    {
        /// <summary>
        /// Full conversation including content, owner, and visibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateFullConversationJsonConverter))]
        public global::Dust.PrivateFullConversation? Conversation { get; set; }

        /// <summary>
        /// A user message in a conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::Dust.PrivateUserMessage? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentFragments")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateContentFragment>? ContentFragments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsResponse" /> class.
        /// </summary>
        /// <param name="conversation">
        /// Full conversation including content, owner, and visibility.
        /// </param>
        /// <param name="message">
        /// A user message in a conversation.
        /// </param>
        /// <param name="contentFragments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsResponse(
            global::Dust.PrivateFullConversation? conversation,
            global::Dust.PrivateUserMessage? message,
            global::System.Collections.Generic.IList<global::Dust.PrivateContentFragment>? contentFragments)
        {
            this.Conversation = conversation;
            this.Message = message;
            this.ContentFragments = contentFragments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsResponse" /> class.
        /// </summary>
        public CreateWAssistantConversationsResponse()
        {
        }
    }
}