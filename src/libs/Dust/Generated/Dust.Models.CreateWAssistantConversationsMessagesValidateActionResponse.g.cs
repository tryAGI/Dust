
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesValidateActionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Action ids this decision moved out of awaiting validation. Includes the validated action, plus matching pending siblings cleared by an always-allow. Optional for older clients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolvedActionIds")]
        public global::System.Collections.Generic.IList<string>? ResolvedActionIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesValidateActionResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="resolvedActionIds">
        /// Action ids this decision moved out of awaiting validation. Includes the validated action, plus matching pending siblings cleared by an always-allow. Optional for older clients.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesValidateActionResponse(
            bool? success,
            global::System.Collections.Generic.IList<string>? resolvedActionIds)
        {
            this.Success = success;
            this.ResolvedActionIds = resolvedActionIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesValidateActionResponse" /> class.
        /// </summary>
        public CreateWAssistantConversationsMessagesValidateActionResponse()
        {
        }

    }
}