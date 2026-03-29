
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesEditRequest
    {
        /// <summary>
        /// New content for the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// List of agent mentions in the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mentions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention> Mentions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesEditRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// New content for the message
        /// </param>
        /// <param name="mentions">
        /// List of agent mentions in the message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesEditRequest(
            string content,
            global::System.Collections.Generic.IList<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention> mentions)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Mentions = mentions ?? throw new global::System.ArgumentNullException(nameof(mentions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesEditRequest" /> class.
        /// </summary>
        public CreateWAssistantConversationsMessagesEditRequest()
        {
        }
    }
}