
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantMentionsSuggestionsCurrent
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAssistantMentionsSuggestionsCurrentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantMentionsSuggestionsCurrent value)
        {
            return value switch
            {
                GetWAssistantMentionsSuggestionsCurrent.False => "false",
                GetWAssistantMentionsSuggestionsCurrent.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantMentionsSuggestionsCurrent? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetWAssistantMentionsSuggestionsCurrent.False,
                "true" => GetWAssistantMentionsSuggestionsCurrent.True,
                _ => null,
            };
        }
    }
}