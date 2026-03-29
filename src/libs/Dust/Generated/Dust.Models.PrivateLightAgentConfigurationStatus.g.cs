
#nullable enable

namespace Dust
{
    /// <summary>
    /// Agent status
    /// </summary>
    public enum PrivateLightAgentConfigurationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        DisabledByAdmin,
        /// <summary>
        /// 
        /// </summary>
        DisabledFreeWorkspace,
        /// <summary>
        /// 
        /// </summary>
        DisabledMissingDatasource,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateLightAgentConfigurationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateLightAgentConfigurationStatus value)
        {
            return value switch
            {
                PrivateLightAgentConfigurationStatus.Active => "active",
                PrivateLightAgentConfigurationStatus.Archived => "archived",
                PrivateLightAgentConfigurationStatus.DisabledByAdmin => "disabled_by_admin",
                PrivateLightAgentConfigurationStatus.DisabledFreeWorkspace => "disabled_free_workspace",
                PrivateLightAgentConfigurationStatus.DisabledMissingDatasource => "disabled_missing_datasource",
                PrivateLightAgentConfigurationStatus.Draft => "draft",
                PrivateLightAgentConfigurationStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateLightAgentConfigurationStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PrivateLightAgentConfigurationStatus.Active,
                "archived" => PrivateLightAgentConfigurationStatus.Archived,
                "disabled_by_admin" => PrivateLightAgentConfigurationStatus.DisabledByAdmin,
                "disabled_free_workspace" => PrivateLightAgentConfigurationStatus.DisabledFreeWorkspace,
                "disabled_missing_datasource" => PrivateLightAgentConfigurationStatus.DisabledMissingDatasource,
                "draft" => PrivateLightAgentConfigurationStatus.Draft,
                "pending" => PrivateLightAgentConfigurationStatus.Pending,
                _ => null,
            };
        }
    }
}