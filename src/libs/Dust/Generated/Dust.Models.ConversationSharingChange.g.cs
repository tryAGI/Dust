
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationSharingChange
    {
        /// <summary>
        /// Email of a member of the workspace<br/>
        /// Example: jane@example.com
        /// </summary>
        /// <example>jane@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Write access, or `none` to remove it<br/>
        /// Example: write
        /// </summary>
        /// <example>write</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.ConversationSharingChangePermissionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.ConversationSharingChangePermission Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSharingChange" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of a member of the workspace<br/>
        /// Example: jane@example.com
        /// </param>
        /// <param name="permission">
        /// Write access, or `none` to remove it<br/>
        /// Example: write
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationSharingChange(
            string email,
            global::Dust.ConversationSharingChangePermission permission)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSharingChange" /> class.
        /// </summary>
        public ConversationSharingChange()
        {
        }

    }
}