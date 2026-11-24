
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetWPodsExportResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pods")]
        public global::System.Collections.Generic.IList<global::Dust.GetWPodsExportResponsePod>? Pods { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWPodsExportResponse" /> class.
        /// </summary>
        /// <param name="pods"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWPodsExportResponse(
            global::System.Collections.Generic.IList<global::Dust.GetWPodsExportResponsePod>? pods)
        {
            this.Pods = pods;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWPodsExportResponse" /> class.
        /// </summary>
        public GetWPodsExportResponse()
        {
        }

    }
}