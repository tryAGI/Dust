
#nullable enable

namespace Dust
{
    /// <summary>
    /// Present only for user mentions
    /// </summary>
    public enum PrivateMentionType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateMentionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateMentionType value)
        {
            return value switch
            {
                PrivateMentionType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateMentionType? ToEnum(string value)
        {
            return value switch
            {
                "user" => PrivateMentionType.User,
                _ => null,
            };
        }
    }
}