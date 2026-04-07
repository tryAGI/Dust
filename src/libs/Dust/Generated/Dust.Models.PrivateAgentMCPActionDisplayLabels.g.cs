
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateAgentMCPActionDisplayLabels
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running")]
        public string? Running { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        public string? Done { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentMCPActionDisplayLabels" /> class.
        /// </summary>
        /// <param name="running"></param>
        /// <param name="done"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateAgentMCPActionDisplayLabels(
            string? running,
            string? done)
        {
            this.Running = running;
            this.Done = done;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateAgentMCPActionDisplayLabels" /> class.
        /// </summary>
        public PrivateAgentMCPActionDisplayLabels()
        {
        }
    }
}