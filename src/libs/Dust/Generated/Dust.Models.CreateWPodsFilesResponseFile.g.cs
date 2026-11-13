
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWPodsFilesResponseFile
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// The file's name, without its folders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// Scoped path inside the pod, including subfolders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWPodsFilesResponseFile" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="fileName">
        /// The file's name, without its folders.
        /// </param>
        /// <param name="path">
        /// Scoped path inside the pod, including subfolders.
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWPodsFilesResponseFile(
            string sId,
            string fileName,
            string path,
            string contentType,
            string status)
        {
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWPodsFilesResponseFile" /> class.
        /// </summary>
        public CreateWPodsFilesResponseFile()
        {
        }

    }
}