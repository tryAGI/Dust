
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateContentFragmentVisibility
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
    public static class PrivateContentFragmentVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateContentFragmentVisibility value)
        {
            return value switch
            {
                PrivateContentFragmentVisibility.Deleted => "deleted",
                PrivateContentFragmentVisibility.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateContentFragmentVisibility? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => PrivateContentFragmentVisibility.Deleted,
                "visible" => PrivateContentFragmentVisibility.Visible,
                _ => null,
            };
        }
    }
}