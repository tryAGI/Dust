
#nullable enable

namespace Dust
{
    /// <summary>
    /// Conversation without content, used in list responses.
    /// </summary>
    public sealed partial class PrivateConversation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Unix timestamp of creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Unix timestamp of last update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Updated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unread")]
        public bool? Unread { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastReadMs")]
        public int? LastReadMs { get; set; }

        /// <summary>
        /// Whether the conversation requires user action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionRequired")]
        public bool? ActionRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasError")]
        public bool? HasError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// ID of the space the conversation belongs to (for project conversations)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceId")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerId")]
        public string? TriggerId { get; set; }

        /// <summary>
        /// Conversation depth (for agent handover chains)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Depth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedSpaceIds")]
        public global::System.Collections.Generic.IList<string>? RequestedSpaceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="created">
        /// Unix timestamp of creation
        /// </param>
        /// <param name="updated">
        /// Unix timestamp of last update
        /// </param>
        /// <param name="sId"></param>
        /// <param name="depth">
        /// Conversation depth (for agent handover chains)
        /// </param>
        /// <param name="unread"></param>
        /// <param name="lastReadMs"></param>
        /// <param name="actionRequired">
        /// Whether the conversation requires user action
        /// </param>
        /// <param name="hasError"></param>
        /// <param name="title"></param>
        /// <param name="spaceId">
        /// ID of the space the conversation belongs to (for project conversations)
        /// </param>
        /// <param name="triggerId"></param>
        /// <param name="metadata"></param>
        /// <param name="requestedSpaceIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateConversation(
            int id,
            global::System.DateTimeOffset created,
            global::System.DateTimeOffset updated,
            string sId,
            int depth,
            bool? unread,
            int? lastReadMs,
            bool? actionRequired,
            bool? hasError,
            string? title,
            string? spaceId,
            string? triggerId,
            object? metadata,
            global::System.Collections.Generic.IList<string>? requestedSpaceIds)
        {
            this.Id = id;
            this.Created = created;
            this.Updated = updated;
            this.Unread = unread;
            this.LastReadMs = lastReadMs;
            this.ActionRequired = actionRequired;
            this.HasError = hasError;
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Title = title;
            this.SpaceId = spaceId;
            this.TriggerId = triggerId;
            this.Depth = depth;
            this.Metadata = metadata;
            this.RequestedSpaceIds = requestedSpaceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversation" /> class.
        /// </summary>
        public PrivateConversation()
        {
        }
    }
}