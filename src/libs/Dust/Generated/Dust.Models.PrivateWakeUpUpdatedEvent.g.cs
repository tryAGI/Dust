
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateWakeUpUpdatedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateWakeUpUpdatedEventTypeJsonConverter))]
        public global::Dust.PrivateWakeUpUpdatedEventType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("wakeUpId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WakeUpId { get; set; }

        /// <summary>
        /// sId of the user who owns the wake-up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateWakeUpUpdatedEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="conversationId"></param>
        /// <param name="wakeUpId"></param>
        /// <param name="userId">
        /// sId of the user who owns the wake-up.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateWakeUpUpdatedEvent(
            int created,
            string conversationId,
            string wakeUpId,
            string userId,
            global::Dust.PrivateWakeUpUpdatedEventType type)
        {
            this.Type = type;
            this.Created = created;
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.WakeUpId = wakeUpId ?? throw new global::System.ArgumentNullException(nameof(wakeUpId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateWakeUpUpdatedEvent" /> class.
        /// </summary>
        public PrivateWakeUpUpdatedEvent()
        {
        }

    }
}