
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSpacesAppsRunsRequest
    {
        /// <summary>
        /// Hash of the app specification. Ensures API compatibility across app iterations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specification_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpecificationHash { get; set; }

        /// <summary>
        /// Configuration for the app run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWSpacesAppsRunsRequestConfig Config { get; set; }

        /// <summary>
        /// Array of input objects for the app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Inputs { get; set; }

        /// <summary>
        /// If true, the response will be streamed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// If true, the request will block until the run is complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking")]
        public bool? Blocking { get; set; }

        /// <summary>
        /// Array of block names to filter the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_filter")]
        public global::System.Collections.Generic.IList<string>? BlockFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesAppsRunsRequest" /> class.
        /// </summary>
        /// <param name="specificationHash">
        /// Hash of the app specification. Ensures API compatibility across app iterations.
        /// </param>
        /// <param name="config">
        /// Configuration for the app run
        /// </param>
        /// <param name="inputs">
        /// Array of input objects for the app
        /// </param>
        /// <param name="stream">
        /// If true, the response will be streamed
        /// </param>
        /// <param name="blocking">
        /// If true, the request will block until the run is complete
        /// </param>
        /// <param name="blockFilter">
        /// Array of block names to filter the response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesAppsRunsRequest(
            string specificationHash,
            global::Dust.CreateWSpacesAppsRunsRequestConfig config,
            global::System.Collections.Generic.IList<object> inputs,
            bool? stream,
            bool? blocking,
            global::System.Collections.Generic.IList<string>? blockFilter)
        {
            this.SpecificationHash = specificationHash ?? throw new global::System.ArgumentNullException(nameof(specificationHash));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Stream = stream;
            this.Blocking = blocking;
            this.BlockFilter = blockFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesAppsRunsRequest" /> class.
        /// </summary>
        public CreateWSpacesAppsRunsRequest()
        {
        }
    }
}