
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateFrameFunctionInvocationRequestContext
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFrameFunctionInvocationRequestContext" /> class.
        /// </summary>
        /// <param name="timezone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateFrameFunctionInvocationRequestContext(
            string? timezone)
        {
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateFrameFunctionInvocationRequestContext" /> class.
        /// </summary>
        public PrivateFrameFunctionInvocationRequestContext()
        {
        }

    }
}