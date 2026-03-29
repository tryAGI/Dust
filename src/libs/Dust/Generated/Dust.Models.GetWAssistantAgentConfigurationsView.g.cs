
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWAssistantAgentConfigurationsView
    {
        /// <summary>
        /// Retrieves all non-private agents (default if not authenticated)
        /// </summary>
        All,
        /// <summary>
        /// Retrieves all agents marked as favorites by the user (only available to authenticated users)
        /// </summary>
        Favorites,
        /// <summary>
        /// Retrieves all global agents
        /// </summary>
        Global,
        /// <summary>
        /// Retrieves all active agents accessible to the user (default if authenticated)
        /// </summary>
        List,
        /// <summary>
        /// Retrieves all agents with published scope
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
    public static class GetWAssistantAgentConfigurationsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWAssistantAgentConfigurationsView value)
        {
            return value switch
            {
                GetWAssistantAgentConfigurationsView.All => "all",
                GetWAssistantAgentConfigurationsView.Favorites => "favorites",
                GetWAssistantAgentConfigurationsView.Global => "global",
                GetWAssistantAgentConfigurationsView.List => "list",
                GetWAssistantAgentConfigurationsView.Published => "published",
                GetWAssistantAgentConfigurationsView.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWAssistantAgentConfigurationsView? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetWAssistantAgentConfigurationsView.All,
                "favorites" => GetWAssistantAgentConfigurationsView.Favorites,
                "global" => GetWAssistantAgentConfigurationsView.Global,
                "list" => GetWAssistantAgentConfigurationsView.List,
                "published" => GetWAssistantAgentConfigurationsView.Published,
                "workspace" => GetWAssistantAgentConfigurationsView.Workspace,
                _ => null,
            };
        }
    }
}