
#nullable enable

namespace Dust
{
    /// <summary>
    /// An MCP action with its output.
    /// </summary>
    public sealed partial class PrivateAgentMCPAction
    {
        /// <summary>
        /// Numeric model identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Unique string identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// Unix timestamp of creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Unix timestamp of last update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// ID of the parent agent message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentMessageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AgentMessageId { get; set; }

        /// <summary>
        /// Name of the internal MCP server, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalMCPServerName")]
        public string? InternalMCPServerName { get; set; }

        /// <summary>
        /// Name of the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// ID of the MCP server, if external
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpServerId")]
        public string? McpServerId { get; set; }

        /// <summary>
        /// Name of the function call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionCallName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionCallName { get; set; }

        /// <summary>
        /// ID of the function call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionCallId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionCallId { get; set; }

        /// <summary>
        /// Parameters passed to the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Params { get; set; }

        /// <summary>
        /// Number of citations allocated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citationsAllocated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CitationsAllocated { get; set; }

        /// <summary>
        /// Execution status of the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateAgentMCPActionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateAgentMCPActionStatus Status { get; set; }

        /// <summary>
        /// Step number in the agent execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Step { get; set; }

        /// <summary>
        /// Duration of execution in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionDurationMs")]
        public int? ExecutionDurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayLabels")]
        public global::Dust.PrivateAgentMCPActionDisplayLabels? DisplayLabels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generatedFiles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateAgentMCPActionGeneratedFile> GeneratedFiles { get; set; }

        /// <summary>
        /// Tool call result content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<object>? Output { get; set; }

        /// <summary>
        /// Map of citation key to citation object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public object? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentMCPAction" /> class.
        /// </summary>
        /// <param name="id">
        /// Numeric model identifier
        /// </param>
        /// <param name="sId">
        /// Unique string identifier
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp of creation
        /// </param>
        /// <param name="updatedAt">
        /// Unix timestamp of last update
        /// </param>
        /// <param name="agentMessageId">
        /// ID of the parent agent message
        /// </param>
        /// <param name="toolName">
        /// Name of the tool
        /// </param>
        /// <param name="functionCallName">
        /// Name of the function call
        /// </param>
        /// <param name="functionCallId">
        /// ID of the function call
        /// </param>
        /// <param name="params">
        /// Parameters passed to the tool
        /// </param>
        /// <param name="citationsAllocated">
        /// Number of citations allocated
        /// </param>
        /// <param name="status">
        /// Execution status of the tool
        /// </param>
        /// <param name="step">
        /// Step number in the agent execution
        /// </param>
        /// <param name="generatedFiles"></param>
        /// <param name="internalMCPServerName">
        /// Name of the internal MCP server, if any
        /// </param>
        /// <param name="mcpServerId">
        /// ID of the MCP server, if external
        /// </param>
        /// <param name="executionDurationMs">
        /// Duration of execution in milliseconds
        /// </param>
        /// <param name="displayLabels"></param>
        /// <param name="output">
        /// Tool call result content
        /// </param>
        /// <param name="citations">
        /// Map of citation key to citation object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateAgentMCPAction(
            int id,
            string sId,
            global::System.DateTimeOffset createdAt,
            global::System.DateTimeOffset updatedAt,
            int agentMessageId,
            string toolName,
            string functionCallName,
            string functionCallId,
            object @params,
            int citationsAllocated,
            global::Dust.PrivateAgentMCPActionStatus status,
            int step,
            global::System.Collections.Generic.IList<global::Dust.PrivateAgentMCPActionGeneratedFile> generatedFiles,
            string? internalMCPServerName,
            string? mcpServerId,
            int? executionDurationMs,
            global::Dust.PrivateAgentMCPActionDisplayLabels? displayLabels,
            global::System.Collections.Generic.IList<object>? output,
            object? citations)
        {
            this.Id = id;
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AgentMessageId = agentMessageId;
            this.InternalMCPServerName = internalMCPServerName;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.McpServerId = mcpServerId;
            this.FunctionCallName = functionCallName ?? throw new global::System.ArgumentNullException(nameof(functionCallName));
            this.FunctionCallId = functionCallId ?? throw new global::System.ArgumentNullException(nameof(functionCallId));
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
            this.CitationsAllocated = citationsAllocated;
            this.Status = status;
            this.Step = step;
            this.ExecutionDurationMs = executionDurationMs;
            this.DisplayLabels = displayLabels;
            this.GeneratedFiles = generatedFiles ?? throw new global::System.ArgumentNullException(nameof(generatedFiles));
            this.Output = output;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentMCPAction" /> class.
        /// </summary>
        public PrivateAgentMCPAction()
        {
        }
    }
}