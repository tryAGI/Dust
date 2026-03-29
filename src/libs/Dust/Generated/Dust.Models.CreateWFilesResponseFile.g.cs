
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWFilesResponseFile
    {
        /// <summary>
        /// Unique string identifier for the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Upload URL for the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadUrl")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWFilesResponseFile" /> class.
        /// </summary>
        /// <param name="sId">
        /// Unique string identifier for the file
        /// </param>
        /// <param name="uploadUrl">
        /// Upload URL for the file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWFilesResponseFile(
            string? sId,
            string? uploadUrl)
        {
            this.SId = sId;
            this.UploadUrl = uploadUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWFilesResponseFile" /> class.
        /// </summary>
        public CreateWFilesResponseFile()
        {
        }
    }
}