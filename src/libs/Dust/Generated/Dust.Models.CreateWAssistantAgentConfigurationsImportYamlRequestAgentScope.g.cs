
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWAssistantAgentConfigurationsImportYamlRequestAgentScope
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
    public static class CreateWAssistantAgentConfigurationsImportYamlRequestAgentScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWAssistantAgentConfigurationsImportYamlRequestAgentScope value)
        {
            return value switch
            {
                CreateWAssistantAgentConfigurationsImportYamlRequestAgentScope.Hidden => "hidden",
                CreateWAssistantAgentConfigurationsImportYamlRequestAgentScope.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWAssistantAgentConfigurationsImportYamlRequestAgentScope? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => CreateWAssistantAgentConfigurationsImportYamlRequestAgentScope.Hidden,
                "visible" => CreateWAssistantAgentConfigurationsImportYamlRequestAgentScope.Visible,
                _ => null,
            };
        }
    }
}