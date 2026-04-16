
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWSpacesProjectNotificationPreferencesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userProjectNotificationPreference")]
        public global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference? UserProjectNotificationPreference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesProjectNotificationPreferencesResponse" /> class.
        /// </summary>
        /// <param name="userProjectNotificationPreference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWSpacesProjectNotificationPreferencesResponse(
            global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference? userProjectNotificationPreference)
        {
            this.UserProjectNotificationPreference = userProjectNotificationPreference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesProjectNotificationPreferencesResponse" /> class.
        /// </summary>
        public PatchWSpacesProjectNotificationPreferencesResponse()
        {
        }
    }
}