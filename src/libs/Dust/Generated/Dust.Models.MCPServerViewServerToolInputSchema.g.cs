
#nullable enable

namespace Dust
{
    /// <summary>
    /// JSON Schema for the tool's input parameters<br/>
    /// Example: {"type":"object","properties":{"customerId":{"type":"string"}}}
    /// </summary>
    public sealed partial class MCPServerViewServerToolInputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}