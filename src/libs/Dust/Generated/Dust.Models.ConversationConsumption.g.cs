
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationConsumption
    {
        /// <summary>
        /// Stable billed Dust credits for terminal agent messages in the conversation and its accessible run-agent descendants, including superseded message versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BilledCredits { get; set; }

        /// <summary>
        /// Null when no messages have positive billed credits or any billed message lacks complete attribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Dust.ConversationConsumptionDetails2? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConsumption" /> class.
        /// </summary>
        /// <param name="billedCredits">
        /// Stable billed Dust credits for terminal agent messages in the conversation and its accessible run-agent descendants, including superseded message versions.
        /// </param>
        /// <param name="details">
        /// Null when no messages have positive billed credits or any billed message lacks complete attribution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConsumption(
            double billedCredits,
            global::Dust.ConversationConsumptionDetails2? details)
        {
            this.BilledCredits = billedCredits;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConsumption" /> class.
        /// </summary>
        public ConversationConsumption()
        {
        }

    }
}