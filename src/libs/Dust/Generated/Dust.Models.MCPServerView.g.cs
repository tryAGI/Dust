
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPServerView
    {
        /// <summary>
        /// Unique identifier for the MCP server view<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Unique string identifier for the MCP server view<br/>
        /// Example: mcp_sv_abc123
        /// </summary>
        /// <example>mcp_sv_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Custom name for the MCP server view (null if not set)<br/>
        /// Example: My Custom MCP Server
        /// </summary>
        /// <example>My Custom MCP Server</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Custom description for the MCP server view (null if not set)<br/>
        /// Example: This MCP server handles customer data operations
        /// </summary>
        /// <example>This MCP server handles customer data operations</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Unix timestamp of when the MCP server view was created<br/>
        /// Example: 1625097600
        /// </summary>
        /// <example>1625097600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// Unix timestamp of when the MCP server view was last updated<br/>
        /// Example: 1625184000
        /// </summary>
        /// <example>1625184000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// ID of the space containing the MCP server view<br/>
        /// Example: spc_xyz789
        /// </summary>
        /// <example>spc_xyz789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceId")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// Type of the MCP server<br/>
        /// Example: remote
        /// </summary>
        /// <example>remote</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.MCPServerViewServerTypeJsonConverter))]
        public global::Dust.MCPServerViewServerType? ServerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::Dust.MCPServerViewServer? Server { get; set; }

        /// <summary>
        /// OAuth use case for the MCP server view<br/>
        /// Example: platform_actions
        /// </summary>
        /// <example>platform_actions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("oAuthUseCase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.MCPServerViewOAuthUseCaseJsonConverter))]
        public global::Dust.MCPServerViewOAuthUseCase? OAuthUseCase { get; set; }

        /// <summary>
        /// Information about the user who last edited the MCP server view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editedByUser")]
        public global::Dust.MCPServerViewEditedByUser? EditedByUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerView" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the MCP server view<br/>
        /// Example: 123
        /// </param>
        /// <param name="sId">
        /// Unique string identifier for the MCP server view<br/>
        /// Example: mcp_sv_abc123
        /// </param>
        /// <param name="name">
        /// Custom name for the MCP server view (null if not set)<br/>
        /// Example: My Custom MCP Server
        /// </param>
        /// <param name="description">
        /// Custom description for the MCP server view (null if not set)<br/>
        /// Example: This MCP server handles customer data operations
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp of when the MCP server view was created<br/>
        /// Example: 1625097600
        /// </param>
        /// <param name="updatedAt">
        /// Unix timestamp of when the MCP server view was last updated<br/>
        /// Example: 1625184000
        /// </param>
        /// <param name="spaceId">
        /// ID of the space containing the MCP server view<br/>
        /// Example: spc_xyz789
        /// </param>
        /// <param name="serverType">
        /// Type of the MCP server<br/>
        /// Example: remote
        /// </param>
        /// <param name="server"></param>
        /// <param name="oAuthUseCase">
        /// OAuth use case for the MCP server view<br/>
        /// Example: platform_actions
        /// </param>
        /// <param name="editedByUser">
        /// Information about the user who last edited the MCP server view
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerView(
            int? id,
            string? sId,
            string? name,
            string? description,
            double? createdAt,
            double? updatedAt,
            string? spaceId,
            global::Dust.MCPServerViewServerType? serverType,
            global::Dust.MCPServerViewServer? server,
            global::Dust.MCPServerViewOAuthUseCase? oAuthUseCase,
            global::Dust.MCPServerViewEditedByUser? editedByUser)
        {
            this.Id = id;
            this.SId = sId;
            this.Name = name;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.SpaceId = spaceId;
            this.ServerType = serverType;
            this.Server = server;
            this.OAuthUseCase = oAuthUseCase;
            this.EditedByUser = editedByUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerView" /> class.
        /// </summary>
        public MCPServerView()
        {
        }
    }
}