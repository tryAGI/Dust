
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConversation1ContentItemItemRawContent
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public int? Step { get; set; }

        /// <summary>
        /// Content for each step<br/>
        /// Example: Hello! I'd be happy to help you with your order. Could you please provide your order number?
        /// </summary>
        /// <example>Hello! I'd be happy to help you with your order. Could you please provide your order number?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConversation1ContentItemItemRawContent" /> class.
        /// </summary>
        /// <param name="step">
        /// Example: 1
        /// </param>
        /// <param name="content">
        /// Content for each step<br/>
        /// Example: Hello! I'd be happy to help you with your order. Could you please provide your order number?
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConversation1ContentItemItemRawContent(
            int? step,
            string? content)
        {
            this.Step = step;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConversation1ContentItemItemRawContent" /> class.
        /// </summary>
        public ConversationConversation1ContentItemItemRawContent()
        {
        }
    }
}