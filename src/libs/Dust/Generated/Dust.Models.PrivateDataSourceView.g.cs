
#nullable enable

namespace Dust
{
    /// <summary>
    /// A view on a data source within a space.
    /// </summary>
    public sealed partial class PrivateDataSourceView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateDataSourceViewCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateDataSourceViewCategory Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateDataSourceViewKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateDataSourceViewKind Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public int? UpdatedAt { get; set; }

        /// <summary>
        /// List of parent IDs included in this view, null if the full data source is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentsIn")]
        public global::System.Collections.Generic.IList<string>? ParentsIn { get; set; }

        /// <summary>
        /// A data source in the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateDataSource DataSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editedByUser")]
        public global::Dust.PrivateDataSourceViewEditedByUser? EditedByUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateDataSourceView" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="id"></param>
        /// <param name="category"></param>
        /// <param name="kind"></param>
        /// <param name="spaceId"></param>
        /// <param name="dataSource">
        /// A data source in the workspace.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="parentsIn">
        /// List of parent IDs included in this view, null if the full data source is used
        /// </param>
        /// <param name="editedByUser"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateDataSourceView(
            string sId,
            int id,
            global::Dust.PrivateDataSourceViewCategory category,
            global::Dust.PrivateDataSourceViewKind kind,
            string spaceId,
            global::Dust.PrivateDataSource dataSource,
            int? createdAt,
            int? updatedAt,
            global::System.Collections.Generic.IList<string>? parentsIn,
            global::Dust.PrivateDataSourceViewEditedByUser? editedByUser)
        {
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Id = id;
            this.Category = category;
            this.Kind = kind;
            this.SpaceId = spaceId ?? throw new global::System.ArgumentNullException(nameof(spaceId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ParentsIn = parentsIn;
            this.DataSource = dataSource ?? throw new global::System.ArgumentNullException(nameof(dataSource));
            this.EditedByUser = editedByUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateDataSourceView" /> class.
        /// </summary>
        public PrivateDataSourceView()
        {
        }
    }
}