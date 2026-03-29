
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateAgentGenerationCancelledEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateAgentGenerationCancelledEventTypeJsonConverter))]
        public global::Dust.PrivateAgentGenerationCancelledEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public int? Step { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentGenerationCancelledEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="configurationId"></param>
        /// <param name="messageId"></param>
        /// <param name="type"></param>
        /// <param name="step"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateAgentGenerationCancelledEvent(
            int created,
            string configurationId,
            string messageId,
            global::Dust.PrivateAgentGenerationCancelledEventType type,
            int? step)
        {
            this.Type = type;
            this.Created = created;
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentGenerationCancelledEvent" /> class.
        /// </summary>
        public PrivateAgentGenerationCancelledEvent()
        {
        }
    }
}