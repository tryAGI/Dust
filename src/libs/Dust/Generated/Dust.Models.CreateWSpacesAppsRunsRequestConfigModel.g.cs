
#nullable enable

namespace Dust
{
    /// <summary>
    /// Model configuration
    /// </summary>
    public sealed partial class CreateWSpacesAppsRunsRequestConfigModel
    {
        /// <summary>
        /// ID of the model provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// ID of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Whether to use caching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_cache")]
        public bool? UseCache { get; set; }

        /// <summary>
        /// Whether to use streaming
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_stream")]
        public bool? UseStream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesAppsRunsRequestConfigModel" /> class.
        /// </summary>
        /// <param name="providerId">
        /// ID of the model provider
        /// </param>
        /// <param name="modelId">
        /// ID of the model
        /// </param>
        /// <param name="useCache">
        /// Whether to use caching
        /// </param>
        /// <param name="useStream">
        /// Whether to use streaming
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesAppsRunsRequestConfigModel(
            string? providerId,
            string? modelId,
            bool? useCache,
            bool? useStream)
        {
            this.ProviderId = providerId;
            this.ModelId = modelId;
            this.UseCache = useCache;
            this.UseStream = useStream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesAppsRunsRequestConfigModel" /> class.
        /// </summary>
        public CreateWSpacesAppsRunsRequestConfigModel()
        {
        }
    }
}