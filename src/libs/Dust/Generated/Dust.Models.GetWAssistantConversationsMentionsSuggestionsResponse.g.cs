
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsMentionsSuggestionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestions")]
        public global::System.Collections.Generic.IList<global::Dust.RichMention>? Suggestions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMentionsSuggestionsResponse" /> class.
        /// </summary>
        /// <param name="suggestions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsMentionsSuggestionsResponse(
            global::System.Collections.Generic.IList<global::Dust.RichMention>? suggestions)
        {
            this.Suggestions = suggestions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMentionsSuggestionsResponse" /> class.
        /// </summary>
        public GetWAssistantConversationsMentionsSuggestionsResponse()
        {
        }
    }
}