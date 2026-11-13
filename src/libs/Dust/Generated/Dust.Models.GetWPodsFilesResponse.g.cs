
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetWPodsFilesResponse
    {
        /// <summary>
        /// Relative paths inside the pod, the same paths accepted by the upload<br/>
        /// endpoint (`reports/q3.txt`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWPodsFilesResponse" /> class.
        /// </summary>
        /// <param name="files">
        /// Relative paths inside the pod, the same paths accepted by the upload<br/>
        /// endpoint (`reports/q3.txt`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWPodsFilesResponse(
            global::System.Collections.Generic.IList<string> files)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWPodsFilesResponse" /> class.
        /// </summary>
        public GetWPodsFilesResponse()
        {
        }

    }
}