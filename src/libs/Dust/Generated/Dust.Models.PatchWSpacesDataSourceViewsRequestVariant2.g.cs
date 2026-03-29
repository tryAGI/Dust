
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWSpacesDataSourceViewsRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentsToAdd")]
        public global::System.Collections.Generic.IList<string>? ParentsToAdd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentsToRemove")]
        public global::System.Collections.Generic.IList<string>? ParentsToRemove { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesDataSourceViewsRequestVariant2" /> class.
        /// </summary>
        /// <param name="parentsToAdd"></param>
        /// <param name="parentsToRemove"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWSpacesDataSourceViewsRequestVariant2(
            global::System.Collections.Generic.IList<string>? parentsToAdd,
            global::System.Collections.Generic.IList<string>? parentsToRemove)
        {
            this.ParentsToAdd = parentsToAdd;
            this.ParentsToRemove = parentsToRemove;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesDataSourceViewsRequestVariant2" /> class.
        /// </summary>
        public PatchWSpacesDataSourceViewsRequestVariant2()
        {
        }
    }
}