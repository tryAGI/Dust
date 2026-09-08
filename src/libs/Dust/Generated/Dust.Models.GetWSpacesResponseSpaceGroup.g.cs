
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetWSpacesResponseSpaceGroup
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.GetWSpacesResponseSpaceGroupRoleJsonConverter))]
        public global::Dust.GetWSpacesResponseSpaceGroupRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponseSpaceGroup" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesResponseSpaceGroup(
            string? sId,
            string? name,
            string? kind,
            global::Dust.GetWSpacesResponseSpaceGroupRole? role)
        {
            this.SId = sId;
            this.Name = name;
            this.Kind = kind;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponseSpaceGroup" /> class.
        /// </summary>
        public GetWSpacesResponseSpaceGroup()
        {
        }

    }
}