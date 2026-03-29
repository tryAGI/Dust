
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateLightAgentConfigurationModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningEffort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateLightAgentConfigurationModelReasoningEffortJsonConverter))]
        public global::Dust.PrivateLightAgentConfigurationModelReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentConfigurationModel" /> class.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="modelId"></param>
        /// <param name="temperature"></param>
        /// <param name="reasoningEffort"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateLightAgentConfigurationModel(
            string? providerId,
            string? modelId,
            double? temperature,
            global::Dust.PrivateLightAgentConfigurationModelReasoningEffort? reasoningEffort)
        {
            this.ProviderId = providerId;
            this.ModelId = modelId;
            this.Temperature = temperature;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentConfigurationModel" /> class.
        /// </summary>
        public PrivateLightAgentConfigurationModel()
        {
        }
    }
}