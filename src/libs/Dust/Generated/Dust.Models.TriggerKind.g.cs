
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum TriggerKind
    {
        /// <summary>
        ///
        /// </summary>
        Schedule,
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerKind value)
        {
            return value switch
            {
                TriggerKind.Schedule => "schedule",
                TriggerKind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerKind? ToEnum(string value)
        {
            return value switch
            {
                "schedule" => TriggerKind.Schedule,
                "webhook" => TriggerKind.Webhook,
                _ => null,
            };
        }
    }
}