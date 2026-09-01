
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateFrameFunctionInvocationResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateSandboxFunctionInvocation Invocation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1, global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant2>))]
        public global::Dust.OneOf<global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1, global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant2>? Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFrameFunctionInvocationResponse" /> class.
        /// </summary>
        /// <param name="invocation"></param>
        /// <param name="outcome"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateFrameFunctionInvocationResponse(
            global::Dust.PrivateSandboxFunctionInvocation invocation,
            global::Dust.OneOf<global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1, global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant2>? outcome)
        {
            this.Invocation = invocation ?? throw new global::System.ArgumentNullException(nameof(invocation));
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFrameFunctionInvocationResponse" /> class.
        /// </summary>
        public PrivateFrameFunctionInvocationResponse()
        {
        }

    }
}