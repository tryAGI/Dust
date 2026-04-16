
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference
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
    public static class GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference value)
        {
            return value switch
            {
                GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.AllMessages => "all_messages",
                GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.Never => "never",
                GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.OnlyMentions => "only_mentions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference? ToEnum(string value)
        {
            return value switch
            {
                "all_messages" => GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.AllMessages,
                "never" => GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.Never,
                "only_mentions" => GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference.OnlyMentions,
                _ => null,
            };
        }
    }
}