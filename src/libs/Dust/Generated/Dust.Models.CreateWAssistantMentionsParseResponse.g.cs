
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantMentionsParseResponse
    {
        /// <summary>
        /// Processed markdown text with mentions converted to serialized format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantMentionsParseResponse" /> class.
        /// </summary>
        /// <param name="markdown">
        /// Processed markdown text with mentions converted to serialized format
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantMentionsParseResponse(
            string? markdown)
        {
            this.Markdown = markdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantMentionsParseResponse" /> class.
        /// </summary>
        public CreateWAssistantMentionsParseResponse()
        {
        }
    }
}