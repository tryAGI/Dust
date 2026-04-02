
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchWAssistantAgentConfigurationsRequestAgentScope
    {
        /// <summary>
        /// 
        /// </summary>
        Hidden,
        /// <summary>
        /// 
        /// </summary>
        Visible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchWAssistantAgentConfigurationsRequestAgentScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchWAssistantAgentConfigurationsRequestAgentScope value)
        {
            return value switch
            {
                PatchWAssistantAgentConfigurationsRequestAgentScope.Hidden => "hidden",
                PatchWAssistantAgentConfigurationsRequestAgentScope.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchWAssistantAgentConfigurationsRequestAgentScope? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => PatchWAssistantAgentConfigurationsRequestAgentScope.Hidden,
                "visible" => PatchWAssistantAgentConfigurationsRequestAgentScope.Visible,
                _ => null,
            };
        }
    }
}