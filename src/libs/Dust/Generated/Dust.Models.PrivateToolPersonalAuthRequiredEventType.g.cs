
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateToolPersonalAuthRequiredEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolPersonalAuthRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateToolPersonalAuthRequiredEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateToolPersonalAuthRequiredEventType value)
        {
            return value switch
            {
                PrivateToolPersonalAuthRequiredEventType.ToolPersonalAuthRequired => "tool_personal_auth_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateToolPersonalAuthRequiredEventType? ToEnum(string value)
        {
            return value switch
            {
                "tool_personal_auth_required" => PrivateToolPersonalAuthRequiredEventType.ToolPersonalAuthRequired,
                _ => null,
            };
        }
    }
}