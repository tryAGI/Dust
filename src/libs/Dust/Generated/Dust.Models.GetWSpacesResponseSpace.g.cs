
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesResponseSpace
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.Dictionary<string, global::Dust.GetWSpacesResponseSpaceCategories2>? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canWrite")]
        public bool? CanWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canRead")]
        public bool? CanRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMember")]
        public bool? IsMember { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEditor")]
        public bool? IsEditor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<object>? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archivedAt")]
        public int? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponseSpace" /> class.
        /// </summary>
        /// <param name="categories"></param>
        /// <param name="canWrite"></param>
        /// <param name="canRead"></param>
        /// <param name="isMember"></param>
        /// <param name="isEditor"></param>
        /// <param name="members"></param>
        /// <param name="description"></param>
        /// <param name="archivedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesResponseSpace(
            global::System.Collections.Generic.Dictionary<string, global::Dust.GetWSpacesResponseSpaceCategories2>? categories,
            bool? canWrite,
            bool? canRead,
            bool? isMember,
            bool? isEditor,
            global::System.Collections.Generic.IList<object>? members,
            string? description,
            int? archivedAt)
        {
            this.Categories = categories;
            this.CanWrite = canWrite;
            this.CanRead = canRead;
            this.IsMember = isMember;
            this.IsEditor = isEditor;
            this.Members = members;
            this.Description = description;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponseSpace" /> class.
        /// </summary>
        public GetWSpacesResponseSpace()
        {
        }
    }
}