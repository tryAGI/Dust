
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateToolFileAuthRequiredEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolFileAuthRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateToolFileAuthRequiredEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateToolFileAuthRequiredEventType value)
        {
            return value switch
            {
                PrivateToolFileAuthRequiredEventType.ToolFileAuthRequired => "tool_file_auth_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateToolFileAuthRequiredEventType? ToEnum(string value)
        {
            return value switch
            {
                "tool_file_auth_required" => PrivateToolFileAuthRequiredEventType.ToolFileAuthRequired,
                _ => null,
            };
        }
    }
}