
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Space
    {
        /// <summary>
        /// Unique string identifier for the space
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Name of the space
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The kind of the space
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.SpaceKindJsonConverter))]
        public global::Dust.SpaceKind? Kind { get; set; }

        /// <summary>
        /// List of group IDs that have access to the space
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupIds")]
        public global::System.Collections.Generic.IList<string>? GroupIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Space" /> class.
        /// </summary>
        /// <param name="sId">
        /// Unique string identifier for the space
        /// </param>
        /// <param name="name">
        /// Name of the space
        /// </param>
        /// <param name="kind">
        /// The kind of the space
        /// </param>
        /// <param name="groupIds">
        /// List of group IDs that have access to the space
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Space(
            string? sId,
            string? name,
            global::Dust.SpaceKind? kind,
            global::System.Collections.Generic.IList<string>? groupIds)
        {
            this.SId = sId;
            this.Name = name;
            this.Kind = kind;
            this.GroupIds = groupIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Space" /> class.
        /// </summary>
        public Space()
        {
        }
    }
}