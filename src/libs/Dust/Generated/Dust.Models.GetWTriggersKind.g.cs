
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum GetWTriggersKind
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
    public static class GetWTriggersKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWTriggersKind value)
        {
            return value switch
            {
                GetWTriggersKind.Schedule => "schedule",
                GetWTriggersKind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWTriggersKind? ToEnum(string value)
        {
            return value switch
            {
                "schedule" => GetWTriggersKind.Schedule,
                "webhook" => GetWTriggersKind.Webhook,
                _ => null,
            };
        }
    }
}