
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsCancelRequest
    {
        /// <summary>
        /// List of message IDs to cancel generation for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MessageIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsCancelRequest" /> class.
        /// </summary>
        /// <param name="messageIds">
        /// List of message IDs to cancel generation for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsCancelRequest(
            global::System.Collections.Generic.IList<string> messageIds)
        {
            this.MessageIds = messageIds ?? throw new global::System.ArgumentNullException(nameof(messageIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsCancelRequest" /> class.
        /// </summary>
        public CreateWAssistantConversationsCancelRequest()
        {
        }
    }
}