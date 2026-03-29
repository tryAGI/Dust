
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPServerViewServer
    {
        /// <summary>
        /// Unique string identifier for the MCP server<br/>
        /// Example: mcp_srv_def456
        /// </summary>
        /// <example>mcp_srv_def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Name of the MCP server<br/>
        /// Example: Customer Data Server
        /// </summary>
        /// <example>Customer Data Server</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Version of the MCP server<br/>
        /// Example: 1.0.0
        /// </summary>
        /// <example>1.0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Description of the MCP server<br/>
        /// Example: Handles customer data operations and queries
        /// </summary>
        /// <example>Handles customer data operations and queries</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Icon identifier for the MCP server<br/>
        /// Example: database
        /// </summary>
        /// <example>database</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization")]
        public global::Dust.MCPServerViewServerAuthorization? Authorization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerTool>? Tools { get; set; }

        /// <summary>
        /// Availability status of the MCP server<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("availability")]
        public string? Availability { get; set; }

        /// <summary>
        /// Whether multiple instances of this server can be created<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowMultipleInstances")]
        public bool? AllowMultipleInstances { get; set; }

        /// <summary>
        /// URL to the server's documentation<br/>
        /// Example: https://docs.example.com/mcp-server
        /// </summary>
        /// <example>https://docs.example.com/mcp-server</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationUrl")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerViewServer" /> class.
        /// </summary>
        /// <param name="sId">
        /// Unique string identifier for the MCP server<br/>
        /// Example: mcp_srv_def456
        /// </param>
        /// <param name="name">
        /// Name of the MCP server<br/>
        /// Example: Customer Data Server
        /// </param>
        /// <param name="version">
        /// Version of the MCP server<br/>
        /// Example: 1.0.0
        /// </param>
        /// <param name="description">
        /// Description of the MCP server<br/>
        /// Example: Handles customer data operations and queries
        /// </param>
        /// <param name="icon">
        /// Icon identifier for the MCP server<br/>
        /// Example: database
        /// </param>
        /// <param name="authorization"></param>
        /// <param name="tools"></param>
        /// <param name="availability">
        /// Availability status of the MCP server<br/>
        /// Example: production
        /// </param>
        /// <param name="allowMultipleInstances">
        /// Whether multiple instances of this server can be created<br/>
        /// Example: false
        /// </param>
        /// <param name="documentationUrl">
        /// URL to the server's documentation<br/>
        /// Example: https://docs.example.com/mcp-server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerViewServer(
            string? sId,
            string? name,
            string? version,
            string? description,
            string? icon,
            global::Dust.MCPServerViewServerAuthorization? authorization,
            global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerTool>? tools,
            string? availability,
            bool? allowMultipleInstances,
            string? documentationUrl)
        {
            this.SId = sId;
            this.Name = name;
            this.Version = version;
            this.Description = description;
            this.Icon = icon;
            this.Authorization = authorization;
            this.Tools = tools;
            this.Availability = availability;
            this.AllowMultipleInstances = allowMultipleInstances;
            this.DocumentationUrl = documentationUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerViewServer" /> class.
        /// </summary>
        public MCPServerViewServer()
        {
        }
    }
}