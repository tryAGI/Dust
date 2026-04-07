
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsMessagesActionsResponse
    {
        /// <summary>
        /// An MCP action with its output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::Dust.PrivateAgentMCPAction? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.GetWAssistantConversationsMessagesActionsResponseMessageStatusJsonConverter))]
        public global::Dust.GetWAssistantConversationsMessagesActionsResponseMessageStatus? MessageStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesActionsResponse" /> class.
        /// </summary>
        /// <param name="action">
        /// An MCP action with its output.
        /// </param>
        /// <param name="messageStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsMessagesActionsResponse(
            global::Dust.PrivateAgentMCPAction? action,
            global::Dust.GetWAssistantConversationsMessagesActionsResponseMessageStatus? messageStatus)
        {
            this.Action = action;
            this.MessageStatus = messageStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesActionsResponse" /> class.
        /// </summary>
        public GetWAssistantConversationsMessagesActionsResponse()
        {
        }
    }
}