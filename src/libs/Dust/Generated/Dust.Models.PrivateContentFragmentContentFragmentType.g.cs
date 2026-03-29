
#nullable enable

namespace Dust
{
    /// <summary>
    /// Whether this is a file upload or a content node reference
    /// </summary>
    public enum PrivateContentFragmentContentFragmentType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentNode,
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateContentFragmentContentFragmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateContentFragmentContentFragmentType value)
        {
            return value switch
            {
                PrivateContentFragmentContentFragmentType.ContentNode => "content_node",
                PrivateContentFragmentContentFragmentType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateContentFragmentContentFragmentType? ToEnum(string value)
        {
            return value switch
            {
                "content_node" => PrivateContentFragmentContentFragmentType.ContentNode,
                "file" => PrivateContentFragmentContentFragmentType.File,
                _ => null,
            };
        }
    }
}