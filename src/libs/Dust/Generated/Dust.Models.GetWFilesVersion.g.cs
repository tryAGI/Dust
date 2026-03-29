
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWFilesVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Original,
        /// <summary>
        /// 
        /// </summary>
        Processed,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWFilesVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWFilesVersion value)
        {
            return value switch
            {
                GetWFilesVersion.Original => "original",
                GetWFilesVersion.Processed => "processed",
                GetWFilesVersion.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWFilesVersion? ToEnum(string value)
        {
            return value switch
            {
                "original" => GetWFilesVersion.Original,
                "processed" => GetWFilesVersion.Processed,
                "public" => GetWFilesVersion.Public,
                _ => null,
            };
        }
    }
}