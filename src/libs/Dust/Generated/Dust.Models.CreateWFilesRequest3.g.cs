
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWFilesRequest3
    {
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
        public required double FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useCase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWFilesRequestUseCaseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWFilesRequestUseCase UseCase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useCaseMetadata")]
        public object? UseCaseMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWFilesRequest3" /> class.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="fileName"></param>
        /// <param name="fileSize"></param>
        /// <param name="useCase"></param>
        /// <param name="useCaseMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWFilesRequest3(
            string contentType,
            string fileName,
            double fileSize,
            global::Dust.CreateWFilesRequestUseCase useCase,
            object? useCaseMetadata)
        {
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileSize = fileSize;
            this.UseCase = useCase;
            this.UseCaseMetadata = useCaseMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWFilesRequest3" /> class.
        /// </summary>
        public CreateWFilesRequest3()
        {
        }
    }
}