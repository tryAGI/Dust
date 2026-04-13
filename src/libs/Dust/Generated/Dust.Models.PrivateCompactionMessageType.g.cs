
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateCompactionMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        CompactionMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateCompactionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateCompactionMessageType value)
        {
            return value switch
            {
                PrivateCompactionMessageType.CompactionMessage => "compaction_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateCompactionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "compaction_message" => PrivateCompactionMessageType.CompactionMessage,
                _ => null,
            };
        }
    }
}