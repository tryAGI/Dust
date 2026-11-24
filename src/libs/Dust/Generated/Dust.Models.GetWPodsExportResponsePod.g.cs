
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetWPodsExportResponsePod
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podId")]
        public string? PodId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.GetWPodsExportResponsePodAccessJsonConverter))]
        public global::Dust.GetWPodsExportResponsePodAccess? Access { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.GetWPodsExportResponsePodStatusJsonConverter))]
        public global::Dust.GetWPodsExportResponsePodStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archivedAt")]
        public string? ArchivedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWPodsExportResponsePod" /> class.
        /// </summary>
        /// <param name="podId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="access"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="archivedAt"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWPodsExportResponsePod(
            string? podId,
            string? name,
            string? description,
            global::Dust.GetWPodsExportResponsePodAccess? access,
            global::Dust.GetWPodsExportResponsePodStatus? status,
            string? createdAt,
            string? archivedAt,
            string? url)
        {
            this.PodId = podId;
            this.Name = name;
            this.Description = description;
            this.Access = access;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.ArchivedAt = archivedAt;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWPodsExportResponsePod" /> class.
        /// </summary>
        public GetWPodsExportResponsePod()
        {
        }

    }
}