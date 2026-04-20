
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateConversationForkUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateConversationForkUserProviderJsonConverter))]
        public global::Dust.PrivateConversationForkUserProvider? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastLoginAt")]
        public int? LastLoginAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationForkUser" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="provider"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="fullName"></param>
        /// <param name="image"></param>
        /// <param name="lastLoginAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateConversationForkUser(
            string? sId,
            int? id,
            int? createdAt,
            global::Dust.PrivateConversationForkUserProvider? provider,
            string? username,
            string? email,
            string? firstName,
            string? lastName,
            string? fullName,
            string? image,
            int? lastLoginAt)
        {
            this.SId = sId;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Provider = provider;
            this.Username = username;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
            this.Image = image;
            this.LastLoginAt = lastLoginAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateConversationForkUser" /> class.
        /// </summary>
        public PrivateConversationForkUser()
        {
        }
    }
}