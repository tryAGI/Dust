
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateLightAgentMessageVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Visible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateLightAgentMessageVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateLightAgentMessageVisibility value)
        {
            return value switch
            {
                PrivateLightAgentMessageVisibility.Deleted => "deleted",
                PrivateLightAgentMessageVisibility.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateLightAgentMessageVisibility? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => PrivateLightAgentMessageVisibility.Deleted,
                "visible" => PrivateLightAgentMessageVisibility.Visible,
                _ => null,
            };
        }
    }
}