
#nullable enable

namespace Dust
{
    /// <summary>
    /// Present when the view was fetched with usage details (withDetails query param). Counts agents and skills that use this data source view.
    /// </summary>
    public sealed partial class PrivateDataSourceViewUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceViewUsageAgent>? Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceViewUsageSkill>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateDataSourceViewUsage" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="agents"></param>
        /// <param name="skills"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateDataSourceViewUsage(
            int? count,
            global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceViewUsageAgent>? agents,
            global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceViewUsageSkill>? skills)
        {
            this.Count = count;
            this.Agents = agents;
            this.Skills = skills;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateDataSourceViewUsage" /> class.
        /// </summary>
        public PrivateDataSourceViewUsage()
        {
        }

    }
}