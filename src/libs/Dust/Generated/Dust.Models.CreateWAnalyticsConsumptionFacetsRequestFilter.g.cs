
#nullable enable

namespace Dust
{
    /// <summary>
    /// Map of consumption dimensions to selected values.
    /// </summary>
    public sealed partial class CreateWAnalyticsConsumptionFacetsRequestFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<string>? Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<string>? Teams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<string>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<string>? Skills { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<string>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionFacetsRequestFilter" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="users"></param>
        /// <param name="teams"></param>
        /// <param name="models"></param>
        /// <param name="tools"></param>
        /// <param name="skills"></param>
        /// <param name="sources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAnalyticsConsumptionFacetsRequestFilter(
            global::System.Collections.Generic.IList<string>? agents,
            global::System.Collections.Generic.IList<string>? users,
            global::System.Collections.Generic.IList<string>? teams,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<string>? tools,
            global::System.Collections.Generic.IList<string>? skills,
            global::System.Collections.Generic.IList<string>? sources)
        {
            this.Agents = agents;
            this.Users = users;
            this.Teams = teams;
            this.Models = models;
            this.Tools = tools;
            this.Skills = skills;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionFacetsRequestFilter" /> class.
        /// </summary>
        public CreateWAnalyticsConsumptionFacetsRequestFilter()
        {
        }

    }
}