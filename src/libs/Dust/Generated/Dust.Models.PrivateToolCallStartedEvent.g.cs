
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateToolCallStartedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateToolCallStartedEventTypeJsonConverter))]
        public global::Dust.PrivateToolCallStartedEventType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCallId")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCallIndex")]
        public int? ToolCallIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

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
        /// Initializes a new instance of the <see cref="PrivateToolCallStartedEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="configurationId"></param>
        /// <param name="messageId"></param>
        /// <param name="toolName"></param>
        /// <param name="type"></param>
        /// <param name="toolCallId"></param>
        /// <param name="toolCallIndex"></param>
        /// <param name="step"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateToolCallStartedEvent(
            int created,
            string configurationId,
            string messageId,
            string toolName,
            global::Dust.PrivateToolCallStartedEventType type,
            string? toolCallId,
            int? toolCallIndex,
            int? step)
        {
            this.Type = type;
            this.Created = created;
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.ToolCallId = toolCallId;
            this.ToolCallIndex = toolCallIndex;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateToolCallStartedEvent" /> class.
        /// </summary>
        public PrivateToolCallStartedEvent()
        {
        }
    }
}