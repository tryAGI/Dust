
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWAssistantConversationsSelectedSpacesRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWAssistantConversationsSelectedSpacesRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAssistantConversationsSelectedSpacesRequestMode value)
        {
            return value switch
            {
                CreateWAssistantConversationsSelectedSpacesRequestMode.Add => "add",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAssistantConversationsSelectedSpacesRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "add" => CreateWAssistantConversationsSelectedSpacesRequestMode.Add,
                _ => null,
            };
        }
    }
}