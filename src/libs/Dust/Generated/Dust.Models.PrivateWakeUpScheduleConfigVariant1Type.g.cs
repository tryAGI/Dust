
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateWakeUpScheduleConfigVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        OneShot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateWakeUpScheduleConfigVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateWakeUpScheduleConfigVariant1Type value)
        {
            return value switch
            {
                PrivateWakeUpScheduleConfigVariant1Type.OneShot => "one_shot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateWakeUpScheduleConfigVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "one_shot" => PrivateWakeUpScheduleConfigVariant1Type.OneShot,
                _ => null,
            };
        }
    }
}