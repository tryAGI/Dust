
#nullable enable

namespace Dust
{
    /// <summary>
    /// A structured error describing why the invocation failed.
    /// </summary>
    public sealed partial class PrivateSandboxFunctionInvocationErrorEventError
    {
        /// <summary>
        /// Whatever classified the failure, forwarded as-is (a runner code such as `threw` or `http_error`, or the `type` of the API error that failed the call). Open by design, branch on the codes you handle and treat the rest as generic failures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

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
        /// <param name="code">
        /// Whatever classified the failure, forwarded as-is (a runner code such as `threw` or `http_error`, or the `type` of the API error that failed the call). Open by design, branch on the codes you handle and treat the rest as generic failures.
        /// </param>
        /// <param name="message"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateSandboxFunctionInvocationErrorEventError(
            string code,
            string message,
            int? status)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
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