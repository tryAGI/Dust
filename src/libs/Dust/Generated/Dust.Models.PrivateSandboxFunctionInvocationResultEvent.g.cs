
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateSandboxFunctionInvocationResultEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateSandboxFunctionInvocationResultEventTypeJsonConverter))]
        public global::Dust.PrivateSandboxFunctionInvocationResultEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionId { get; set; }

        /// <summary>
        /// Parsed result validated against the sandbox function output schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateSandboxFunctionInvocationResultEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="invocationId"></param>
        /// <param name="functionId"></param>
        /// <param name="result">
        /// Parsed result validated against the sandbox function output schema.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateSandboxFunctionInvocationResultEvent(
            int created,
            string invocationId,
            string functionId,
            object result,
            global::Dust.PrivateSandboxFunctionInvocationResultEventType type)
        {
            this.Type = type;
            this.Created = created;
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.FunctionId = functionId ?? throw new global::System.ArgumentNullException(nameof(functionId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateSandboxFunctionInvocationResultEvent" /> class.
        /// </summary>
        public PrivateSandboxFunctionInvocationResultEvent()
        {
        }

    }
}