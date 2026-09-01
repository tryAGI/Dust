
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateFrameFunctionInvocationRequest
    {
        /// <summary>
        /// Input validated against the published function contract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Dust.PrivateFrameFunctionInvocationRequestContext? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFrameFunctionInvocationRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Input validated against the published function contract.
        /// </param>
        /// <param name="context"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateFrameFunctionInvocationRequest(
            object? input,
            global::Dust.PrivateFrameFunctionInvocationRequestContext? context)
        {
            this.Input = input;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFrameFunctionInvocationRequest" /> class.
        /// </summary>
        public PrivateFrameFunctionInvocationRequest()
        {
        }

    }
}