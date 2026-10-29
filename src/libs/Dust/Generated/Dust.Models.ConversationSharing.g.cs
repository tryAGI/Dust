
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationSharing
    {
        /// <summary>
        /// The conversation's creator, whose access can't be changed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Dust.ConversationSharingOwner? Owner { get; set; }

        /// <summary>
        /// The members of the workspace with write access to the conversation, the owner excluded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.ConversationSharingMember> Members { get; set; }

        /// <summary>
        /// The groups with write access to the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.ConversationSharingGroup> Groups { get; set; }

        /// <summary>
        /// The API keys with write access to the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.ConversationSharingKey> Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSharing" /> class.
        /// </summary>
        /// <param name="members">
        /// The members of the workspace with write access to the conversation, the owner excluded
        /// </param>
        /// <param name="groups">
        /// The groups with write access to the conversation
        /// </param>
        /// <param name="keys">
        /// The API keys with write access to the conversation
        /// </param>
        /// <param name="owner">
        /// The conversation's creator, whose access can't be changed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationSharing(
            global::System.Collections.Generic.IList<global::Dust.ConversationSharingMember> members,
            global::System.Collections.Generic.IList<global::Dust.ConversationSharingGroup> groups,
            global::System.Collections.Generic.IList<global::Dust.ConversationSharingKey> keys,
            global::Dust.ConversationSharingOwner? owner)
        {
            this.Owner = owner;
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSharing" /> class.
        /// </summary>
        public ConversationSharing()
        {
        }

    }
}