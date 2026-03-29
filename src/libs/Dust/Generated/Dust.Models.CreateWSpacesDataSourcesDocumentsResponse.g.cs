
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSpacesDataSourcesDocumentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::Dust.Document? Document { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source")]
        public global::Dust.Datasource? DataSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesDocumentsResponse" /> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="dataSource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesDataSourcesDocumentsResponse(
            global::Dust.Document? document,
            global::Dust.Datasource? dataSource)
        {
            this.Document = document;
            this.DataSource = dataSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourcesDocumentsResponse" /> class.
        /// </summary>
        public CreateWSpacesDataSourcesDocumentsResponse()
        {
        }
    }
}