
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetWSpacesDataSourcesTablesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tables")]
        public global::System.Collections.Generic.IList<global::Dust.Table>? Tables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesTablesResponse" /> class.
        /// </summary>
        /// <param name="tables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesDataSourcesTablesResponse(
            global::System.Collections.Generic.IList<global::Dust.Table>? tables)
        {
            this.Tables = tables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesDataSourcesTablesResponse" /> class.
        /// </summary>
        public GetWSpacesDataSourcesTablesResponse()
        {
        }

    }
}