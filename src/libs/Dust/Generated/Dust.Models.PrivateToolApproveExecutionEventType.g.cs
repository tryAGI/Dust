
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateToolApproveExecutionEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolApproveExecution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateToolApproveExecutionEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateToolApproveExecutionEventType value)
        {
            return value switch
            {
                PrivateToolApproveExecutionEventType.ToolApproveExecution => "tool_approve_execution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateToolApproveExecutionEventType? ToEnum(string value)
        {
            return value switch
            {
                "tool_approve_execution" => PrivateToolApproveExecutionEventType.ToolApproveExecution,
                _ => null,
            };
        }
    }
}