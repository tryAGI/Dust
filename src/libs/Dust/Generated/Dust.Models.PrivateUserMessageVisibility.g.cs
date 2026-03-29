
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateUserMessageVisibility
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
    public static class PrivateUserMessageVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateUserMessageVisibility value)
        {
            return value switch
            {
                PrivateUserMessageVisibility.Deleted => "deleted",
                PrivateUserMessageVisibility.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateUserMessageVisibility? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => PrivateUserMessageVisibility.Deleted,
                "visible" => PrivateUserMessageVisibility.Visible,
                _ => null,
            };
        }
    }
}