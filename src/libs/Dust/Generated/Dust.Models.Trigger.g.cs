
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Trigger
    {
        /// <summary>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Unique string identifier for the trigger<br/>
        /// Example: 0ec9852c2f
        /// </summary>
        /// <example>0ec9852c2f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// Example: Daily summary
        /// </summary>
        /// <example>Daily summary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// sId of the agent this trigger runs<br/>
        /// Example: 8f3a1c2d9e
        /// </summary>
        /// <example>8f3a1c2d9e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfigurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentConfigurationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.TriggerKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.TriggerKind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.TriggerStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.TriggerStatus Status { get; set; }

        /// <summary>
        /// Example: 1625097600
        /// </summary>
        /// <example>1625097600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customPrompt")]
        public string? CustomPrompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("naturalLanguageDescription")]
        public string? NaturalLanguageDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.TriggerExecutionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.TriggerExecutionMode ExecutionMode { get; set; }

        /// <summary>
        /// For `kind: schedule`, either a cron config (`cron`, `timezone`) or an interval<br/>
        /// config (`intervalDays`, `dayOfWeek`, `hour`, `minute`, `timezone`). For<br/>
        /// `kind: webhook`, `{ includePayload, event?, filter? }`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Configuration { get; set; }

        /// <summary>
        /// Present only for `kind: webhook` triggers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookSource")]
        public global::Dust.TriggerWebhookSource? WebhookSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Trigger" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 12345
        /// </param>
        /// <param name="sId">
        /// Unique string identifier for the trigger<br/>
        /// Example: 0ec9852c2f
        /// </param>
        /// <param name="name">
        /// Example: Daily summary
        /// </param>
        /// <param name="agentConfigurationId">
        /// sId of the agent this trigger runs<br/>
        /// Example: 8f3a1c2d9e
        /// </param>
        /// <param name="kind"></param>
        /// <param name="status"></param>
        /// <param name="createdAt">
        /// Example: 1625097600
        /// </param>
        /// <param name="executionMode"></param>
        /// <param name="configuration">
        /// For `kind: schedule`, either a cron config (`cron`, `timezone`) or an interval<br/>
        /// config (`intervalDays`, `dayOfWeek`, `hour`, `minute`, `timezone`). For<br/>
        /// `kind: webhook`, `{ includePayload, event?, filter? }`.
        /// </param>
        /// <param name="customPrompt"></param>
        /// <param name="naturalLanguageDescription"></param>
        /// <param name="webhookSource">
        /// Present only for `kind: webhook` triggers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Trigger(
            int id,
            string sId,
            string name,
            string agentConfigurationId,
            global::Dust.TriggerKind kind,
            global::Dust.TriggerStatus status,
            int createdAt,
            global::Dust.TriggerExecutionMode executionMode,
            object configuration,
            string? customPrompt,
            string? naturalLanguageDescription,
            global::Dust.TriggerWebhookSource? webhookSource)
        {
            this.Id = id;
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AgentConfigurationId = agentConfigurationId ?? throw new global::System.ArgumentNullException(nameof(agentConfigurationId));
            this.Kind = kind;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.CustomPrompt = customPrompt;
            this.NaturalLanguageDescription = naturalLanguageDescription;
            this.ExecutionMode = executionMode;
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.WebhookSource = webhookSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trigger" /> class.
        /// </summary>
        public Trigger()
        {
        }

    }
}