
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum TriggerExecutionMode
    {
        /// <summary>
        ///
        /// </summary>
        UserPool,
        /// <summary>
        ///
        /// </summary>
        WorkspacePool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerExecutionMode value)
        {
            return value switch
            {
                TriggerExecutionMode.UserPool => "user_pool",
                TriggerExecutionMode.WorkspacePool => "workspace_pool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "user_pool" => TriggerExecutionMode.UserPool,
                "workspace_pool" => TriggerExecutionMode.WorkspacePool,
                _ => null,
            };
        }
    }
}