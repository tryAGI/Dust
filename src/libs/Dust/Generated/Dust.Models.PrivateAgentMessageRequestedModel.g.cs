
#nullable enable

namespace Dust
{
    /// <summary>
    /// Per-message model override from the input-bar model picker. Null when the agent ran its configured model.
    /// </summary>
    public sealed partial class PrivateAgentMessageRequestedModel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningEffort")]
        public string? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentMessageRequestedModel" /> class.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="modelId"></param>
        /// <param name="reasoningEffort"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateAgentMessageRequestedModel(
            string? providerId,
            string? modelId,
            string? reasoningEffort)
        {
            this.ProviderId = providerId;
            this.ModelId = modelId;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentMessageRequestedModel" /> class.
        /// </summary>
        public PrivateAgentMessageRequestedModel()
        {
        }

    }
}