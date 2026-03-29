
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantMentionsSuggestionsSelectItem
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
    public static class GetWAssistantMentionsSuggestionsSelectItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantMentionsSuggestionsSelectItem value)
        {
            return value switch
            {
                GetWAssistantMentionsSuggestionsSelectItem.Agents => "agents",
                GetWAssistantMentionsSuggestionsSelectItem.Users => "users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantMentionsSuggestionsSelectItem? ToEnum(string value)
        {
            return value switch
            {
                "agents" => GetWAssistantMentionsSuggestionsSelectItem.Agents,
                "users" => GetWAssistantMentionsSuggestionsSelectItem.Users,
                _ => null,
            };
        }
    }
}