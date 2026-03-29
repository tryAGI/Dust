
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWFilesAction
    {
        /// <summary>
        /// 
        /// </summary>
        Download,
        /// <summary>
        /// 
        /// </summary>
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWFilesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWFilesAction value)
        {
            return value switch
            {
                GetWFilesAction.Download => "download",
                GetWFilesAction.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWFilesAction? ToEnum(string value)
        {
            return value switch
            {
                "download" => GetWFilesAction.Download,
                "view" => GetWFilesAction.View,
                _ => null,
            };
        }
    }
}