
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesResponse
    {
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentMessages")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateAgentMessage>? AgentMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// A user message in a conversation.
        /// </param>
        /// <param name="contentFragments"></param>
        /// <param name="agentMessages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesResponse(
            global::Dust.PrivateUserMessage? message,
            global::System.Collections.Generic.IList<global::Dust.PrivateContentFragment>? contentFragments,
            global::System.Collections.Generic.IList<global::Dust.PrivateAgentMessage>? agentMessages)
        {
            this.Message = message;
            this.ContentFragments = contentFragments;
            this.AgentMessages = agentMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesResponse" /> class.
        /// </summary>
        public CreateWAssistantConversationsMessagesResponse()
        {
        }
    }
}