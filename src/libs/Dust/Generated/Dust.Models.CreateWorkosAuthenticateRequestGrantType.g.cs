
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWorkosAuthenticateRequestGrantType
    {
        /// <summary>
        /// 
        /// </summary>
        RefreshToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWorkosAuthenticateRequestGrantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkosAuthenticateRequestGrantType value)
        {
            return value switch
            {
                CreateWorkosAuthenticateRequestGrantType.RefreshToken => "refresh_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkosAuthenticateRequestGrantType? ToEnum(string value)
        {
            return value switch
            {
                "refresh_token" => CreateWorkosAuthenticateRequestGrantType.RefreshToken,
                _ => null,
            };
        }
    }
}