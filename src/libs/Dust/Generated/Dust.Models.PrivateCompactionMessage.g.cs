
#nullable enable

namespace Dust
{
    /// <summary>
    /// A compaction message summarizing earlier conversation content.
    /// </summary>
    public sealed partial class PrivateCompactionMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateCompactionMessageTypeJsonConverter))]
        public global::Dust.PrivateCompactionMessageType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compactionMessageId")]
        public int? CompactionMessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateCompactionMessageVisibilityJsonConverter))]
        public global::Dust.PrivateCompactionMessageVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchId")]
        public string? BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateCompactionMessageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateCompactionMessageStatus Status { get; set; }

        /// <summary>
        /// Compacted summary. Null while status is "created".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateCompactionMessage" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="created"></param>
        /// <param name="version"></param>
        /// <param name="rank"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="compactionMessageId"></param>
        /// <param name="visibility"></param>
        /// <param name="branchId"></param>
        /// <param name="content">
        /// Compacted summary. Null while status is "created".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateCompactionMessage(
            string sId,
            int created,
            int version,
            int rank,
            global::Dust.PrivateCompactionMessageStatus status,
            global::Dust.PrivateCompactionMessageType type,
            int? id,
            int? compactionMessageId,
            global::Dust.PrivateCompactionMessageVisibility? visibility,
            string? branchId,
            string? content)
        {
            this.Type = type;
            this.Id = id;
            this.CompactionMessageId = compactionMessageId;
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Created = created;
            this.Visibility = visibility;
            this.Version = version;
            this.Rank = rank;
            this.BranchId = branchId;
            this.Status = status;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateCompactionMessage" /> class.
        /// </summary>
        public PrivateCompactionMessage()
        {
        }
    }
}