
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWSpacesRequestContentItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSourceId")]
        public string? DataSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentsIn")]
        public global::System.Collections.Generic.IList<string>? ParentsIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesRequestContentItem" /> class.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="parentsIn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWSpacesRequestContentItem(
            string? dataSourceId,
            global::System.Collections.Generic.IList<string>? parentsIn)
        {
            this.DataSourceId = dataSourceId;
            this.ParentsIn = parentsIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesRequestContentItem" /> class.
        /// </summary>
        public PatchWSpacesRequestContentItem()
        {
        }
    }
}