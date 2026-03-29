
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateConversationTitleEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationTitle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateConversationTitleEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateConversationTitleEventType value)
        {
            return value switch
            {
                PrivateConversationTitleEventType.ConversationTitle => "conversation_title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateConversationTitleEventType? ToEnum(string value)
        {
            return value switch
            {
                "conversation_title" => PrivateConversationTitleEventType.ConversationTitle,
                _ => null,
            };
        }
    }
}