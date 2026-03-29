
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasourceView
    {
        /// <summary>
        /// The category of the data source view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.DatasourceViewCategoryJsonConverter))]
        public global::Dust.DatasourceViewCategory? Category { get; set; }

        /// <summary>
        /// Timestamp of when the data source view was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSource")]
        public global::Dust.Datasource? DataSource { get; set; }

        /// <summary>
        /// The user who last edited the data source view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editedByUser")]
        public global::Dust.DatasourceViewEditedByUser? EditedByUser { get; set; }

        /// <summary>
        /// Unique identifier for the data source view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public double? Id { get; set; }

        /// <summary>
        /// The kind of the data source view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.DatasourceViewKindJsonConverter))]
        public global::Dust.DatasourceViewKind? Kind { get; set; }

        /// <summary>
        /// List of IDs included in this view, null if complete data source is taken
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentsIn")]
        public global::System.Collections.Generic.IList<string>? ParentsIn { get; set; }

        /// <summary>
        /// Unique string identifier for the data source view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Timestamp of when the data source view was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// ID of the space containing the data source view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceId")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasourceView" /> class.
        /// </summary>
        /// <param name="category">
        /// The category of the data source view
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the data source view was created
        /// </param>
        /// <param name="dataSource"></param>
        /// <param name="editedByUser">
        /// The user who last edited the data source view
        /// </param>
        /// <param name="id">
        /// Unique identifier for the data source view
        /// </param>
        /// <param name="kind">
        /// The kind of the data source view
        /// </param>
        /// <param name="parentsIn">
        /// List of IDs included in this view, null if complete data source is taken
        /// </param>
        /// <param name="sId">
        /// Unique string identifier for the data source view
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the data source view was last updated
        /// </param>
        /// <param name="spaceId">
        /// ID of the space containing the data source view
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasourceView(
            global::Dust.DatasourceViewCategory? category,
            double? createdAt,
            global::Dust.Datasource? dataSource,
            global::Dust.DatasourceViewEditedByUser? editedByUser,
            double? id,
            global::Dust.DatasourceViewKind? kind,
            global::System.Collections.Generic.IList<string>? parentsIn,
            string? sId,
            double? updatedAt,
            string? spaceId)
        {
            this.Category = category;
            this.CreatedAt = createdAt;
            this.DataSource = dataSource;
            this.EditedByUser = editedByUser;
            this.Id = id;
            this.Kind = kind;
            this.ParentsIn = parentsIn;
            this.SId = sId;
            this.UpdatedAt = updatedAt;
            this.SpaceId = spaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasourceView" /> class.
        /// </summary>
        public DatasourceView()
        {
        }
    }
}