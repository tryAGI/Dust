
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateConversationConsumptionToolDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalMCPServerName")]
        public string? InternalMCPServerName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CallCount { get; set; }

        /// <summary>
        /// Share of billed credits after reconciling exclusively through model input rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributedCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AttributedCredits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DirectCredits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pending { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationConsumptionToolDetails" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="toolName"></param>
        /// <param name="callCount"></param>
        /// <param name="attributedCredits">
        /// Share of billed credits after reconciling exclusively through model input rows.
        /// </param>
        /// <param name="directCredits"></param>
        /// <param name="pending"></param>
        /// <param name="internalMCPServerName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateConversationConsumptionToolDetails(
            string label,
            string toolName,
            int callCount,
            double attributedCredits,
            double directCredits,
            bool pending,
            string? internalMCPServerName)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.InternalMCPServerName = internalMCPServerName;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.CallCount = callCount;
            this.AttributedCredits = attributedCredits;
            this.DirectCredits = directCredits;
            this.Pending = pending;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationConsumptionToolDetails" /> class.
        /// </summary>
        public PrivateConversationConsumptionToolDetails()
        {
        }

    }
}