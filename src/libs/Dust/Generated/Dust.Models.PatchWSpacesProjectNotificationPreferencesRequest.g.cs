
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWSpacesProjectNotificationPreferencesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PatchWSpacesProjectNotificationPreferencesRequestPreferenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PatchWSpacesProjectNotificationPreferencesRequestPreference Preference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesProjectNotificationPreferencesRequest" /> class.
        /// </summary>
        /// <param name="preference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWSpacesProjectNotificationPreferencesRequest(
            global::Dust.PatchWSpacesProjectNotificationPreferencesRequestPreference preference)
        {
            this.Preference = preference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWSpacesProjectNotificationPreferencesRequest" /> class.
        /// </summary>
        public PatchWSpacesProjectNotificationPreferencesRequest()
        {
        }
    }
}