
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantConversationsMentionsSuggestionsSelectItem
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
    public static class GetWAssistantConversationsMentionsSuggestionsSelectItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantConversationsMentionsSuggestionsSelectItem value)
        {
            return value switch
            {
                GetWAssistantConversationsMentionsSuggestionsSelectItem.Agents => "agents",
                GetWAssistantConversationsMentionsSuggestionsSelectItem.Users => "users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantConversationsMentionsSuggestionsSelectItem? ToEnum(string value)
        {
            return value switch
            {
                "agents" => GetWAssistantConversationsMentionsSuggestionsSelectItem.Agents,
                "users" => GetWAssistantConversationsMentionsSuggestionsSelectItem.Users,
                _ => null,
            };
        }
    }
}