
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateCompactionMessageDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        CompactionMessageDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateCompactionMessageDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateCompactionMessageDoneEventType value)
        {
            return value switch
            {
                PrivateCompactionMessageDoneEventType.CompactionMessageDone => "compaction_message_done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateCompactionMessageDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "compaction_message_done" => PrivateCompactionMessageDoneEventType.CompactionMessageDone,
                _ => null,
            };
        }
    }
}