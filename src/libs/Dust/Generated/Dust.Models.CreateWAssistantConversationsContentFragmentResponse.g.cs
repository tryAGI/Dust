
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsContentFragmentResponse
    {
        /// <summary>
        /// A content fragment (file or content node attachment) in a conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentFragment")]
        public global::Dust.PrivateContentFragment? ContentFragment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsContentFragmentResponse" /> class.
        /// </summary>
        /// <param name="contentFragment">
        /// A content fragment (file or content node attachment) in a conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsContentFragmentResponse(
            global::Dust.PrivateContentFragment? contentFragment)
        {
            this.ContentFragment = contentFragment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsContentFragmentResponse" /> class.
        /// </summary>
        public CreateWAssistantConversationsContentFragmentResponse()
        {
        }
    }
}