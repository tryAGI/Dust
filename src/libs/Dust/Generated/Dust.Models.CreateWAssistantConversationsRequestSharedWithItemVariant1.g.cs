
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWAssistantConversationsRequestSharedWithItemVariant1
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequestSharedWithItemVariant1" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of a member of the workspace<br/>
        /// Example: jane@example.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsRequestSharedWithItemVariant1(
            string email)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequestSharedWithItemVariant1" /> class.
        /// </summary>
        public CreateWAssistantConversationsRequestSharedWithItemVariant1()
        {
        }

    }
}