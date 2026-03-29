
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateDataSourceViewCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        Folder,
        /// <summary>
        /// 
        /// </summary>
        Managed,
        /// <summary>
        /// 
        /// </summary>
        Website,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateDataSourceViewCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateDataSourceViewCategory value)
        {
            return value switch
            {
                PrivateDataSourceViewCategory.Apps => "apps",
                PrivateDataSourceViewCategory.Folder => "folder",
                PrivateDataSourceViewCategory.Managed => "managed",
                PrivateDataSourceViewCategory.Website => "website",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateDataSourceViewCategory? ToEnum(string value)
        {
            return value switch
            {
                "apps" => PrivateDataSourceViewCategory.Apps,
                "folder" => PrivateDataSourceViewCategory.Folder,
                "managed" => PrivateDataSourceViewCategory.Managed,
                "website" => PrivateDataSourceViewCategory.Website,
                _ => null,
            };
        }
    }
}