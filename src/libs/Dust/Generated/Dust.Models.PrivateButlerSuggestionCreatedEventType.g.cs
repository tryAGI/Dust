
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateButlerSuggestionCreatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ButlerSuggestionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateButlerSuggestionCreatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateButlerSuggestionCreatedEventType value)
        {
            return value switch
            {
                PrivateButlerSuggestionCreatedEventType.ButlerSuggestionCreated => "butler_suggestion_created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateButlerSuggestionCreatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "butler_suggestion_created" => PrivateButlerSuggestionCreatedEventType.ButlerSuggestionCreated,
                _ => null,
            };
        }
    }
}