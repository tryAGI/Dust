
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceId")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceJsonConverter))]
        public global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference? Preference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="spaceId"></param>
        /// <param name="userId"></param>
        /// <param name="preference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference(
            string? sId,
            string? spaceId,
            string? userId,
            global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference? preference)
        {
            this.SId = sId;
            this.SpaceId = spaceId;
            this.UserId = userId;
            this.Preference = preference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference" /> class.
        /// </summary>
        public GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference()
        {
        }
    }
}