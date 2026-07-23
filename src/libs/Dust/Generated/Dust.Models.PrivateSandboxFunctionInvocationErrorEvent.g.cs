
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateSandboxFunctionInvocationErrorEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateSandboxFunctionInvocationErrorEventTypeJsonConverter))]
        public global::Dust.PrivateSandboxFunctionInvocationErrorEventType Type { get; set; }

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
        /// A structured error describing why the invocation failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateSandboxFunctionInvocationErrorEventError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateSandboxFunctionInvocationErrorEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="invocationId"></param>
        /// <param name="functionId"></param>
        /// <param name="error">
        /// A structured error describing why the invocation failed.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateSandboxFunctionInvocationErrorEvent(
            int created,
            string invocationId,
            string functionId,
            global::Dust.PrivateSandboxFunctionInvocationErrorEventError error,
            global::Dust.PrivateSandboxFunctionInvocationErrorEventType type)
        {
            this.Type = type;
            this.Created = created;
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.FunctionId = functionId ?? throw new global::System.ArgumentNullException(nameof(functionId));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateSandboxFunctionInvocationErrorEvent" /> class.
        /// </summary>
        public PrivateSandboxFunctionInvocationErrorEvent()
        {
        }

    }
}