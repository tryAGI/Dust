
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWSpacesDataSourceViewsCategory
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
    public static class GetWSpacesDataSourceViewsCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWSpacesDataSourceViewsCategory value)
        {
            return value switch
            {
                GetWSpacesDataSourceViewsCategory.Apps => "apps",
                GetWSpacesDataSourceViewsCategory.Folder => "folder",
                GetWSpacesDataSourceViewsCategory.Managed => "managed",
                GetWSpacesDataSourceViewsCategory.Website => "website",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWSpacesDataSourceViewsCategory? ToEnum(string value)
        {
            return value switch
            {
                "apps" => GetWSpacesDataSourceViewsCategory.Apps,
                "folder" => GetWSpacesDataSourceViewsCategory.Folder,
                "managed" => GetWSpacesDataSourceViewsCategory.Managed,
                "website" => GetWSpacesDataSourceViewsCategory.Website,
                _ => null,
            };
        }
    }
}