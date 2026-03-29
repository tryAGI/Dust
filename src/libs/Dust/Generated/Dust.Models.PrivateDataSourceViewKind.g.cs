
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateDataSourceViewKind
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
    public static class PrivateDataSourceViewKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateDataSourceViewKind value)
        {
            return value switch
            {
                PrivateDataSourceViewKind.Custom => "custom",
                PrivateDataSourceViewKind.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateDataSourceViewKind? ToEnum(string value)
        {
            return value switch
            {
                "custom" => PrivateDataSourceViewKind.Custom,
                "default" => PrivateDataSourceViewKind.Default,
                _ => null,
            };
        }
    }
}