
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPServerViewServerTool
    {
        /// <summary>
        /// Name of the tool<br/>
        /// Example: query_customers
        /// </summary>
        /// <example>query_customers</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of what the tool does<br/>
        /// Example: Query customer database for information
        /// </summary>
        /// <example>Query customer database for information</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// JSON Schema for the tool's input parameters<br/>
        /// Example: {"type":"object","properties":{"customerId":{"type":"string"}}}
        /// </summary>
        /// <example>{"type":"object","properties":{"customerId":{"type":"string"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSchema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerViewServerTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool<br/>
        /// Example: query_customers
        /// </param>
        /// <param name="description">
        /// Description of what the tool does<br/>
        /// Example: Query customer database for information
        /// </param>
        /// <param name="inputSchema">
        /// JSON Schema for the tool's input parameters<br/>
        /// Example: {"type":"object","properties":{"customerId":{"type":"string"}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPServerViewServerTool(
            string? name,
            string? description,
            object? inputSchema)
        {
            this.Name = name;
            this.Description = description;
            this.InputSchema = inputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerViewServerTool" /> class.
        /// </summary>
        public MCPServerViewServerTool()
        {
        }
    }
}