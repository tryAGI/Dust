
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWSpacesDataSourceViewsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataSourceId { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourceViewsRequest" /> class.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="parentsIn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesDataSourceViewsRequest(
            string dataSourceId,
            global::System.Collections.Generic.IList<string>? parentsIn)
        {
            this.DataSourceId = dataSourceId ?? throw new global::System.ArgumentNullException(nameof(dataSourceId));
            this.ParentsIn = parentsIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesDataSourceViewsRequest" /> class.
        /// </summary>
        public CreateWSpacesDataSourceViewsRequest()
        {
        }
    }
}