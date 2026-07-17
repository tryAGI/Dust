
#nullable enable

namespace Dust
{
    /// <summary>
    /// Optional per-message model and reasoning-effort override applied to the<br/>
    /// mentioned agent(s). When omitted, each agent runs its configured model.<br/>
    /// If the requested model is not available to the workspace, the agent's<br/>
    /// configured model is used instead. An unknown provider, model, or<br/>
    /// reasoning effort results in a 400.
    /// </summary>
    public sealed partial class ModelSelection
    {
        /// <summary>
        /// The model provider id (e.g. "anthropic", "openai", "google_ai_studio").<br/>
        /// Example: anthropic
        /// </summary>
        /// <example>anthropic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// The model id to run (e.g. "claude-sonnet-4-20250514").<br/>
        /// Example: claude-sonnet-4-20250514
        /// </summary>
        /// <example>claude-sonnet-4-20250514</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Optional reasoning effort. Honored only if the resolved model supports it.<br/>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningEffort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.ModelSelectionReasoningEffortJsonConverter))]
        public global::Dust.ModelSelectionReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSelection" /> class.
        /// </summary>
        /// <param name="providerId">
        /// The model provider id (e.g. "anthropic", "openai", "google_ai_studio").<br/>
        /// Example: anthropic
        /// </param>
        /// <param name="modelId">
        /// The model id to run (e.g. "claude-sonnet-4-20250514").<br/>
        /// Example: claude-sonnet-4-20250514
        /// </param>
        /// <param name="reasoningEffort">
        /// Optional reasoning effort. Honored only if the resolved model supports it.<br/>
        /// Example: medium
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelSelection(
            string providerId,
            string modelId,
            global::Dust.ModelSelectionReasoningEffort? reasoningEffort)
        {
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSelection" /> class.
        /// </summary>
        public ModelSelection()
        {
        }

    }
}