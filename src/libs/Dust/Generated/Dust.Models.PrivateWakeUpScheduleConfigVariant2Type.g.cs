
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateWakeUpScheduleConfigVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Cron,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateWakeUpScheduleConfigVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateWakeUpScheduleConfigVariant2Type value)
        {
            return value switch
            {
                PrivateWakeUpScheduleConfigVariant2Type.Cron => "cron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateWakeUpScheduleConfigVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => PrivateWakeUpScheduleConfigVariant2Type.Cron,
                _ => null,
            };
        }
    }
}