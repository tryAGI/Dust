
#nullable enable

namespace Dust
{
    /// <summary>
    /// User feedback on an agent message.
    /// </summary>
    public sealed partial class PrivateFeedback
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentMessageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AgentMessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbDirection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateFeedbackThumbDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateFeedbackThumbDirection ThumbDirection { get; set; }

        /// <summary>
        /// Optional text feedback from the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfigurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfigurationVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AgentConfigurationVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isConversationShared")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsConversationShared { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Dismissed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFeedback" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sId"></param>
        /// <param name="messageId"></param>
        /// <param name="agentMessageId"></param>
        /// <param name="userId"></param>
        /// <param name="thumbDirection"></param>
        /// <param name="createdAt"></param>
        /// <param name="agentConfigurationId"></param>
        /// <param name="agentConfigurationVersion"></param>
        /// <param name="isConversationShared"></param>
        /// <param name="dismissed"></param>
        /// <param name="content">
        /// Optional text feedback from the user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateFeedback(
            int id,
            string sId,
            string messageId,
            int agentMessageId,
            int userId,
            global::Dust.PrivateFeedbackThumbDirection thumbDirection,
            global::System.DateTime createdAt,
            string agentConfigurationId,
            int agentConfigurationVersion,
            bool isConversationShared,
            bool dismissed,
            string? content)
        {
            this.Id = id;
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.AgentMessageId = agentMessageId;
            this.UserId = userId;
            this.ThumbDirection = thumbDirection;
            this.Content = content;
            this.CreatedAt = createdAt;
            this.AgentConfigurationId = agentConfigurationId ?? throw new global::System.ArgumentNullException(nameof(agentConfigurationId));
            this.AgentConfigurationVersion = agentConfigurationVersion;
            this.IsConversationShared = isConversationShared;
            this.Dismissed = dismissed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFeedback" /> class.
        /// </summary>
        public PrivateFeedback()
        {
        }
    }
}