
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWSpacesDataSourceViewsRequestVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentsIn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ParentsIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesDataSourceViewsRequestVariant1" /> class.
        /// </summary>
        /// <param name="parentsIn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWSpacesDataSourceViewsRequestVariant1(
            global::System.Collections.Generic.IList<string> parentsIn)
        {
            this.ParentsIn = parentsIn ?? throw new global::System.ArgumentNullException(nameof(parentsIn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesDataSourceViewsRequestVariant1" /> class.
        /// </summary>
        public PatchWSpacesDataSourceViewsRequestVariant1()
        {
        }
    }
}