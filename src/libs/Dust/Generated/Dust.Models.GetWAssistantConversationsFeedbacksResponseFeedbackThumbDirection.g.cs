
#nullable enable

namespace Dust
{
    /// <summary>
    /// Direction of the thumb feedback
    /// </summary>
    public enum GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Down,
        /// <summary>
        /// 
        /// </summary>
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection value)
        {
            return value switch
            {
                GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection.Down => "down",
                GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection? ToEnum(string value)
        {
            return value switch
            {
                "down" => GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection.Down,
                "up" => GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection.Up,
                _ => null,
            };
        }
    }
}