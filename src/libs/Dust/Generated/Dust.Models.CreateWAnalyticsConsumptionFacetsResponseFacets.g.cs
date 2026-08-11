
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAnalyticsConsumptionFacetsResponseFacets
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> Team { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> Tool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> Skill { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionFacetsResponseFacets" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="user"></param>
        /// <param name="team"></param>
        /// <param name="model"></param>
        /// <param name="tool"></param>
        /// <param name="skill"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAnalyticsConsumptionFacetsResponseFacets(
            global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> agent,
            global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> user,
            global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> team,
            global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> model,
            global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> tool,
            global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> skill,
            global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet> source)
        {
            this.Agent = agent ?? throw new global::System.ArgumentNullException(nameof(agent));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Skill = skill ?? throw new global::System.ArgumentNullException(nameof(skill));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAnalyticsConsumptionFacetsResponseFacets" /> class.
        /// </summary>
        public CreateWAnalyticsConsumptionFacetsResponseFacets()
        {
        }

    }
}