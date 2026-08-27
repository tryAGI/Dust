
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWAssistantConversationsRequestMetadata
    {
        /// <summary>
        /// Use the database-backed filesystem for a fresh standalone conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useDatabaseFileSystem")]
        public bool? UseDatabaseFileSystem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequestMetadata" /> class.
        /// </summary>
        /// <param name="useDatabaseFileSystem">
        /// Use the database-backed filesystem for a fresh standalone conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsRequestMetadata(
            bool? useDatabaseFileSystem)
        {
            this.UseDatabaseFileSystem = useDatabaseFileSystem;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequestMetadata" /> class.
        /// </summary>
        public CreateWAssistantConversationsRequestMetadata()
        {
        }

    }
}