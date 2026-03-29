
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateButlerDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ButlerDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateButlerDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateButlerDoneEventType value)
        {
            return value switch
            {
                PrivateButlerDoneEventType.ButlerDone => "butler_done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateButlerDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "butler_done" => PrivateButlerDoneEventType.ButlerDone,
                _ => null,
            };
        }
    }
}