
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateRichMentionWithStatusType
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
    public static class PrivateRichMentionWithStatusTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateRichMentionWithStatusType value)
        {
            return value switch
            {
                PrivateRichMentionWithStatusType.Agent => "agent",
                PrivateRichMentionWithStatusType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateRichMentionWithStatusType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => PrivateRichMentionWithStatusType.Agent,
                "user" => PrivateRichMentionWithStatusType.User,
                _ => null,
            };
        }
    }
}