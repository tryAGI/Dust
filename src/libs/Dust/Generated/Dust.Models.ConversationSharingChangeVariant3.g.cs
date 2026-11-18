
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationSharingChangeVariant3
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
        /// Write access, or `none` to remove it<br/>
        /// Example: write
        /// </summary>
        /// <example>write</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.ConversationSharingChangeVariant3PermissionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.ConversationSharingChangeVariant3Permission Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSharingChangeVariant3" /> class.
        /// </summary>
        /// <param name="keyId">
        /// ID of an active, non-system API key of the workspace, as shown in its details in the workspace's API keys settings<br/>
        /// Example: key_abc123
        /// </param>
        /// <param name="permission">
        /// Write access, or `none` to remove it<br/>
        /// Example: write
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationSharingChangeVariant3(
            string keyId,
            global::Dust.ConversationSharingChangeVariant3Permission permission)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSharingChangeVariant3" /> class.
        /// </summary>
        public ConversationSharingChangeVariant3()
        {
        }

    }
}