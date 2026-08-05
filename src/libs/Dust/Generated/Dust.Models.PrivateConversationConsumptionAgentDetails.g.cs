
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateConversationConsumptionAgentDetails
    {
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BilledCredits { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationConsumptionAgentDetails" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="name"></param>
        /// <param name="billedCredits"></param>
        /// <param name="agentWorkCredits">
        /// Agent work after assigning billing reconciliation exclusively to model input rows.
        /// </param>
        /// <param name="tools"></param>
        /// <param name="models"></param>
        /// <param name="pictureUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateConversationConsumptionAgentDetails(
            string agentId,
            string name,
            double billedCredits,
            double agentWorkCredits,
            global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionToolDetails> tools,
            global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionModelDetails> models,
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
        /// Initializes a new instance of the <see cref="PrivateConversationConsumptionAgentDetails" /> class.
        /// </summary>
        public PrivateConversationConsumptionAgentDetails()
        {
        }

    }
}