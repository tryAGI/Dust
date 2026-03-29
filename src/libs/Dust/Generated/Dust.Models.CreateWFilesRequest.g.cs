
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWFilesRequest
    {
        /// <summary>
        /// MIME type of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// Name of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FileSize { get; set; }

        /// <summary>
        /// Intended use case for the file, use "conversation"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useCase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UseCase { get; set; }

        /// <summary>
        /// (optional) Metadata for the use case, for conversation useCase should be dictionary with conversationId stringified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useCaseMetadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UseCaseMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWFilesRequest" /> class.
        /// </summary>
        /// <param name="contentType">
        /// MIME type of the file
        /// </param>
        /// <param name="fileName">
        /// Name of the file
        /// </param>
        /// <param name="fileSize">
        /// Size of the file in bytes
        /// </param>
        /// <param name="useCase">
        /// Intended use case for the file, use "conversation"
        /// </param>
        /// <param name="useCaseMetadata">
        /// (optional) Metadata for the use case, for conversation useCase should be dictionary with conversationId stringified
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWFilesRequest(
            string contentType,
            string fileName,
            int fileSize,
            string useCase,
            string useCaseMetadata)
        {
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileSize = fileSize;
            this.UseCase = useCase ?? throw new global::System.ArgumentNullException(nameof(useCase));
            this.UseCaseMetadata = useCaseMetadata ?? throw new global::System.ArgumentNullException(nameof(useCaseMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWFilesRequest" /> class.
        /// </summary>
        public CreateWFilesRequest()
        {
        }
    }
}