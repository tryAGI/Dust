
#nullable enable

namespace Dust
{
    /// <summary>
    /// A lighter agent message used in paginated message list responses.
    /// </summary>
    public sealed partial class PrivateLightAgentMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateLightAgentMessageTypeJsonConverter))]
        public global::Dust.PrivateLightAgentMessageType Type { get; set; }

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
        public int? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedTs")]
        public int? CompletedTs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateLightAgentMessageVisibilityJsonConverter))]
        public global::Dust.PrivateLightAgentMessageVisibility? Visibility { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("parentMessageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentMessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentAgentMessageId")]
        public string? ParentAgentMessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateLightAgentMessageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateLightAgentMessageStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainOfThought")]
        public string? ChainOfThought { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Dust.PrivateLightAgentMessageError? Error { get; set; }

        /// <summary>
        /// Minimal agent configuration info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateLightAgentMessageConfiguration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.Dictionary<string, global::Dust.PrivateCitation>? Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generatedFiles")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentMessageGeneratedFile>? GeneratedFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("richMentions")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateRichMentionWithStatus>? RichMentions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionDurationMs")]
        public int? CompletionDurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activitySteps")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentMessageActivityStep>? ActivitySteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateReaction>? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentMessage" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="version"></param>
        /// <param name="rank"></param>
        /// <param name="parentMessageId"></param>
        /// <param name="status"></param>
        /// <param name="configuration">
        /// Minimal agent configuration info
        /// </param>
        /// <param name="type"></param>
        /// <param name="created"></param>
        /// <param name="completedTs"></param>
        /// <param name="visibility"></param>
        /// <param name="parentAgentMessageId"></param>
        /// <param name="content"></param>
        /// <param name="chainOfThought"></param>
        /// <param name="error"></param>
        /// <param name="citations"></param>
        /// <param name="generatedFiles"></param>
        /// <param name="richMentions"></param>
        /// <param name="completionDurationMs"></param>
        /// <param name="activitySteps"></param>
        /// <param name="reactions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateLightAgentMessage(
            string sId,
            int version,
            int rank,
            string parentMessageId,
            global::Dust.PrivateLightAgentMessageStatus status,
            global::Dust.PrivateLightAgentMessageConfiguration configuration,
            global::Dust.PrivateLightAgentMessageType type,
            int? created,
            int? completedTs,
            global::Dust.PrivateLightAgentMessageVisibility? visibility,
            string? parentAgentMessageId,
            string? content,
            string? chainOfThought,
            global::Dust.PrivateLightAgentMessageError? error,
            global::System.Collections.Generic.Dictionary<string, global::Dust.PrivateCitation>? citations,
            global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentMessageGeneratedFile>? generatedFiles,
            global::System.Collections.Generic.IList<global::Dust.PrivateRichMentionWithStatus>? richMentions,
            int? completionDurationMs,
            global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentMessageActivityStep>? activitySteps,
            global::System.Collections.Generic.IList<global::Dust.PrivateReaction>? reactions)
        {
            this.Type = type;
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Created = created;
            this.CompletedTs = completedTs;
            this.Visibility = visibility;
            this.Version = version;
            this.Rank = rank;
            this.ParentMessageId = parentMessageId ?? throw new global::System.ArgumentNullException(nameof(parentMessageId));
            this.ParentAgentMessageId = parentAgentMessageId;
            this.Status = status;
            this.Content = content;
            this.ChainOfThought = chainOfThought;
            this.Error = error;
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Citations = citations;
            this.GeneratedFiles = generatedFiles;
            this.RichMentions = richMentions;
            this.CompletionDurationMs = completionDurationMs;
            this.ActivitySteps = activitySteps;
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentMessage" /> class.
        /// </summary>
        public PrivateLightAgentMessage()
        {
        }
    }
}