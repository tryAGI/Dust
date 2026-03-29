
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateUserMessageNewEventType
    {
        /// <summary>
        /// 
        /// </summary>
        UserMessageNew,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateUserMessageNewEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateUserMessageNewEventType value)
        {
            return value switch
            {
                PrivateUserMessageNewEventType.UserMessageNew => "user_message_new",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateUserMessageNewEventType? ToEnum(string value)
        {
            return value switch
            {
                "user_message_new" => PrivateUserMessageNewEventType.UserMessageNew,
                _ => null,
            };
        }
    }
}