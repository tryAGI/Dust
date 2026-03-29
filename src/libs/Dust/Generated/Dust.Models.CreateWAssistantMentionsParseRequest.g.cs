
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantMentionsParseRequest
    {
        /// <summary>
        /// Markdown text containing @ mentions to parse<br/>
        /// Example: Hello @JohnDoe, can you help with @MyAgent?
        /// </summary>
        /// <example>Hello @JohnDoe, can you help with @MyAgent?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantMentionsParseRequest" /> class.
        /// </summary>
        /// <param name="markdown">
        /// Markdown text containing @ mentions to parse<br/>
        /// Example: Hello @JohnDoe, can you help with @MyAgent?
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantMentionsParseRequest(
            string markdown)
        {
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantMentionsParseRequest" /> class.
        /// </summary>
        public CreateWAssistantMentionsParseRequest()
        {
        }
    }
}