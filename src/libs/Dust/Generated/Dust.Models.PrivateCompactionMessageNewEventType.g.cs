
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateCompactionMessageNewEventType
    {
        /// <summary>
        /// 
        /// </summary>
        CompactionMessageNew,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateCompactionMessageNewEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateCompactionMessageNewEventType value)
        {
            return value switch
            {
                PrivateCompactionMessageNewEventType.CompactionMessageNew => "compaction_message_new",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateCompactionMessageNewEventType? ToEnum(string value)
        {
            return value switch
            {
                "compaction_message_new" => PrivateCompactionMessageNewEventType.CompactionMessageNew,
                _ => null,
            };
        }
    }
}