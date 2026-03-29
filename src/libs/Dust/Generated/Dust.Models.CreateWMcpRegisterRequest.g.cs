
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWMcpRegisterRequest
    {
        /// <summary>
        /// Name of the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWMcpRegisterRequest" /> class.
        /// </summary>
        /// <param name="serverName">
        /// Name of the MCP server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWMcpRegisterRequest(
            string serverName)
        {
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWMcpRegisterRequest" /> class.
        /// </summary>
        public CreateWMcpRegisterRequest()
        {
        }
    }
}