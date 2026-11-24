
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesResponse
    {
        /// <summary>
        /// The user message that was posted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public object? Message { get; set; }

        /// <summary>
        /// The agent messages created in response, one per mentioned agent. With `blocking: true`, the response waits up to 3 minutes for the agents. It does not guarantee completion: the array can be partial or empty, and a message can be returned in the state it had when posted. Check each message's `status` instead of assuming it completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentMessages")]
        public global::System.Collections.Generic.IList<object>? AgentMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// The user message that was posted.
        /// </param>
        /// <param name="agentMessages">
        /// The agent messages created in response, one per mentioned agent. With `blocking: true`, the response waits up to 3 minutes for the agents. It does not guarantee completion: the array can be partial or empty, and a message can be returned in the state it had when posted. Check each message's `status` instead of assuming it completed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesResponse(
            object? message,
            global::System.Collections.Generic.IList<object>? agentMessages)
        {
            this.Message = message;
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