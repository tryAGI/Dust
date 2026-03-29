
#nullable enable

namespace Dust
{
    /// <summary>
    /// File record with a pre-signed upload URL.
    /// </summary>
    public sealed partial class PrivateFileWithUploadUrl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateFileWithUploadUrlStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateFileWithUploadUrlStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useCase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateFileWithUploadUrlUseCaseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateFileWithUploadUrlUseCase UseCase { get; set; }

        /// <summary>
        /// Pre-signed URL for uploading the file content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadUrl")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicUrl")]
        public string? PublicUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFileWithUploadUrl" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="id"></param>
        /// <param name="contentType"></param>
        /// <param name="fileName"></param>
        /// <param name="fileSize"></param>
        /// <param name="status"></param>
        /// <param name="useCase"></param>
        /// <param name="uploadUrl">
        /// Pre-signed URL for uploading the file content
        /// </param>
        /// <param name="version"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="publicUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateFileWithUploadUrl(
            string sId,
            string id,
            string contentType,
            string fileName,
            int fileSize,
            global::Dust.PrivateFileWithUploadUrlStatus status,
            global::Dust.PrivateFileWithUploadUrlUseCase useCase,
            string uploadUrl,
            int? version,
            string? downloadUrl,
            string? publicUrl)
        {
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileSize = fileSize;
            this.Version = version;
            this.Status = status;
            this.UseCase = useCase;
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.DownloadUrl = downloadUrl;
            this.PublicUrl = publicUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFileWithUploadUrl" /> class.
        /// </summary>
        public PrivateFileWithUploadUrl()
        {
        }
    }
}