
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsMessagesConsumptionResponse
    {
        /// <summary>
        /// Authoritative credits billed directly for this agent message, excluding sub-agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedCredits")]
        public double? BilledCredits { get; set; }

        /// <summary>
        /// Total credits billed by this message and its recursively spawned sub-agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBilledCredits")]
        public double? TotalBilledCredits { get; set; }

        /// <summary>
        /// Additive attribution reconciled to totalBilledCredits through model input rows. Each run-agent tool row includes its sub-agent subtree's bill. Null when no stored version is complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesConsumptionResponse" /> class.
        /// </summary>
        /// <param name="billedCredits">
        /// Authoritative credits billed directly for this agent message, excluding sub-agents.
        /// </param>
        /// <param name="totalBilledCredits">
        /// Total credits billed by this message and its recursively spawned sub-agents.
        /// </param>
        /// <param name="details">
        /// Additive attribution reconciled to totalBilledCredits through model input rows. Each run-agent tool row includes its sub-agent subtree's bill. Null when no stored version is complete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsMessagesConsumptionResponse(
            double? billedCredits,
            double? totalBilledCredits,
            global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetails? details)
        {
            this.BilledCredits = billedCredits;
            this.TotalBilledCredits = totalBilledCredits;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsMessagesConsumptionResponse" /> class.
        /// </summary>
        public GetWAssistantConversationsMessagesConsumptionResponse()
        {
        }

    }
}