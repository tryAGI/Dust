
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateButlerDoneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateButlerDoneEventTypeJsonConverter))]
        public global::Dust.PrivateButlerDoneEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateButlerDoneEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateButlerDoneEvent(
            int created,
            global::Dust.PrivateButlerDoneEventType type)
        {
            this.Type = type;
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateButlerDoneEvent" /> class.
        /// </summary>
        public PrivateButlerDoneEvent()
        {
        }
    }
}