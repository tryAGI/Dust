
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationSharingChangeVariant2
    {
        /// <summary>
        /// Exact name of a group of the workspace, such as "Workspace" for all its members<br/>
        /// Example: Engineering
        /// </summary>
        /// <example>Engineering</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupName { get; set; }

        /// <summary>
        /// Write access, or `none` to remove it<br/>
        /// Example: write
        /// </summary>
        /// <example>write</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.ConversationSharingChangeVariant2PermissionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.ConversationSharingChangeVariant2Permission Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSharingChangeVariant2" /> class.
        /// </summary>
        /// <param name="groupName">
        /// Exact name of a group of the workspace, such as "Workspace" for all its members<br/>
        /// Example: Engineering
        /// </param>
        /// <param name="permission">
        /// Write access, or `none` to remove it<br/>
        /// Example: write
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationSharingChangeVariant2(
            string groupName,
            global::Dust.ConversationSharingChangeVariant2Permission permission)
        {
            this.GroupName = groupName ?? throw new global::System.ArgumentNullException(nameof(groupName));
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSharingChangeVariant2" /> class.
        /// </summary>
        public ConversationSharingChangeVariant2()
        {
        }

    }
}