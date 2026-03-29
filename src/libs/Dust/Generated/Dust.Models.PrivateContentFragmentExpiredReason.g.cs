
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateContentFragmentExpiredReason
    {
        /// <summary>
        /// 
        /// </summary>
        DataSourceDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateContentFragmentExpiredReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateContentFragmentExpiredReason value)
        {
            return value switch
            {
                PrivateContentFragmentExpiredReason.DataSourceDeleted => "data_source_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateContentFragmentExpiredReason? ToEnum(string value)
        {
            return value switch
            {
                "data_source_deleted" => PrivateContentFragmentExpiredReason.DataSourceDeleted,
                _ => null,
            };
        }
    }
}