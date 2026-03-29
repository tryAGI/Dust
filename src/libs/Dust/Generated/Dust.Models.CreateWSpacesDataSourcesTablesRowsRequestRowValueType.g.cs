
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWSpacesDataSourcesTablesRowsRequestRowValueType
    {
        /// <summary>
        /// 
        /// </summary>
        Datetime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWSpacesDataSourcesTablesRowsRequestRowValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWSpacesDataSourcesTablesRowsRequestRowValueType value)
        {
            return value switch
            {
                CreateWSpacesDataSourcesTablesRowsRequestRowValueType.Datetime => "datetime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWSpacesDataSourcesTablesRowsRequestRowValueType? ToEnum(string value)
        {
            return value switch
            {
                "datetime" => CreateWSpacesDataSourcesTablesRowsRequestRowValueType.Datetime,
                _ => null,
            };
        }
    }
}