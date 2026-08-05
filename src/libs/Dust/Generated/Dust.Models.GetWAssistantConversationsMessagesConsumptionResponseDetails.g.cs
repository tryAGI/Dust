
#nullable enable

namespace Dust
{
    /// <summary>
    /// Additive attribution reconciled to the bill through model input rows, using the newest complete stored attribution version. Null when no stored version is complete.
    /// </summary>
    public sealed partial class GetWAssistantConversationsMessagesConsumptionResponseDetails
    {
        /// <summary>
        /// Attribution version used for this breakdown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributionVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AttributionVersion { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetailsTool> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesConsumptionResponseDetails" /> class.
        /// </summary>
        /// <param name="attributionVersion">
        /// Attribution version used for this breakdown.
        /// </param>
        /// <param name="agentWorkCredits">
        /// Agent work after assigning billing reconciliation exclusively to model input rows.
        /// </param>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsMessagesConsumptionResponseDetails(
            int attributionVersion,
            double agentWorkCredits,
            global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetailsTool> tools)
        {
            this.AttributionVersion = attributionVersion;
            this.AgentWorkCredits = agentWorkCredits;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesConsumptionResponseDetails" /> class.
        /// </summary>
        public GetWAssistantConversationsMessagesConsumptionResponseDetails()
        {
        }

    }
}