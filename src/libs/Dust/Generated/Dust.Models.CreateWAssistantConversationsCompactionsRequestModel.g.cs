
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsCompactionsRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsCompactionsRequestModel" /> class.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="modelId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsCompactionsRequestModel(
            string providerId,
            string modelId)
        {
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsCompactionsRequestModel" /> class.
        /// </summary>
        public CreateWAssistantConversationsCompactionsRequestModel()
        {
        }
    }
}