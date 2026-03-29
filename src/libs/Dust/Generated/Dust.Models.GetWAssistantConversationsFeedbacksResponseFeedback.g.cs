
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsFeedbacksResponseFeedback
    {
        /// <summary>
        /// ID of the message that received feedback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        public string? MessageId { get; set; }

        /// <summary>
        /// ID of the agent message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentMessageId")]
        public double? AgentMessageId { get; set; }

        /// <summary>
        /// ID of the user who gave feedback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public double? UserId { get; set; }

        /// <summary>
        /// Direction of the thumb feedback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbDirection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirectionJsonConverter))]
        public global::Dust.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection? ThumbDirection { get; set; }

        /// <summary>
        /// Optional feedback content/comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Timestamp when feedback was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// ID of the agent configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfigurationId")]
        public string? AgentConfigurationId { get; set; }

        /// <summary>
        /// Version of the agent configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfigurationVersion")]
        public double? AgentConfigurationVersion { get; set; }

        /// <summary>
        /// Whether the conversation was shared
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isConversationShared")]
        public bool? IsConversationShared { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsFeedbacksResponseFeedback" /> class.
        /// </summary>
        /// <param name="messageId">
        /// ID of the message that received feedback
        /// </param>
        /// <param name="agentMessageId">
        /// ID of the agent message
        /// </param>
        /// <param name="userId">
        /// ID of the user who gave feedback
        /// </param>
        /// <param name="thumbDirection">
        /// Direction of the thumb feedback
        /// </param>
        /// <param name="content">
        /// Optional feedback content/comment
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when feedback was created
        /// </param>
        /// <param name="agentConfigurationId">
        /// ID of the agent configuration
        /// </param>
        /// <param name="agentConfigurationVersion">
        /// Version of the agent configuration
        /// </param>
        /// <param name="isConversationShared">
        /// Whether the conversation was shared
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsFeedbacksResponseFeedback(
            string? messageId,
            double? agentMessageId,
            double? userId,
            global::Dust.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection? thumbDirection,
            string? content,
            double? createdAt,
            string? agentConfigurationId,
            double? agentConfigurationVersion,
            bool? isConversationShared)
        {
            this.MessageId = messageId;
            this.AgentMessageId = agentMessageId;
            this.UserId = userId;
            this.ThumbDirection = thumbDirection;
            this.Content = content;
            this.CreatedAt = createdAt;
            this.AgentConfigurationId = agentConfigurationId;
            this.AgentConfigurationVersion = agentConfigurationVersion;
            this.IsConversationShared = isConversationShared;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsFeedbacksResponseFeedback" /> class.
        /// </summary>
        public GetWAssistantConversationsFeedbacksResponseFeedback()
        {
        }
    }
}