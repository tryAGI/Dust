
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWSpacesDataSourceViewsIncludeEditedBy
    {
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWSpacesDataSourceViewsIncludeEditedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWSpacesDataSourceViewsIncludeEditedBy value)
        {
            return value switch
            {
                GetWSpacesDataSourceViewsIncludeEditedBy.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWSpacesDataSourceViewsIncludeEditedBy? ToEnum(string value)
        {
            return value switch
            {
                "true" => GetWSpacesDataSourceViewsIncludeEditedBy.True,
                _ => null,
            };
        }
    }
}