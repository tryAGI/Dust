
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateContentFragmentContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profilePictureUrl")]
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateContentFragmentContext" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <param name="profilePictureUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateContentFragmentContext(
            string? username,
            string? fullName,
            string? email,
            string? profilePictureUrl)
        {
            this.Username = username;
            this.FullName = fullName;
            this.Email = email;
            this.ProfilePictureUrl = profilePictureUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateContentFragmentContext" /> class.
        /// </summary>
        public PrivateContentFragmentContext()
        {
        }
    }
}