
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationConsumptionModelDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// Provider model identifier, not an internal database identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Reconciled credits grouped by model, including tool attribution linked to its runs. Overlaps agent work and tool totals.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributedCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AttributedCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConsumptionModelDetails" /> class.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="modelId">
        /// Provider model identifier, not an internal database identifier.
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="attributedCredits">
        /// Reconciled credits grouped by model, including tool attribution linked to its runs. Overlaps agent work and tool totals.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConsumptionModelDetails(
            string providerId,
            string modelId,
            string displayName,
            double attributedCredits)
        {
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.AttributedCredits = attributedCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConsumptionModelDetails" /> class.
        /// </summary>
        public ConversationConsumptionModelDetails()
        {
        }

    }
}