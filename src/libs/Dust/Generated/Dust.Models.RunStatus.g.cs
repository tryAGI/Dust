
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStatus
    {
        /// <summary>
        /// The status of the run<br/>
        /// Example: succeeded
        /// </summary>
        /// <example>succeeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run")]
        public string? Run { get; set; }

        /// <summary>
        /// The status of the build<br/>
        /// Example: succeeded
        /// </summary>
        /// <example>succeeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public string? Build { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatus" /> class.
        /// </summary>
        /// <param name="run">
        /// The status of the run<br/>
        /// Example: succeeded
        /// </param>
        /// <param name="build">
        /// The status of the build<br/>
        /// Example: succeeded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStatus(
            string? run,
            string? build)
        {
            this.Run = run;
            this.Build = build;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStatus" /> class.
        /// </summary>
        public RunStatus()
        {
        }
    }
}