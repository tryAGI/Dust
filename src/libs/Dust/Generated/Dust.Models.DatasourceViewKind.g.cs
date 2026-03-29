
#nullable enable

namespace Dust
{
    /// <summary>
    /// The kind of the data source view
    /// </summary>
    public enum DatasourceViewKind
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasourceViewKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasourceViewKind value)
        {
            return value switch
            {
                DatasourceViewKind.Custom => "custom",
                DatasourceViewKind.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasourceViewKind? ToEnum(string value)
        {
            return value switch
            {
                "custom" => DatasourceViewKind.Custom,
                "default" => DatasourceViewKind.Default,
                _ => null,
            };
        }
    }
}