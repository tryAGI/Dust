
#nullable enable

namespace Dust
{
    /// <summary>
    /// Additive attribution reconciled to the authoritative bill exclusively through model input rows. Each message uses its newest complete stored attribution version. Null when any billed message has no complete stored attribution.
    /// </summary>
    public sealed partial class PrivateConversationConsumptionDetails
    {
        /// <summary>
        /// Agent work after assigning billing reconciliation exclusively to model input rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentWorkCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AgentWorkCredits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionToolDetails> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionModelDetails> Models { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionAgentDetails> Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationConsumptionDetails" /> class.
        /// </summary>
        /// <param name="agentWorkCredits">
        /// Agent work after assigning billing reconciliation exclusively to model input rows.
        /// </param>
        /// <param name="tools"></param>
        /// <param name="models"></param>
        /// <param name="agents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateConversationConsumptionDetails(
            double agentWorkCredits,
            global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionToolDetails> tools,
            global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionModelDetails> models,
            global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionAgentDetails> agents)
        {
            this.AgentWorkCredits = agentWorkCredits;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationConsumptionDetails" /> class.
        /// </summary>
        public PrivateConversationConsumptionDetails()
        {
        }

    }
}