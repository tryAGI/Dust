
#nullable enable

namespace Dust
{
    /// <summary>
    /// Sent when a tool requires file access authorization (e.g., Google Drive).
    /// </summary>
    public sealed partial class PrivateToolFileAuthRequiredEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateToolFileAuthRequiredEventTypeJsonConverter))]
        public global::Dust.PrivateToolFileAuthRequiredEventType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("fileAuthError")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateToolFileAuthRequiredEventFileAuthError FileAuthError { get; set; }

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
        /// Initializes a new instance of the <see cref="PrivateToolFileAuthRequiredEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="conversationId"></param>
        /// <param name="messageId"></param>
        /// <param name="actionId"></param>
        /// <param name="configurationId"></param>
        /// <param name="fileAuthError"></param>
        /// <param name="type"></param>
        /// <param name="step"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateToolFileAuthRequiredEvent(
            int created,
            string conversationId,
            string messageId,
            string actionId,
            string configurationId,
            global::Dust.PrivateToolFileAuthRequiredEventFileAuthError fileAuthError,
            global::Dust.PrivateToolFileAuthRequiredEventType type,
            int? step)
        {
            this.Type = type;
            this.Created = created;
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.ActionId = actionId ?? throw new global::System.ArgumentNullException(nameof(actionId));
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
            this.FileAuthError = fileAuthError ?? throw new global::System.ArgumentNullException(nameof(fileAuthError));
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateToolFileAuthRequiredEvent" /> class.
        /// </summary>
        public PrivateToolFileAuthRequiredEvent()
        {
        }
    }
}