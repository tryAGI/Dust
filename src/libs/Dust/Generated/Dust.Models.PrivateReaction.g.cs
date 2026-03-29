
#nullable enable

namespace Dust
{
    /// <summary>
    /// A reaction on a message.
    /// </summary>
    public sealed partial class PrivateReaction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emoji")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Emoji { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateReactionUser> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateReaction" /> class.
        /// </summary>
        /// <param name="emoji"></param>
        /// <param name="users"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateReaction(
            string emoji,
            global::System.Collections.Generic.IList<global::Dust.PrivateReactionUser> users)
        {
            this.Emoji = emoji ?? throw new global::System.ArgumentNullException(nameof(emoji));
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateReaction" /> class.
        /// </summary>
        public PrivateReaction()
        {
        }
    }
}