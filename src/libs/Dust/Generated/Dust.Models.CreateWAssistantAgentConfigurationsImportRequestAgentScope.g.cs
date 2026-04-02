
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWAssistantAgentConfigurationsImportRequestAgentScope
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
    public static class CreateWAssistantAgentConfigurationsImportRequestAgentScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAssistantAgentConfigurationsImportRequestAgentScope value)
        {
            return value switch
            {
                CreateWAssistantAgentConfigurationsImportRequestAgentScope.Hidden => "hidden",
                CreateWAssistantAgentConfigurationsImportRequestAgentScope.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAssistantAgentConfigurationsImportRequestAgentScope? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => CreateWAssistantAgentConfigurationsImportRequestAgentScope.Hidden,
                "visible" => CreateWAssistantAgentConfigurationsImportRequestAgentScope.Visible,
                _ => null,
            };
        }
    }
}