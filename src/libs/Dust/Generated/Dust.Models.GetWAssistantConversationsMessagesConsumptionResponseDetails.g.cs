
#nullable enable

namespace Dust
{
    /// <summary>
    /// Cache-naive estimated attribution. Null when the active attribution version is unavailable or incomplete.
    /// </summary>
    public sealed partial class GetWAssistantConversationsMessagesConsumptionResponseDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributionVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AttributionVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grossAttributedCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double GrossAttributedCredits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimatedCacheSavingsCredits")]
        public double? EstimatedCacheSavingsCredits { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetailsTool> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesConsumptionResponseDetails" /> class.
        /// </summary>
        /// <param name="attributionVersion"></param>
        /// <param name="grossAttributedCredits"></param>
        /// <param name="agentWorkCredits"></param>
        /// <param name="tools"></param>
        /// <param name="estimatedCacheSavingsCredits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsMessagesConsumptionResponseDetails(
            int attributionVersion,
            double grossAttributedCredits,
            double agentWorkCredits,
            global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetailsTool> tools,
            double? estimatedCacheSavingsCredits)
        {
            this.AttributionVersion = attributionVersion;
            this.GrossAttributedCredits = grossAttributedCredits;
            this.EstimatedCacheSavingsCredits = estimatedCacheSavingsCredits;
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