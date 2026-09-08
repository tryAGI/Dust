
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum TriggerStatus
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        DisabledByManager,
        /// <summary>
        ///
        /// </summary>
        Downgraded,
        /// <summary>
        ///
        /// </summary>
        Enabled,
        /// <summary>
        ///
        /// </summary>
        Relocating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerStatus value)
        {
            return value switch
            {
                TriggerStatus.Disabled => "disabled",
                TriggerStatus.DisabledByManager => "disabled_by_manager",
                TriggerStatus.Downgraded => "downgraded",
                TriggerStatus.Enabled => "enabled",
                TriggerStatus.Relocating => "relocating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => TriggerStatus.Disabled,
                "disabled_by_manager" => TriggerStatus.DisabledByManager,
                "downgraded" => TriggerStatus.Downgraded,
                "enabled" => TriggerStatus.Enabled,
                "relocating" => TriggerStatus.Relocating,
                _ => null,
            };
        }
    }
}