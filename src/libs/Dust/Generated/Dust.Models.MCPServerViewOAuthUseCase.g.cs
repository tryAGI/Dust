
#nullable enable

namespace Dust
{
    /// <summary>
    /// OAuth use case for the MCP server view<br/>
    /// Example: platform_actions
    /// </summary>
    public enum MCPServerViewOAuthUseCase
    {
        /// <summary>
        /// 
        /// </summary>
        PersonalActions,
        /// <summary>
        /// 
        /// </summary>
        PlatformActions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPServerViewOAuthUseCaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPServerViewOAuthUseCase value)
        {
            return value switch
            {
                MCPServerViewOAuthUseCase.PersonalActions => "personal_actions",
                MCPServerViewOAuthUseCase.PlatformActions => "platform_actions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPServerViewOAuthUseCase? ToEnum(string value)
        {
            return value switch
            {
                "personal_actions" => MCPServerViewOAuthUseCase.PersonalActions,
                "platform_actions" => MCPServerViewOAuthUseCase.PlatformActions,
                _ => null,
            };
        }
    }
}