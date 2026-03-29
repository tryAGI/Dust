
#nullable enable

namespace Dust
{
    /// <summary>
    /// Direction of the thumb feedback
    /// </summary>
    public enum CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection
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
    public static class CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection value)
        {
            return value switch
            {
                CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection.Down => "down",
                CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection? ToEnum(string value)
        {
            return value switch
            {
                "down" => CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection.Down,
                "up" => CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection.Up,
                _ => null,
            };
        }
    }
}