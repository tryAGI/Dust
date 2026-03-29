
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsCancelRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWAssistantConversationsCancelRequestActionJsonConverter))]
        public global::Dust.CreateWAssistantConversationsCancelRequestAction Action { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsCancelRequest2" /> class.
        /// </summary>
        /// <param name="messageIds"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsCancelRequest2(
            global::System.Collections.Generic.IList<string> messageIds,
            global::Dust.CreateWAssistantConversationsCancelRequestAction action)
        {
            this.Action = action;
            this.MessageIds = messageIds ?? throw new global::System.ArgumentNullException(nameof(messageIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsCancelRequest2" /> class.
        /// </summary>
        public CreateWAssistantConversationsCancelRequest2()
        {
        }
    }
}