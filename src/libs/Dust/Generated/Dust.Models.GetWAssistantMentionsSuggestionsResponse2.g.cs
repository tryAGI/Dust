
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantMentionsSuggestionsResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestions")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateMentionSuggestion>? Suggestions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantMentionsSuggestionsResponse2" /> class.
        /// </summary>
        /// <param name="suggestions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantMentionsSuggestionsResponse2(
            global::System.Collections.Generic.IList<global::Dust.PrivateMentionSuggestion>? suggestions)
        {
            this.Suggestions = suggestions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantMentionsSuggestionsResponse2" /> class.
        /// </summary>
        public GetWAssistantMentionsSuggestionsResponse2()
        {
        }
    }
}