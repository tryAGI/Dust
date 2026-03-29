
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsRequestMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mentions")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateMention>? Mentions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Dust.CreateWAssistantConversationsRequestMessageContext? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequestMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="mentions"></param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsRequestMessage(
            string? content,
            global::System.Collections.Generic.IList<global::Dust.PrivateMention>? mentions,
            global::Dust.CreateWAssistantConversationsRequestMessageContext? context)
        {
            this.Content = content;
            this.Mentions = mentions;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequestMessage" /> class.
        /// </summary>
        public CreateWAssistantConversationsRequestMessage()
        {
        }
    }
}