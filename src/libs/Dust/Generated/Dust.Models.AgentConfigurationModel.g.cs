
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigurationModel
    {
        /// <summary>
        /// ID of the model provider<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// ID of the specific model<br/>
        /// Example: gpt-4
        /// </summary>
        /// <example>gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Example: 0.7F
        /// </summary>
        /// <example>0.7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigurationModel" /> class.
        /// </summary>
        /// <param name="providerId">
        /// ID of the model provider<br/>
        /// Example: openai
        /// </param>
        /// <param name="modelId">
        /// ID of the specific model<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="temperature">
        /// Example: 0.7F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigurationModel(
            string? providerId,
            string? modelId,
            double? temperature)
        {
            this.ProviderId = providerId;
            this.ModelId = modelId;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigurationModel" /> class.
        /// </summary>
        public AgentConfigurationModel()
        {
        }
    }
}