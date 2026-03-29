
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateAgentMessageVisibility
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
    public static class PrivateAgentMessageVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateAgentMessageVisibility value)
        {
            return value switch
            {
                PrivateAgentMessageVisibility.Deleted => "deleted",
                PrivateAgentMessageVisibility.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateAgentMessageVisibility? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => PrivateAgentMessageVisibility.Deleted,
                "visible" => PrivateAgentMessageVisibility.Visible,
                _ => null,
            };
        }
    }
}