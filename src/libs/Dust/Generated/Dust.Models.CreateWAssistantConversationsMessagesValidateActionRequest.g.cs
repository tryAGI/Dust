
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesValidateActionRequest
    {
        /// <summary>
        /// ID of the action to validate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionId { get; set; }

        /// <summary>
        /// Whether the action is approved or rejected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Approved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesValidateActionRequest" /> class.
        /// </summary>
        /// <param name="actionId">
        /// ID of the action to validate
        /// </param>
        /// <param name="approved">
        /// Whether the action is approved or rejected
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesValidateActionRequest(
            string actionId,
            bool approved)
        {
            this.ActionId = actionId ?? throw new global::System.ArgumentNullException(nameof(actionId));
            this.Approved = approved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesValidateActionRequest" /> class.
        /// </summary>
        public CreateWAssistantConversationsMessagesValidateActionRequest()
        {
        }
    }
}