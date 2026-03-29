
#nullable enable

namespace Dust
{
    /// <summary>
    /// Type of the MCP server<br/>
    /// Example: remote
    /// </summary>
    public enum MCPServerViewServerType
    {
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Remote,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPServerViewServerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPServerViewServerType value)
        {
            return value switch
            {
                MCPServerViewServerType.Internal => "internal",
                MCPServerViewServerType.Remote => "remote",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPServerViewServerType? ToEnum(string value)
        {
            return value switch
            {
                "internal" => MCPServerViewServerType.Internal,
                "remote" => MCPServerViewServerType.Remote,
                _ => null,
            };
        }
    }
}