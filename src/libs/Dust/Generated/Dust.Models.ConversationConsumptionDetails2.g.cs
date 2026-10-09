
#nullable enable

namespace Dust
{
    /// <summary>
    /// Attribution reconciled to the bill through model input rows. Agent work plus tool attributed credits partition the bill; models and agents are alternative groupings, not additional charges.
    /// </summary>
    public sealed partial class ConversationConsumptionDetails2
    {
        /// <summary>
        /// Credits attributed to agent work rather than visible tools.
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.ConversationConsumptionAgentDetails> Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConsumptionDetails2" /> class.
        /// </summary>
        /// <param name="agentWorkCredits">
        /// Credits attributed to agent work rather than visible tools.
        /// </param>
        /// <param name="tools"></param>
        /// <param name="models"></param>
        /// <param name="agents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConsumptionDetails2(
            double agentWorkCredits,
            global::System.Collections.Generic.IList<global::Dust.ConversationConsumptionToolDetails> tools,
            global::System.Collections.Generic.IList<global::Dust.ConversationConsumptionModelDetails> models,
            global::System.Collections.Generic.IList<global::Dust.ConversationConsumptionAgentDetails> agents)
        {
            this.AgentWorkCredits = agentWorkCredits;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConsumptionDetails2" /> class.
        /// </summary>
        public ConversationConsumptionDetails2()
        {
        }

    }
}