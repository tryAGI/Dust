
#nullable enable

namespace Dust
{
    /// <summary>
    /// A structured error describing why the invocation failed.
    /// </summary>
    public sealed partial class PrivateSandboxFunctionInvocationErrorEventError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateSandboxFunctionInvocationErrorEventErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateSandboxFunctionInvocationErrorEventErrorCode Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateSandboxFunctionInvocationErrorEventError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateSandboxFunctionInvocationErrorEventError(
            global::Dust.PrivateSandboxFunctionInvocationErrorEventErrorCode code,
            string message,
            int? status)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateSandboxFunctionInvocationErrorEventError" /> class.
        /// </summary>
        public PrivateSandboxFunctionInvocationErrorEventError()
        {
        }

    }
}