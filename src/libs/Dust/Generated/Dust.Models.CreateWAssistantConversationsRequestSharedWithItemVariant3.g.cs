
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWAssistantConversationsRequestSharedWithItemVariant3
    {
        /// <summary>
        /// ID of an active, non-system API key of the workspace, as shown in its details in the workspace's API keys settings<br/>
        /// Example: key_abc123
        /// </summary>
        /// <example>key_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequestSharedWithItemVariant3" /> class.
        /// </summary>
        /// <param name="keyId">
        /// ID of an active, non-system API key of the workspace, as shown in its details in the workspace's API keys settings<br/>
        /// Example: key_abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsRequestSharedWithItemVariant3(
            string keyId)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequestSharedWithItemVariant3" /> class.
        /// </summary>
        public CreateWAssistantConversationsRequestSharedWithItemVariant3()
        {
        }

    }
}