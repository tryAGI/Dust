
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSpacesDataSourcesTablesRowsRequestRow
    {
        /// <summary>
        /// Unique identifier for the row
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_id")]
        public string? RowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesTablesRowsRequestRow" /> class.
        /// </summary>
        /// <param name="rowId">
        /// Unique identifier for the row
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesDataSourcesTablesRowsRequestRow(
            string? rowId,
            object? value)
        {
            this.RowId = rowId;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesTablesRowsRequestRow" /> class.
        /// </summary>
        public CreateWSpacesDataSourcesTablesRowsRequestRow()
        {
        }
    }
}