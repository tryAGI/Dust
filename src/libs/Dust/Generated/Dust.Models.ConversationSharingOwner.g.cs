
#nullable enable

namespace Dust
{
    /// <summary>
    /// The conversation's creator, whose access can't be changed
    /// </summary>
    public sealed partial class ConversationSharingOwner
    {
        /// <summary>
        /// ID of the user<br/>
        /// Example: usr_abc123
        /// </summary>
        /// <example>usr_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: john@example.com
        /// </summary>
        /// <example>john@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSharingOwner" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the user<br/>
        /// Example: usr_abc123
        /// </param>
        /// <param name="email">
        /// Example: john@example.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationSharingOwner(
            string id,
            string email)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSharingOwner" /> class.
        /// </summary>
        public ConversationSharingOwner()
        {
        }

    }
}