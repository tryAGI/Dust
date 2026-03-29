
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateToolNotificationEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolNotification,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateToolNotificationEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateToolNotificationEventType value)
        {
            return value switch
            {
                PrivateToolNotificationEventType.ToolNotification => "tool_notification",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateToolNotificationEventType? ToEnum(string value)
        {
            return value switch
            {
                "tool_notification" => PrivateToolNotificationEventType.ToolNotification,
                _ => null,
            };
        }
    }
}