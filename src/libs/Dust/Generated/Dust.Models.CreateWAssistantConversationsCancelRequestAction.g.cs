
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWAssistantConversationsCancelRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Cancel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWAssistantConversationsCancelRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAssistantConversationsCancelRequestAction value)
        {
            return value switch
            {
                CreateWAssistantConversationsCancelRequestAction.Cancel => "cancel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAssistantConversationsCancelRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "cancel" => CreateWAssistantConversationsCancelRequestAction.Cancel,
                _ => null,
            };
        }
    }
}