
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Run
    {
        /// <summary>
        /// The ID of the run<br/>
        /// Example: 4a2c6e8b0d
        /// </summary>
        /// <example>4a2c6e8b0d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// The ID of the app<br/>
        /// Example: 9f1d3b5a7c
        /// </summary>
        /// <example>9f1d3b5a7c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Dust.RunStatus? Status { get; set; }

        /// <summary>
        /// The results of the run<br/>
        /// Example: {}
        /// </summary>
        /// <example>{}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public object? Results { get; set; }

        /// <summary>
        /// The hash of the app specification<br/>
        /// Example: 8c0a4e6d2f
        /// </summary>
        /// <example>8c0a4e6d2f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("specification_hash")]
        public string? SpecificationHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.RunTraceItem>>? Traces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        /// <param name="runId">
        /// The ID of the run<br/>
        /// Example: 4a2c6e8b0d
        /// </param>
        /// <param name="appId">
        /// The ID of the app<br/>
        /// Example: 9f1d3b5a7c
        /// </param>
        /// <param name="status"></param>
        /// <param name="results">
        /// The results of the run<br/>
        /// Example: {}
        /// </param>
        /// <param name="specificationHash">
        /// The hash of the app specification<br/>
        /// Example: 8c0a4e6d2f
        /// </param>
        /// <param name="traces"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Run(
            string? runId,
            string? appId,
            global::Dust.RunStatus? status,
            object? results,
            string? specificationHash,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.RunTraceItem>>? traces)
        {
            this.RunId = runId;
            this.AppId = appId;
            this.Status = status;
            this.Results = results;
            this.SpecificationHash = specificationHash;
            this.Traces = traces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        public Run()
        {
        }
    }
}