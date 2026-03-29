
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWMcpHeartbeatRequest
    {
        /// <summary>
        /// The ID of the registered MCP server
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
        /// Initializes a new instance of the <see cref="CreateWMcpHeartbeatRequest" /> class.
        /// </summary>
        /// <param name="serverId">
        /// The ID of the registered MCP server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWMcpHeartbeatRequest(
            string serverId)
        {
            this.ServerId = serverId ?? throw new global::System.ArgumentNullException(nameof(serverId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWMcpHeartbeatRequest" /> class.
        /// </summary>
        public CreateWMcpHeartbeatRequest()
        {
        }
    }
}