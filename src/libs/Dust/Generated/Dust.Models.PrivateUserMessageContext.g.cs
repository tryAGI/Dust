
#nullable enable

namespace Dust
{
    /// <summary>
    /// Context metadata for a user message.
    /// </summary>
    public sealed partial class PrivateUserMessageContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateUserMessageContextOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateUserMessageContextOrigin Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUserMessageContext" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="timezone"></param>
        /// <param name="origin"></param>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <param name="profilePictureUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateUserMessageContext(
            string username,
            string timezone,
            global::Dust.PrivateUserMessageContextOrigin origin,
            string? fullName,
            string? email,
            string? profilePictureUrl)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.FullName = fullName;
            this.Email = email;
            this.ProfilePictureUrl = profilePictureUrl;
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUserMessageContext" /> class.
        /// </summary>
        public PrivateUserMessageContext()
        {
        }
    }
}