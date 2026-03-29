
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateButlerSuggestionCreatedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateButlerSuggestionCreatedEventTypeJsonConverter))]
        public global::Dust.PrivateButlerSuggestionCreatedEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// Butler suggestion details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Suggestion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateButlerSuggestionCreatedEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="suggestion">
        /// Butler suggestion details
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateButlerSuggestionCreatedEvent(
            int created,
            object suggestion,
            global::Dust.PrivateButlerSuggestionCreatedEventType type)
        {
            this.Type = type;
            this.Created = created;
            this.Suggestion = suggestion ?? throw new global::System.ArgumentNullException(nameof(suggestion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateButlerSuggestionCreatedEvent" /> class.
        /// </summary>
        public PrivateButlerSuggestionCreatedEvent()
        {
        }
    }
}