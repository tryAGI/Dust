
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateLightAgentMessageActivityStep
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateLightAgentMessageActivityStepTypeJsonConverter))]
        public global::Dust.PrivateLightAgentMessageActivityStepType? Type { get; set; }

        /// <summary>
        /// Chain of thought text (thinking steps only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Action display label (action steps only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Action string identifier (action steps only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionId")]
        public string? ActionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentMessageActivityStep" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content">
        /// Chain of thought text (thinking steps only)
        /// </param>
        /// <param name="label">
        /// Action display label (action steps only)
        /// </param>
        /// <param name="id"></param>
        /// <param name="actionId">
        /// Action string identifier (action steps only)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateLightAgentMessageActivityStep(
            global::Dust.PrivateLightAgentMessageActivityStepType? type,
            string? content,
            string? label,
            string? id,
            string? actionId)
        {
            this.Type = type;
            this.Content = content;
            this.Label = label;
            this.Id = id;
            this.ActionId = actionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentMessageActivityStep" /> class.
        /// </summary>
        public PrivateLightAgentMessageActivityStep()
        {
        }
    }
}