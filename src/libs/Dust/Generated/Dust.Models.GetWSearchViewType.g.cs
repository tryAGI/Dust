
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWSearchViewType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWSearchViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWSearchViewType value)
        {
            return value switch
            {
                GetWSearchViewType.All => "all",
                GetWSearchViewType.Document => "document",
                GetWSearchViewType.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWSearchViewType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetWSearchViewType.All,
                "document" => GetWSearchViewType.Document,
                "table" => GetWSearchViewType.Table,
                _ => null,
            };
        }
    }
}