
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managementMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWSpacesRequestManagementModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.CreateWSpacesRequestManagementMode ManagementMode { get; set; }

        /// <summary>
        /// Required when managementMode is manual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memberIds")]
        public global::System.Collections.Generic.IList<string>? MemberIds { get; set; }

        /// <summary>
        /// Required when managementMode is group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupIds")]
        public global::System.Collections.Generic.IList<string>? GroupIds { get; set; }

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
        /// <param name="managementMode"></param>
        /// <param name="memberIds">
        /// Required when managementMode is manual
        /// </param>
        /// <param name="groupIds">
        /// Required when managementMode is group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWSpacesRequest(
            bool isRestricted,
            string name,
            global::Dust.CreateWSpacesRequestSpaceKind spaceKind,
            global::Dust.CreateWSpacesRequestManagementMode managementMode,
            global::System.Collections.Generic.IList<string>? memberIds,
            global::System.Collections.Generic.IList<string>? groupIds)
        {
            this.IsRestricted = isRestricted;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SpaceKind = spaceKind;
            this.ManagementMode = managementMode;
            this.MemberIds = memberIds;
            this.GroupIds = groupIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWSpacesRequest" /> class.
        /// </summary>
        public CreateWSpacesRequest()
        {
        }
    }
}