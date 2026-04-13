
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateCompactionMessageVisibility
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
    public static class PrivateCompactionMessageVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateCompactionMessageVisibility value)
        {
            return value switch
            {
                PrivateCompactionMessageVisibility.Deleted => "deleted",
                PrivateCompactionMessageVisibility.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateCompactionMessageVisibility? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => PrivateCompactionMessageVisibility.Deleted,
                "visible" => PrivateCompactionMessageVisibility.Visible,
                _ => null,
            };
        }
    }
}