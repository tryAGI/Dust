
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWAssistantConversationsMessagesConsumptionResponse
    {
        /// <summary>
        /// Authoritative credits billed for this agent message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedCredits")]
        public double? BilledCredits { get; set; }

        /// <summary>
        /// Cache-naive estimated attribution. Null when the active attribution version is unavailable or incomplete.
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
        /// Authoritative credits billed for this agent message.
        /// </param>
        /// <param name="details">
        /// Cache-naive estimated attribution. Null when the active attribution version is unavailable or incomplete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsMessagesConsumptionResponse(
            double? billedCredits,
            global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetails? details)
        {
            this.BilledCredits = billedCredits;
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