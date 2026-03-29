
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSpacesDataSourcesTablesRowsRequestRowValue2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWSpacesDataSourcesTablesRowsRequestRowValueTypeJsonConverter))]
        public global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValueType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("epoch")]
        public double? Epoch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesTablesRowsRequestRowValue2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="epoch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesDataSourcesTablesRowsRequestRowValue2(
            global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValueType? type,
            double? epoch)
        {
            this.Type = type;
            this.Epoch = epoch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesTablesRowsRequestRowValue2" /> class.
        /// </summary>
        public CreateWSpacesDataSourcesTablesRowsRequestRowValue2()
        {
        }
    }
}