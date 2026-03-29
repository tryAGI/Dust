
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantMentionsSuggestionsSelect
    {
        /// <summary>
        /// 
        /// </summary>
        Agents,
        /// <summary>
        /// 
        /// </summary>
        Users,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAssistantMentionsSuggestionsSelectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantMentionsSuggestionsSelect value)
        {
            return value switch
            {
                GetWAssistantMentionsSuggestionsSelect.Agents => "agents",
                GetWAssistantMentionsSuggestionsSelect.Users => "users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantMentionsSuggestionsSelect? ToEnum(string value)
        {
            return value switch
            {
                "agents" => GetWAssistantMentionsSuggestionsSelect.Agents,
                "users" => GetWAssistantMentionsSuggestionsSelect.Users,
                _ => null,
            };
        }
    }
}