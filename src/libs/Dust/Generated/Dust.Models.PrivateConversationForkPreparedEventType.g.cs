
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateConversationForkPreparedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationForkPrepared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateConversationForkPreparedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateConversationForkPreparedEventType value)
        {
            return value switch
            {
                PrivateConversationForkPreparedEventType.ConversationForkPrepared => "conversation_fork_prepared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateConversationForkPreparedEventType? ToEnum(string value)
        {
            return value switch
            {
                "conversation_fork_prepared" => PrivateConversationForkPreparedEventType.ConversationForkPrepared,
                _ => null,
            };
        }
    }
}