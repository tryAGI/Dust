
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Datasource
    {
        /// <summary>
        /// Unique identifier for the datasource<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Timestamp of when the datasource was created<br/>
        /// Example: 1625097600
        /// </summary>
        /// <example>1625097600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// Name of the datasource<br/>
        /// Example: Customer Knowledge Base
        /// </summary>
        /// <example>Customer Knowledge Base</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the datasource<br/>
        /// Example: Contains all customer-related information and FAQs
        /// </summary>
        /// <example>Contains all customer-related information and FAQs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// ID of the associated Dust API project<br/>
        /// Example: 5e9d8c7b6a
        /// </summary>
        /// <example>5e9d8c7b6a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dustAPIProjectId")]
        public string? DustAPIProjectId { get; set; }

        /// <summary>
        /// ID of the connector used for this datasource<br/>
        /// Example: 1f3e5d7c9b
        /// </summary>
        /// <example>1f3e5d7c9b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectorId")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// Provider of the connector (e.g., 'webcrawler')<br/>
        /// Example: webcrawler
        /// </summary>
        /// <example>webcrawler</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectorProvider")]
        public string? ConnectorProvider { get; set; }

        /// <summary>
        /// Whether this datasource is selected by default for agents<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantDefaultSelected")]
        public bool? AssistantDefaultSelected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Datasource" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the datasource<br/>
        /// Example: 12345
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the datasource was created<br/>
        /// Example: 1625097600
        /// </param>
        /// <param name="name">
        /// Name of the datasource<br/>
        /// Example: Customer Knowledge Base
        /// </param>
        /// <param name="description">
        /// Description of the datasource<br/>
        /// Example: Contains all customer-related information and FAQs
        /// </param>
        /// <param name="dustAPIProjectId">
        /// ID of the associated Dust API project<br/>
        /// Example: 5e9d8c7b6a
        /// </param>
        /// <param name="connectorId">
        /// ID of the connector used for this datasource<br/>
        /// Example: 1f3e5d7c9b
        /// </param>
        /// <param name="connectorProvider">
        /// Provider of the connector (e.g., 'webcrawler')<br/>
        /// Example: webcrawler
        /// </param>
        /// <param name="assistantDefaultSelected">
        /// Whether this datasource is selected by default for agents<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Datasource(
            int? id,
            int? createdAt,
            string? name,
            string? description,
            string? dustAPIProjectId,
            string? connectorId,
            string? connectorProvider,
            bool? assistantDefaultSelected)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Name = name;
            this.Description = description;
            this.DustAPIProjectId = dustAPIProjectId;
            this.ConnectorId = connectorId;
            this.ConnectorProvider = connectorProvider;
            this.AssistantDefaultSelected = assistantDefaultSelected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Datasource" /> class.
        /// </summary>
        public Datasource()
        {
        }
    }
}