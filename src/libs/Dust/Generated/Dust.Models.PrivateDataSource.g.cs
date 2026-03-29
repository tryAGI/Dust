
#nullable enable

namespace Dust
{
    /// <summary>
    /// A data source in the workspace.
    /// </summary>
    public sealed partial class PrivateDataSource
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
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantDefaultSelected")]
        public bool? AssistantDefaultSelected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dustAPIProjectId")]
        public string? DustAPIProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dustAPIDataSourceId")]
        public string? DustAPIDataSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectorId")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectorProvider")]
        public string? ConnectorProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateDataSource" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="assistantDefaultSelected"></param>
        /// <param name="dustAPIProjectId"></param>
        /// <param name="dustAPIDataSourceId"></param>
        /// <param name="connectorId"></param>
        /// <param name="connectorProvider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateDataSource(
            string sId,
            int id,
            string name,
            int? createdAt,
            string? description,
            bool? assistantDefaultSelected,
            string? dustAPIProjectId,
            string? dustAPIDataSourceId,
            string? connectorId,
            string? connectorProvider)
        {
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.AssistantDefaultSelected = assistantDefaultSelected;
            this.DustAPIProjectId = dustAPIProjectId;
            this.DustAPIDataSourceId = dustAPIDataSourceId;
            this.ConnectorId = connectorId;
            this.ConnectorProvider = connectorProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateDataSource" /> class.
        /// </summary>
        public PrivateDataSource()
        {
        }
    }
}