
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationConsumptionAgentDetails
    {
        /// <summary>
        /// String identifier of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// Stable billed credits grouped under this agent. Hidden helpers are folded into their parent agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BilledCredits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentWorkCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AgentWorkCredits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.ConversationConsumptionToolDetails> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.ConversationConsumptionModelDetails> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConsumptionAgentDetails" /> class.
        /// </summary>
        /// <param name="agentId">
        /// String identifier of the agent.
        /// </param>
        /// <param name="name"></param>
        /// <param name="billedCredits">
        /// Stable billed credits grouped under this agent. Hidden helpers are folded into their parent agent.
        /// </param>
        /// <param name="agentWorkCredits"></param>
        /// <param name="tools"></param>
        /// <param name="models"></param>
        /// <param name="pictureUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConsumptionAgentDetails(
            string agentId,
            string name,
            double billedCredits,
            double agentWorkCredits,
            global::System.Collections.Generic.IList<global::Dust.ConversationConsumptionToolDetails> tools,
            global::System.Collections.Generic.IList<global::Dust.ConversationConsumptionModelDetails> models,
            string? pictureUrl)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PictureUrl = pictureUrl;
            this.BilledCredits = billedCredits;
            this.AgentWorkCredits = agentWorkCredits;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConsumptionAgentDetails" /> class.
        /// </summary>
        public ConversationConsumptionAgentDetails()
        {
        }

    }
}