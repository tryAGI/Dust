
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2
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
    public static class CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2 value)
        {
            return value switch
            {
                CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2.Down => "down",
                CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2? ToEnum(string value)
        {
            return value switch
            {
                "down" => CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2.Down,
                "up" => CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2.Up,
                _ => null,
            };
        }
    }
}