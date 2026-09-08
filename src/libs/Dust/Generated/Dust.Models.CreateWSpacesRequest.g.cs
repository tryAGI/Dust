
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWSpacesRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isRestricted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRestricted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWSpacesRequestSpaceKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWSpacesRequestSpaceKind SpaceKind { get; set; }

        /// <summary>
        /// The space's manual member list. Omitted or empty means the space starts with no manual member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memberIds")]
        public global::System.Collections.Generic.IList<string>? MemberIds { get; set; }

        /// <summary>
        /// The groups given access to the space. Omitted or empty means no group has access to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupIds")]
        public global::System.Collections.Generic.IList<string>? GroupIds { get; set; }

        /// <summary>
        /// Deprecated and ignored. A space's members are its manual member list plus the members of the groups given access to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managementMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWSpacesRequestManagementModeJsonConverter))]
        public global::Dust.CreateWSpacesRequestManagementMode? ManagementMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesRequest" /> class.
        /// </summary>
        /// <param name="isRestricted"></param>
        /// <param name="name"></param>
        /// <param name="spaceKind"></param>
        /// <param name="memberIds">
        /// The space's manual member list. Omitted or empty means the space starts with no manual member.
        /// </param>
        /// <param name="groupIds">
        /// The groups given access to the space. Omitted or empty means no group has access to it.
        /// </param>
        /// <param name="managementMode">
        /// Deprecated and ignored. A space's members are its manual member list plus the members of the groups given access to it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesRequest(
            bool isRestricted,
            string name,
            global::Dust.CreateWSpacesRequestSpaceKind spaceKind,
            global::System.Collections.Generic.IList<string>? memberIds,
            global::System.Collections.Generic.IList<string>? groupIds,
            global::Dust.CreateWSpacesRequestManagementMode? managementMode)
        {
            this.IsRestricted = isRestricted;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SpaceKind = spaceKind;
            this.MemberIds = memberIds;
            this.GroupIds = groupIds;
            this.ManagementMode = managementMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesRequest" /> class.
        /// </summary>
        public CreateWSpacesRequest()
        {
        }

    }
}