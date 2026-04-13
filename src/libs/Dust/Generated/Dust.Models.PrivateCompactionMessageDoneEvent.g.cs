
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateCompactionMessageDoneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateCompactionMessageDoneEventTypeJsonConverter))]
        public global::Dust.PrivateCompactionMessageDoneEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// A compaction message summarizing earlier conversation content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateCompactionMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateCompactionMessageDoneEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="messageId"></param>
        /// <param name="message">
        /// A compaction message summarizing earlier conversation content.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateCompactionMessageDoneEvent(
            int created,
            string messageId,
            global::Dust.PrivateCompactionMessage message,
            global::Dust.PrivateCompactionMessageDoneEventType type)
        {
            this.Type = type;
            this.Created = created;
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateCompactionMessageDoneEvent" /> class.
        /// </summary>
        public PrivateCompactionMessageDoneEvent()
        {
        }
    }
}