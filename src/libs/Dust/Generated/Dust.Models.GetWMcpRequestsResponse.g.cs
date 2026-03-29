
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWMcpRequestsResponse
    {
        /// <summary>
        /// Type of the event (e.g. "tool_request")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The tool request data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWMcpRequestsResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the event (e.g. "tool_request")
        /// </param>
        /// <param name="data">
        /// The tool request data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWMcpRequestsResponse(
            string? type,
            object? data)
        {
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWMcpRequestsResponse" /> class.
        /// </summary>
        public GetWMcpRequestsResponse()
        {
        }
    }
}