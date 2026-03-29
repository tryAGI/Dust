
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateContentFragmentType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFragment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateContentFragmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateContentFragmentType value)
        {
            return value switch
            {
                PrivateContentFragmentType.ContentFragment => "content_fragment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateContentFragmentType? ToEnum(string value)
        {
            return value switch
            {
                "content_fragment" => PrivateContentFragmentType.ContentFragment,
                _ => null,
            };
        }
    }
}