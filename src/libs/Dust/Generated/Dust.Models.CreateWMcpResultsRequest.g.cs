
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWMcpResultsRequest
    {
        /// <summary>
        /// The result data from the tool execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Result { get; set; }

        /// <summary>
        /// ID of the MCP server submitting the results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWMcpResultsRequest" /> class.
        /// </summary>
        /// <param name="result">
        /// The result data from the tool execution
        /// </param>
        /// <param name="serverId">
        /// ID of the MCP server submitting the results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWMcpResultsRequest(
            object result,
            string serverId)
        {
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.ServerId = serverId ?? throw new global::System.ArgumentNullException(nameof(serverId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWMcpResultsRequest" /> class.
        /// </summary>
        public CreateWMcpResultsRequest()
        {
        }
    }
}