
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunTraceItem
    {
        /// <summary>
        /// The timestamp of the trace<br/>
        /// Example: 1234567890
        /// </summary>
        /// <example>1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// The trace<br/>
        /// Example: {}
        /// </summary>
        /// <example>{}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public object? Trace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunTraceItem" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp of the trace<br/>
        /// Example: 1234567890
        /// </param>
        /// <param name="trace">
        /// The trace<br/>
        /// Example: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunTraceItem(
            double? timestamp,
            object? trace)
        {
            this.Timestamp = timestamp;
            this.Trace = trace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunTraceItem" /> class.
        /// </summary>
        public RunTraceItem()
        {
        }
    }
}