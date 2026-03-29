
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesResponseSpaceCategoriesUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<object>? Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponseSpaceCategoriesUsage" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="agents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesResponseSpaceCategoriesUsage(
            int? count,
            global::System.Collections.Generic.IList<object>? agents)
        {
            this.Count = count;
            this.Agents = agents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponseSpaceCategoriesUsage" /> class.
        /// </summary>
        public GetWSpacesResponseSpaceCategoriesUsage()
        {
        }
    }
}