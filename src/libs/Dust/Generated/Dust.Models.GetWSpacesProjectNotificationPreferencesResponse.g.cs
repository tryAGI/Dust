
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesProjectNotificationPreferencesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userProjectNotificationPreference")]
        public global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference? UserProjectNotificationPreference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesProjectNotificationPreferencesResponse" /> class.
        /// </summary>
        /// <param name="userProjectNotificationPreference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesProjectNotificationPreferencesResponse(
            global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference? userProjectNotificationPreference)
        {
            this.UserProjectNotificationPreference = userProjectNotificationPreference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesProjectNotificationPreferencesResponse" /> class.
        /// </summary>
        public GetWSpacesProjectNotificationPreferencesResponse()
        {
        }
    }
}