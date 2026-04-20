
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateConversationForkUserProvider
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
    public static class PrivateConversationForkUserProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateConversationForkUserProvider value)
        {
            return value switch
            {
                PrivateConversationForkUserProvider.Auth0 => "auth0",
                PrivateConversationForkUserProvider.Github => "github",
                PrivateConversationForkUserProvider.Google => "google",
                PrivateConversationForkUserProvider.Okta => "okta",
                PrivateConversationForkUserProvider.Samlp => "samlp",
                PrivateConversationForkUserProvider.Waad => "waad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateConversationForkUserProvider? ToEnum(string value)
        {
            return value switch
            {
                "auth0" => PrivateConversationForkUserProvider.Auth0,
                "github" => PrivateConversationForkUserProvider.Github,
                "google" => PrivateConversationForkUserProvider.Google,
                "okta" => PrivateConversationForkUserProvider.Okta,
                "samlp" => PrivateConversationForkUserProvider.Samlp,
                "waad" => PrivateConversationForkUserProvider.Waad,
                _ => null,
            };
        }
    }
}