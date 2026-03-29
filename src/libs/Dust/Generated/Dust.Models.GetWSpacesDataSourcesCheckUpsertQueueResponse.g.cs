
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesDataSourcesCheckUpsertQueueResponse
    {
        /// <summary>
        /// Number of currently running upsert workflows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running_count")]
        public double? RunningCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesCheckUpsertQueueResponse" /> class.
        /// </summary>
        /// <param name="runningCount">
        /// Number of currently running upsert workflows
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesDataSourcesCheckUpsertQueueResponse(
            double? runningCount)
        {
            this.RunningCount = runningCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesCheckUpsertQueueResponse" /> class.
        /// </summary>
        public GetWSpacesDataSourcesCheckUpsertQueueResponse()
        {
        }
    }
}