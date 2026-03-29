
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateMentionSuggestionType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateMentionSuggestionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateMentionSuggestionType value)
        {
            return value switch
            {
                PrivateMentionSuggestionType.Agent => "agent",
                PrivateMentionSuggestionType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateMentionSuggestionType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => PrivateMentionSuggestionType.Agent,
                "user" => PrivateMentionSuggestionType.User,
                _ => null,
            };
        }
    }
}