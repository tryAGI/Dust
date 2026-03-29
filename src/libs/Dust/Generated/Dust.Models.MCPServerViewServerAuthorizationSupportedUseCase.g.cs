
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum MCPServerViewServerAuthorizationSupportedUseCase
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
    public static class MCPServerViewServerAuthorizationSupportedUseCaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPServerViewServerAuthorizationSupportedUseCase value)
        {
            return value switch
            {
                MCPServerViewServerAuthorizationSupportedUseCase.PersonalActions => "personal_actions",
                MCPServerViewServerAuthorizationSupportedUseCase.PlatformActions => "platform_actions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPServerViewServerAuthorizationSupportedUseCase? ToEnum(string value)
        {
            return value switch
            {
                "personal_actions" => MCPServerViewServerAuthorizationSupportedUseCase.PersonalActions,
                "platform_actions" => MCPServerViewServerAuthorizationSupportedUseCase.PlatformActions,
                _ => null,
            };
        }
    }
}