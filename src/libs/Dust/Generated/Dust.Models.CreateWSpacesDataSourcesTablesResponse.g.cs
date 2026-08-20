
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSpacesDataSourcesTablesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        public global::Dust.Table? Table { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesTablesResponse" /> class.
        /// </summary>
        /// <param name="table"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesDataSourcesTablesResponse(
            global::Dust.Table? table)
        {
            this.Table = table;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesTablesResponse" /> class.
        /// </summary>
        public CreateWSpacesDataSourcesTablesResponse()
        {
        }

    }
}