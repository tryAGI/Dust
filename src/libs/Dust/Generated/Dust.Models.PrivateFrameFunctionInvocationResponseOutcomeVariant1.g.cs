
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateFrameFunctionInvocationResponseOutcomeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateFrameFunctionInvocationResponseOutcomeVariant1StatusJsonConverter))]
        public global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1Status Status { get; set; }

        /// <summary>
        /// Parsed result validated against the function output schema.
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
        /// Initializes a new instance of the <see cref="PrivateFrameFunctionInvocationResponseOutcomeVariant1" /> class.
        /// </summary>
        /// <param name="result">
        /// Parsed result validated against the function output schema.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateFrameFunctionInvocationResponseOutcomeVariant1(
            object result,
            global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1Status status)
        {
            this.Status = status;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFrameFunctionInvocationResponseOutcomeVariant1" /> class.
        /// </summary>
        public PrivateFrameFunctionInvocationResponseOutcomeVariant1()
        {
        }

    }
}