
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public enum GetWPodsExportResponsePodStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWPodsExportResponsePodStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWPodsExportResponsePodStatus value)
        {
            return value switch
            {
                GetWPodsExportResponsePodStatus.Active => "active",
                GetWPodsExportResponsePodStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWPodsExportResponsePodStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetWPodsExportResponsePodStatus.Active,
                "archived" => GetWPodsExportResponsePodStatus.Archived,
                _ => null,
            };
        }
    }
}