
#nullable enable

namespace Dust
{
    /// <summary>
    /// Data type of the column<br/>
    /// Example: int
    /// </summary>
    public enum TableSchemaItemValueType
    {
        /// <summary>
        /// 
        /// </summary>
        Bool,
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Int,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TableSchemaItemValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TableSchemaItemValueType value)
        {
            return value switch
            {
                TableSchemaItemValueType.Bool => "bool",
                TableSchemaItemValueType.Date => "date",
                TableSchemaItemValueType.Float => "float",
                TableSchemaItemValueType.Int => "int",
                TableSchemaItemValueType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TableSchemaItemValueType? ToEnum(string value)
        {
            return value switch
            {
                "bool" => TableSchemaItemValueType.Bool,
                "date" => TableSchemaItemValueType.Date,
                "float" => TableSchemaItemValueType.Float,
                "int" => TableSchemaItemValueType.Int,
                "text" => TableSchemaItemValueType.Text,
                _ => null,
            };
        }
    }
}