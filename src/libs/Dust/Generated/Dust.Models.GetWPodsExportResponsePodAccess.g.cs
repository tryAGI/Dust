
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum GetWPodsExportResponsePodAccess
    {
        /// <summary>
        ///
        /// </summary>
        Open,
        /// <summary>
        ///
        /// </summary>
        Restricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWPodsExportResponsePodAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWPodsExportResponsePodAccess value)
        {
            return value switch
            {
                GetWPodsExportResponsePodAccess.Open => "open",
                GetWPodsExportResponsePodAccess.Restricted => "restricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWPodsExportResponsePodAccess? ToEnum(string value)
        {
            return value switch
            {
                "open" => GetWPodsExportResponsePodAccess.Open,
                "restricted" => GetWPodsExportResponsePodAccess.Restricted,
                _ => null,
            };
        }
    }
}