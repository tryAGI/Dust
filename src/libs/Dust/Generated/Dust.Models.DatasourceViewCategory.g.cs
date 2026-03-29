
#nullable enable

namespace Dust
{
    /// <summary>
    /// The category of the data source view
    /// </summary>
    public enum DatasourceViewCategory
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
    public static class DatasourceViewCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasourceViewCategory value)
        {
            return value switch
            {
                DatasourceViewCategory.Apps => "apps",
                DatasourceViewCategory.Folder => "folder",
                DatasourceViewCategory.Managed => "managed",
                DatasourceViewCategory.Website => "website",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasourceViewCategory? ToEnum(string value)
        {
            return value switch
            {
                "apps" => DatasourceViewCategory.Apps,
                "folder" => DatasourceViewCategory.Folder,
                "managed" => DatasourceViewCategory.Managed,
                "website" => DatasourceViewCategory.Website,
                _ => null,
            };
        }
    }
}