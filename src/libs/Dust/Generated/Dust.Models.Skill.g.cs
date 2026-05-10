
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Skill
    {
        /// <summary>
        /// Unique string identifier for the skill<br/>
        /// Example: skill_abc123
        /// </summary>
        /// <example>skill_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Timestamp of when the skill was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the skill was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// Numeric identifier of the last editor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editedBy")]
        public int? EditedBy { get; set; }

        /// <summary>
        /// Current status of the skill<br/>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.SkillStatusJsonConverter))]
        public global::Dust.SkillStatus? Status { get; set; }

        /// <summary>
        /// Name of the skill<br/>
        /// Example: Customer Support
        /// </summary>
        /// <example>Customer Support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description shown to agents when selecting or using the skill<br/>
        /// Example: Use this skill to answer customer support questions.
        /// </summary>
        /// <example>Use this skill to answer customer support questions.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentFacingDescription")]
        public string? AgentFacingDescription { get; set; }

        /// <summary>
        /// Description shown to workspace users<br/>
        /// Example: Answers support questions with the right workspace context.
        /// </summary>
        /// <example>Answers support questions with the right workspace context.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFacingDescription")]
        public string? UserFacingDescription { get; set; }

        /// <summary>
        /// Icon identifier for the skill<br/>
        /// Example: ActionRobotIcon
        /// </summary>
        /// <example>ActionRobotIcon</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Source used to create or import the skill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.SkillSourceJsonConverter))]
        public global::Dust.SkillSource? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceMetadata")]
        public global::Dust.SkillSourceMetadata? SourceMetadata { get; set; }

        /// <summary>
        /// Reinforcement setting for the skill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reinforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.SkillReinforcementJsonConverter))]
        public global::Dust.SkillReinforcement? Reinforcement { get; set; }

        /// <summary>
        /// Timestamp of the last reinforcement analysis, when available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastReinforcementAnalysisAt")]
        public string? LastReinforcementAnalysisAt { get; set; }

        /// <summary>
        /// Space identifiers the skill needs access to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedSpaceIds")]
        public global::System.Collections.Generic.IList<string>? RequestedSpaceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileAttachments")]
        public global::System.Collections.Generic.IList<global::Dust.SkillFileAttachment>? FileAttachments { get; set; }

        /// <summary>
        /// Whether the authenticated actor can edit the skill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canWrite")]
        public bool? CanWrite { get; set; }

        /// <summary>
        /// Whether this skill can be extended by another skill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isExtendable")]
        public bool? IsExtendable { get; set; }

        /// <summary>
        /// Whether this skill is enabled by default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Identifier of the extended skill, when applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extendedSkillId")]
        public string? ExtendedSkillId { get; set; }

        /// <summary>
        /// Instructions used by the agent when running the skill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// HTML representation of the skill instructions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructionsHtml")]
        public string? InstructionsHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Dust.MCPServerView>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Skill" /> class.
        /// </summary>
        /// <param name="sId">
        /// Unique string identifier for the skill<br/>
        /// Example: skill_abc123
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the skill was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the skill was last updated
        /// </param>
        /// <param name="editedBy">
        /// Numeric identifier of the last editor
        /// </param>
        /// <param name="status">
        /// Current status of the skill<br/>
        /// Example: active
        /// </param>
        /// <param name="name">
        /// Name of the skill<br/>
        /// Example: Customer Support
        /// </param>
        /// <param name="agentFacingDescription">
        /// Description shown to agents when selecting or using the skill<br/>
        /// Example: Use this skill to answer customer support questions.
        /// </param>
        /// <param name="userFacingDescription">
        /// Description shown to workspace users<br/>
        /// Example: Answers support questions with the right workspace context.
        /// </param>
        /// <param name="icon">
        /// Icon identifier for the skill<br/>
        /// Example: ActionRobotIcon
        /// </param>
        /// <param name="source">
        /// Source used to create or import the skill
        /// </param>
        /// <param name="sourceMetadata"></param>
        /// <param name="reinforcement">
        /// Reinforcement setting for the skill
        /// </param>
        /// <param name="lastReinforcementAnalysisAt">
        /// Timestamp of the last reinforcement analysis, when available
        /// </param>
        /// <param name="requestedSpaceIds">
        /// Space identifiers the skill needs access to
        /// </param>
        /// <param name="fileAttachments"></param>
        /// <param name="canWrite">
        /// Whether the authenticated actor can edit the skill
        /// </param>
        /// <param name="isExtendable">
        /// Whether this skill can be extended by another skill
        /// </param>
        /// <param name="isDefault">
        /// Whether this skill is enabled by default
        /// </param>
        /// <param name="extendedSkillId">
        /// Identifier of the extended skill, when applicable
        /// </param>
        /// <param name="instructions">
        /// Instructions used by the agent when running the skill
        /// </param>
        /// <param name="instructionsHtml">
        /// HTML representation of the skill instructions
        /// </param>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Skill(
            string? sId,
            double? createdAt,
            double? updatedAt,
            int? editedBy,
            global::Dust.SkillStatus? status,
            string? name,
            string? agentFacingDescription,
            string? userFacingDescription,
            string? icon,
            global::Dust.SkillSource? source,
            global::Dust.SkillSourceMetadata? sourceMetadata,
            global::Dust.SkillReinforcement? reinforcement,
            string? lastReinforcementAnalysisAt,
            global::System.Collections.Generic.IList<string>? requestedSpaceIds,
            global::System.Collections.Generic.IList<global::Dust.SkillFileAttachment>? fileAttachments,
            bool? canWrite,
            bool? isExtendable,
            bool? isDefault,
            string? extendedSkillId,
            string? instructions,
            string? instructionsHtml,
            global::System.Collections.Generic.IList<global::Dust.MCPServerView>? tools)
        {
            this.SId = sId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.EditedBy = editedBy;
            this.Status = status;
            this.Name = name;
            this.AgentFacingDescription = agentFacingDescription;
            this.UserFacingDescription = userFacingDescription;
            this.Icon = icon;
            this.Source = source;
            this.SourceMetadata = sourceMetadata;
            this.Reinforcement = reinforcement;
            this.LastReinforcementAnalysisAt = lastReinforcementAnalysisAt;
            this.RequestedSpaceIds = requestedSpaceIds;
            this.FileAttachments = fileAttachments;
            this.CanWrite = canWrite;
            this.IsExtendable = isExtendable;
            this.IsDefault = isDefault;
            this.ExtendedSkillId = extendedSkillId;
            this.Instructions = instructions;
            this.InstructionsHtml = instructionsHtml;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Skill" /> class.
        /// </summary>
        public Skill()
        {
        }

    }
}