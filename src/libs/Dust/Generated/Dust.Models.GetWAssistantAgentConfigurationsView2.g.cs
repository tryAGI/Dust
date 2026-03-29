
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantAgentConfigurationsView2
    {
        /// <summary>
        /// 
        /// </summary>
        AdminInternal,
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Favorites,
        /// <summary>
        /// 
        /// </summary>
        Global,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        Published,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWAssistantAgentConfigurationsView2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantAgentConfigurationsView2 value)
        {
            return value switch
            {
                GetWAssistantAgentConfigurationsView2.AdminInternal => "admin_internal",
                GetWAssistantAgentConfigurationsView2.All => "all",
                GetWAssistantAgentConfigurationsView2.Favorites => "favorites",
                GetWAssistantAgentConfigurationsView2.Global => "global",
                GetWAssistantAgentConfigurationsView2.List => "list",
                GetWAssistantAgentConfigurationsView2.Published => "published",
                GetWAssistantAgentConfigurationsView2.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantAgentConfigurationsView2? ToEnum(string value)
        {
            return value switch
            {
                "admin_internal" => GetWAssistantAgentConfigurationsView2.AdminInternal,
                "all" => GetWAssistantAgentConfigurationsView2.All,
                "favorites" => GetWAssistantAgentConfigurationsView2.Favorites,
                "global" => GetWAssistantAgentConfigurationsView2.Global,
                "list" => GetWAssistantAgentConfigurationsView2.List,
                "published" => GetWAssistantAgentConfigurationsView2.Published,
                "workspace" => GetWAssistantAgentConfigurationsView2.Workspace,
                _ => null,
            };
        }
    }
}