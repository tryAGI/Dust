
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchWAssistantConversationsSharingRequest
    {
        /// <summary>
        /// A user listed more than once gets their last change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.ConversationSharingChange> Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantConversationsSharingRequest" /> class.
        /// </summary>
        /// <param name="changes">
        /// A user listed more than once gets their last change.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWAssistantConversationsSharingRequest(
            global::System.Collections.Generic.IList<global::Dust.ConversationSharingChange> changes)
        {
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWAssistantConversationsSharingRequest" /> class.
        /// </summary>
        public PatchWAssistantConversationsSharingRequest()
        {
        }

    }
}