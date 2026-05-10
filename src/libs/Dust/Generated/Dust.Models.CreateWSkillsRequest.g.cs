
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSkillsRequest
    {
        /// <summary>
        /// Skill files or ZIP archives to import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Optional skill names to import from the uploaded files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        public global::System.Collections.Generic.IList<string>? Names { get; set; }

        /// <summary>
        /// Conflict handling strategy. Defaults to error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onConflict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWSkillsRequestOnConflictJsonConverter))]
        public global::Dust.CreateWSkillsRequestOnConflict? OnConflict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSkillsRequest" /> class.
        /// </summary>
        /// <param name="files">
        /// Skill files or ZIP archives to import.
        /// </param>
        /// <param name="names">
        /// Optional skill names to import from the uploaded files.
        /// </param>
        /// <param name="onConflict">
        /// Conflict handling strategy. Defaults to error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSkillsRequest(
            global::System.Collections.Generic.IList<byte[]> files,
            global::System.Collections.Generic.IList<string>? names,
            global::Dust.CreateWSkillsRequestOnConflict? onConflict)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Names = names;
            this.OnConflict = onConflict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSkillsRequest" /> class.
        /// </summary>
        public CreateWSkillsRequest()
        {
        }

    }
}