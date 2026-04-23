
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateWakeUpStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Fired,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateWakeUpStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateWakeUpStatus value)
        {
            return value switch
            {
                PrivateWakeUpStatus.Cancelled => "cancelled",
                PrivateWakeUpStatus.Expired => "expired",
                PrivateWakeUpStatus.Fired => "fired",
                PrivateWakeUpStatus.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateWakeUpStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => PrivateWakeUpStatus.Cancelled,
                "expired" => PrivateWakeUpStatus.Expired,
                "fired" => PrivateWakeUpStatus.Fired,
                "scheduled" => PrivateWakeUpStatus.Scheduled,
                _ => null,
            };
        }
    }
}