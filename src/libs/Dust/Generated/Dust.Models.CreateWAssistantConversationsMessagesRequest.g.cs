
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsMessagesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mentions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateMention> Mentions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWAssistantConversationsMessagesRequestContext Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipToolsValidation")]
        public bool? SkipToolsValidation { get; set; }

        /// <summary>
        /// Optional per-message model override from the input-bar model picker (an explicit model pick).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelSelection")]
        public global::Dust.CreateWAssistantConversationsMessagesRequestModelSelection? ModelSelection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesRequest" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="mentions"></param>
        /// <param name="context"></param>
        /// <param name="skipToolsValidation"></param>
        /// <param name="modelSelection">
        /// Optional per-message model override from the input-bar model picker (an explicit model pick).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsMessagesRequest(
            string content,
            global::System.Collections.Generic.IList<global::Dust.PrivateMention> mentions,
            global::Dust.CreateWAssistantConversationsMessagesRequestContext context,
            bool? skipToolsValidation,
            global::Dust.CreateWAssistantConversationsMessagesRequestModelSelection? modelSelection)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Mentions = mentions ?? throw new global::System.ArgumentNullException(nameof(mentions));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.SkipToolsValidation = skipToolsValidation;
            this.ModelSelection = modelSelection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsMessagesRequest" /> class.
        /// </summary>
        public CreateWAssistantConversationsMessagesRequest()
        {
        }

    }
}