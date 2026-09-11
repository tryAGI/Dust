
#nullable enable

namespace Dust
{
    /// <summary>
    /// Optional dimension filters. Each key maps to an array of string identifiers to include.<br/>
    /// Each value must be at most 256 characters. The total number of values across all dimensions must not exceed 500.
    /// </summary>
    public sealed partial class CreateWAnalyticsConsumptionExportRequestFilter
    {
        /// <summary>
        /// Agent sIds to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<string>? Agents { get; set; }

        /// <summary>
        /// User IDs to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        /// API key names to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        public global::System.Collections.Generic.IList<string>? ApiKeys { get; set; }

        /// <summary>
        /// Group IDs to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<string>? Groups { get; set; }

        /// <summary>
        /// Model IDs to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Tool server names to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<string>? Tools { get; set; }

        /// <summary>
        /// Skill IDs to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<string>? Skills { get; set; }

        /// <summary>
        /// Context origins to filter on (e.g. "web", "slack", "api")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<string>? Sources { get; set; }

        /// <summary>
        /// Agent tag IDs to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionExportRequestFilter" /> class.
        /// </summary>
        /// <param name="agents">
        /// Agent sIds to filter on
        /// </param>
        /// <param name="users">
        /// User IDs to filter on
        /// </param>
        /// <param name="apiKeys">
        /// API key names to filter on
        /// </param>
        /// <param name="groups">
        /// Group IDs to filter on
        /// </param>
        /// <param name="models">
        /// Model IDs to filter on
        /// </param>
        /// <param name="tools">
        /// Tool server names to filter on
        /// </param>
        /// <param name="skills">
        /// Skill IDs to filter on
        /// </param>
        /// <param name="sources">
        /// Context origins to filter on (e.g. "web", "slack", "api")
        /// </param>
        /// <param name="tags">
        /// Agent tag IDs to filter on
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAnalyticsConsumptionExportRequestFilter(
            global::System.Collections.Generic.IList<string>? agents,
            global::System.Collections.Generic.IList<string>? users,
            global::System.Collections.Generic.IList<string>? apiKeys,
            global::System.Collections.Generic.IList<string>? groups,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<string>? tools,
            global::System.Collections.Generic.IList<string>? skills,
            global::System.Collections.Generic.IList<string>? sources,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Agents = agents;
            this.Users = users;
            this.ApiKeys = apiKeys;
            this.Groups = groups;
            this.Models = models;
            this.Tools = tools;
            this.Skills = skills;
            this.Sources = sources;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionExportRequestFilter" /> class.
        /// </summary>
        public CreateWAnalyticsConsumptionExportRequestFilter()
        {
        }

    }
}