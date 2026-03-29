
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesEditResponse
    {
        /// <summary>
        /// The edited user message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public object? Message { get; set; }

        /// <summary>
        /// Optional array of agent messages generated in response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentMessages")]
        public byte[]? AgentMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesEditResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// The edited user message
        /// </param>
        /// <param name="agentMessages">
        /// Optional array of agent messages generated in response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesEditResponse(
            object? message,
            byte[]? agentMessages)
        {
            this.Message = message;
            this.AgentMessages = agentMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesEditResponse" /> class.
        /// </summary>
        public CreateWAssistantConversationsMessagesEditResponse()
        {
        }
    }
}