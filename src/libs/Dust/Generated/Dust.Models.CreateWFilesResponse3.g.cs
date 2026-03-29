
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWFilesResponse3
    {
        /// <summary>
        /// File record with a pre-signed upload URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::Dust.PrivateFileWithUploadUrl? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWFilesResponse3" /> class.
        /// </summary>
        /// <param name="file">
        /// File record with a pre-signed upload URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWFilesResponse3(
            global::Dust.PrivateFileWithUploadUrl? file)
        {
            this.File = file;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWFilesResponse3" /> class.
        /// </summary>
        public CreateWFilesResponse3()
        {
        }
    }
}