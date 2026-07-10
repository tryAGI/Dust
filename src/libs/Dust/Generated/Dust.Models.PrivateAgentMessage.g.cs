
#nullable enable

namespace Dust
{
    /// <summary>
    /// An agent message in a conversation.
    /// </summary>
    public sealed partial class PrivateAgentMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentMessageId")]
        public int? AgentMessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateAgentMessageTypeJsonConverter))]
        public global::Dust.PrivateAgentMessageType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateAgentMessageVisibilityJsonConverter))]
        public global::Dust.PrivateAgentMessageVisibility? Visibility { get; set; }

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
        /// If handover, the agent message that summoned this agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentAgentMessageId")]
        public string? ParentAgentMessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateAgentMessageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateAgentMessageStatus Status { get; set; }

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
        public global::Dust.PrivateAgentMessageError? Error { get; set; }

        /// <summary>
        /// Agent configuration as returned by the private list endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::Dust.PrivateLightAgentConfiguration? Configuration { get; set; }

        /// <summary>
        /// MCP actions executed by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<object>? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateAgentMessageContent>? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipToolsValidation")]
        public bool? SkipToolsValidation { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateReaction>? Reactions { get; set; }

        /// <summary>
        /// Cost of producing this agent message, in credits (intelligence + tool credits). Null when no billable usage is attributed to the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costCredits")]
        public int? CostCredits { get; set; }

        /// <summary>
        /// Aggregated credit cost of all sub-agents (run_agent / agent_handover) spawned recursively by this message. Computed only on single-message fetches; null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subAgentCostCredits")]
        public double? SubAgentCostCredits { get; set; }

        /// <summary>
        /// Model triplet used to generate the message. Null when the agent ran its configured model (legacy).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolvedModel")]
        public global::Dust.PrivateAgentMessageResolvedModel? ResolvedModel { get; set; }

        /// <summary>
        /// How resolvedModel was chosen - agent (configured model), user (per-message picker), or auto (routed through the auto model). Null (legacy).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelResolutionMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateAgentMessageModelResolutionMethodJsonConverter))]
        public global::Dust.PrivateAgentMessageModelResolutionMethod? ModelResolutionMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentMessage" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="version"></param>
        /// <param name="rank"></param>
        /// <param name="parentMessageId"></param>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="agentMessageId"></param>
        /// <param name="type"></param>
        /// <param name="created"></param>
        /// <param name="completedTs"></param>
        /// <param name="visibility"></param>
        /// <param name="parentAgentMessageId">
        /// If handover, the agent message that summoned this agent
        /// </param>
        /// <param name="content"></param>
        /// <param name="chainOfThought"></param>
        /// <param name="error"></param>
        /// <param name="configuration">
        /// Agent configuration as returned by the private list endpoint.
        /// </param>
        /// <param name="actions">
        /// MCP actions executed by the agent
        /// </param>
        /// <param name="contents"></param>
        /// <param name="skipToolsValidation"></param>
        /// <param name="richMentions"></param>
        /// <param name="completionDurationMs"></param>
        /// <param name="reactions"></param>
        /// <param name="costCredits">
        /// Cost of producing this agent message, in credits (intelligence + tool credits). Null when no billable usage is attributed to the message.
        /// </param>
        /// <param name="subAgentCostCredits">
        /// Aggregated credit cost of all sub-agents (run_agent / agent_handover) spawned recursively by this message. Computed only on single-message fetches; null otherwise.
        /// </param>
        /// <param name="resolvedModel">
        /// Model triplet used to generate the message. Null when the agent ran its configured model (legacy).
        /// </param>
        /// <param name="modelResolutionMethod">
        /// How resolvedModel was chosen - agent (configured model), user (per-message picker), or auto (routed through the auto model). Null (legacy).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateAgentMessage(
            string sId,
            int version,
            int rank,
            string parentMessageId,
            global::Dust.PrivateAgentMessageStatus status,
            int? id,
            int? agentMessageId,
            global::Dust.PrivateAgentMessageType type,
            int? created,
            int? completedTs,
            global::Dust.PrivateAgentMessageVisibility? visibility,
            string? parentAgentMessageId,
            string? content,
            string? chainOfThought,
            global::Dust.PrivateAgentMessageError? error,
            global::Dust.PrivateLightAgentConfiguration? configuration,
            global::System.Collections.Generic.IList<object>? actions,
            global::System.Collections.Generic.IList<global::Dust.PrivateAgentMessageContent>? contents,
            bool? skipToolsValidation,
            global::System.Collections.Generic.IList<global::Dust.PrivateRichMentionWithStatus>? richMentions,
            int? completionDurationMs,
            global::System.Collections.Generic.IList<global::Dust.PrivateReaction>? reactions,
            int? costCredits,
            double? subAgentCostCredits,
            global::Dust.PrivateAgentMessageResolvedModel? resolvedModel,
            global::Dust.PrivateAgentMessageModelResolutionMethod? modelResolutionMethod)
        {
            this.Id = id;
            this.AgentMessageId = agentMessageId;
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
            this.Configuration = configuration;
            this.Actions = actions;
            this.Contents = contents;
            this.SkipToolsValidation = skipToolsValidation;
            this.RichMentions = richMentions;
            this.CompletionDurationMs = completionDurationMs;
            this.Reactions = reactions;
            this.CostCredits = costCredits;
            this.SubAgentCostCredits = subAgentCostCredits;
            this.ResolvedModel = resolvedModel;
            this.ModelResolutionMethod = modelResolutionMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentMessage" /> class.
        /// </summary>
        public PrivateAgentMessage()
        {
        }

    }
}