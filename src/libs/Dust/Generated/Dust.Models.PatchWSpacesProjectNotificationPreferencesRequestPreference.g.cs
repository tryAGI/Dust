
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchWSpacesProjectNotificationPreferencesRequestPreference
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
    public static class PatchWSpacesProjectNotificationPreferencesRequestPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchWSpacesProjectNotificationPreferencesRequestPreference value)
        {
            return value switch
            {
                PatchWSpacesProjectNotificationPreferencesRequestPreference.AllMessages => "all_messages",
                PatchWSpacesProjectNotificationPreferencesRequestPreference.Never => "never",
                PatchWSpacesProjectNotificationPreferencesRequestPreference.OnlyMentions => "only_mentions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchWSpacesProjectNotificationPreferencesRequestPreference? ToEnum(string value)
        {
            return value switch
            {
                "all_messages" => PatchWSpacesProjectNotificationPreferencesRequestPreference.AllMessages,
                "never" => PatchWSpacesProjectNotificationPreferencesRequestPreference.Never,
                "only_mentions" => PatchWSpacesProjectNotificationPreferencesRequestPreference.OnlyMentions,
                _ => null,
            };
        }
    }
}