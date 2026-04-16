
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceJsonConverter))]
        public global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference? Preference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="spaceId"></param>
        /// <param name="userId"></param>
        /// <param name="preference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference(
            string? sId,
            string? spaceId,
            string? userId,
            global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference? preference)
        {
            this.SId = sId;
            this.SpaceId = spaceId;
            this.UserId = userId;
            this.Preference = preference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference" /> class.
        /// </summary>
        public PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference()
        {
        }
    }
}