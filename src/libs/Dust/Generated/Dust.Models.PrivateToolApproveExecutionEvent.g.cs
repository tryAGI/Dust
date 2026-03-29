
#nullable enable

namespace Dust
{
    /// <summary>
    /// Sent when a tool requires user approval before execution.
    /// </summary>
    public sealed partial class PrivateToolApproveExecutionEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateToolApproveExecutionEventTypeJsonConverter))]
        public global::Dust.PrivateToolApproveExecutionEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Inputs { get; set; }

        /// <summary>
        /// Risk level of the tool execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stake")]
        public string? Stake { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isLastBlockingEventForStep")]
        public bool? IsLastBlockingEventForStep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

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
        /// Initializes a new instance of the <see cref="PrivateToolApproveExecutionEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="actionId"></param>
        /// <param name="configurationId"></param>
        /// <param name="inputs"></param>
        /// <param name="type"></param>
        /// <param name="stake">
        /// Risk level of the tool execution
        /// </param>
        /// <param name="isLastBlockingEventForStep"></param>
        /// <param name="metadata"></param>
        /// <param name="step"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateToolApproveExecutionEvent(
            int created,
            string conversationId,
            string messageId,
            string actionId,
            string configurationId,
            object inputs,
            global::Dust.PrivateToolApproveExecutionEventType type,
            string? stake,
            bool? isLastBlockingEventForStep,
            object? metadata,
            int? step)
        {
            this.Type = type;
            this.Created = created;
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.ActionId = actionId ?? throw new global::System.ArgumentNullException(nameof(actionId));
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Stake = stake;
            this.IsLastBlockingEventForStep = isLastBlockingEventForStep;
            this.Metadata = metadata;
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateToolApproveExecutionEvent" /> class.
        /// </summary>
        public PrivateToolApproveExecutionEvent()
        {
        }
    }
}