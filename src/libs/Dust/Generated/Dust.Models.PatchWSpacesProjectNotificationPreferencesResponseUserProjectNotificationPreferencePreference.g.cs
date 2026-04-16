
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference
    {
        /// <summary>
        /// 
        /// </summary>
        AllMessages,
        /// <summary>
        /// 
        /// </summary>
        Never,
        /// <summary>
        /// 
        /// </summary>
        OnlyMentions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference value)
        {
            return value switch
            {
                PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.AllMessages => "all_messages",
                PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.Never => "never",
                PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.OnlyMentions => "only_mentions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference? ToEnum(string value)
        {
            return value switch
            {
                "all_messages" => PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.AllMessages,
                "never" => PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.Never,
                "only_mentions" => PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.OnlyMentions,
                _ => null,
            };
        }
    }
}