
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesResponseSpaceCategories2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Dust.GetWSpacesResponseSpaceCategoriesUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponseSpaceCategories2" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesResponseSpaceCategories2(
            int? count,
            global::Dust.GetWSpacesResponseSpaceCategoriesUsage? usage)
        {
            this.Count = count;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponseSpaceCategories2" /> class.
        /// </summary>
        public GetWSpacesResponseSpaceCategories2()
        {
        }
    }
}