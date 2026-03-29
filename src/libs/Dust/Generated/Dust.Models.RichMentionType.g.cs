
#nullable enable

namespace Dust
{
    /// <summary>
    /// Type of the mention<br/>
    /// Example: agent
    /// </summary>
    public enum RichMentionType
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
    public static class RichMentionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichMentionType value)
        {
            return value switch
            {
                RichMentionType.Agent => "agent",
                RichMentionType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichMentionType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => RichMentionType.Agent,
                "user" => RichMentionType.User,
                _ => null,
            };
        }
    }
}