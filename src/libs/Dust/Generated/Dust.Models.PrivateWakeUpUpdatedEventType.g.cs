
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateWakeUpUpdatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        WakeUpUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateWakeUpUpdatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateWakeUpUpdatedEventType value)
        {
            return value switch
            {
                PrivateWakeUpUpdatedEventType.WakeUpUpdated => "wake_up_updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateWakeUpUpdatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "wake_up_updated" => PrivateWakeUpUpdatedEventType.WakeUpUpdated,
                _ => null,
            };
        }
    }
}