
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWAssistantConversationsRequestSharedWithItemVariant2
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequestSharedWithItemVariant2" /> class.
        /// </summary>
        /// <param name="groupName">
        /// Exact name of a group of the workspace, such as "Workspace" for all its members<br/>
        /// Example: Engineering
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsRequestSharedWithItemVariant2(
            string groupName)
        {
            this.GroupName = groupName ?? throw new global::System.ArgumentNullException(nameof(groupName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequestSharedWithItemVariant2" /> class.
        /// </summary>
        public CreateWAssistantConversationsRequestSharedWithItemVariant2()
        {
        }

    }
}