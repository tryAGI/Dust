
#nullable enable

namespace Dust
{
    /// <summary>
    /// Progress notification from a running tool.
    /// </summary>
    public sealed partial class PrivateToolNotificationEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateToolNotificationEventTypeJsonConverter))]
        public global::Dust.PrivateToolNotificationEventType Type { get; set; }

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
        /// The MCP action producing the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Action { get; set; }

        /// <summary>
        /// Progress notification content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Notification { get; set; }

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
        /// Initializes a new instance of the <see cref="PrivateToolNotificationEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="configurationId"></param>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="action">
        /// The MCP action producing the notification
        /// </param>
        /// <param name="notification">
        /// Progress notification content
        /// </param>
        /// <param name="type"></param>
        /// <param name="step"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateToolNotificationEvent(
            int created,
            string configurationId,
            string conversationId,
            string messageId,
            object action,
            object notification,
            global::Dust.PrivateToolNotificationEventType type,
            int? step)
        {
            this.Type = type;
            this.Created = created;
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Notification = notification ?? throw new global::System.ArgumentNullException(nameof(notification));
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateToolNotificationEvent" /> class.
        /// </summary>
        public PrivateToolNotificationEvent()
        {
        }
    }
}