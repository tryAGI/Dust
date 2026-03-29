
#nullable enable

namespace Dust
{
    /// <summary>
    /// Authentication provider
    /// </summary>
    public enum PrivateUserProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Auth0,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Okta,
        /// <summary>
        /// 
        /// </summary>
        Samlp,
        /// <summary>
        /// 
        /// </summary>
        Waad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateUserProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateUserProvider value)
        {
            return value switch
            {
                PrivateUserProvider.Auth0 => "auth0",
                PrivateUserProvider.Github => "github",
                PrivateUserProvider.Google => "google",
                PrivateUserProvider.Okta => "okta",
                PrivateUserProvider.Samlp => "samlp",
                PrivateUserProvider.Waad => "waad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateUserProvider? ToEnum(string value)
        {
            return value switch
            {
                "auth0" => PrivateUserProvider.Auth0,
                "github" => PrivateUserProvider.Github,
                "google" => PrivateUserProvider.Google,
                "okta" => PrivateUserProvider.Okta,
                "samlp" => PrivateUserProvider.Samlp,
                "waad" => PrivateUserProvider.Waad,
                _ => null,
            };
        }
    }
}