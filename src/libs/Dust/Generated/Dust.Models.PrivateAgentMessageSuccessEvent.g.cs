
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateAgentMessageSuccessEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateAgentMessageSuccessEventTypeJsonConverter))]
        public global::Dust.PrivateAgentMessageSuccessEventType Type { get; set; }

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
        /// An agent message in a conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateAgentMessage Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RunIds { get; set; }

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
        /// Initializes a new instance of the <see cref="PrivateAgentMessageSuccessEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="configurationId"></param>
        /// <param name="messageId"></param>
        /// <param name="message">
        /// An agent message in a conversation.
        /// </param>
        /// <param name="runIds"></param>
        /// <param name="type"></param>
        /// <param name="step"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateAgentMessageSuccessEvent(
            int created,
            string configurationId,
            string messageId,
            global::Dust.PrivateAgentMessage message,
            global::System.Collections.Generic.IList<string> runIds,
            global::Dust.PrivateAgentMessageSuccessEventType type,
            int? step)
        {
            this.Type = type;
            this.Created = created;
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RunIds = runIds ?? throw new global::System.ArgumentNullException(nameof(runIds));
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentMessageSuccessEvent" /> class.
        /// </summary>
        public PrivateAgentMessageSuccessEvent()
        {
        }
    }
}