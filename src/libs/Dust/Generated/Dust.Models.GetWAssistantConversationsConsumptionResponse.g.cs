
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetWAssistantConversationsConsumptionResponse
    {
        /// <summary>
        /// Latest stable credits billed across completed messages belonging directly to the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BilledCredits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Dust.PrivateConversationConsumptionDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsConsumptionResponse" /> class.
        /// </summary>
        /// <param name="billedCredits">
        /// Latest stable credits billed across completed messages belonging directly to the conversation.
        /// </param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWAssistantConversationsConsumptionResponse(
            double billedCredits,
            global::Dust.PrivateConversationConsumptionDetails? details)
        {
            this.BilledCredits = billedCredits;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWAssistantConversationsConsumptionResponse" /> class.
        /// </summary>
        public GetWAssistantConversationsConsumptionResponse()
        {
        }

    }
}