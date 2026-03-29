
#nullable enable

namespace Dust
{
    /// <summary>
    /// Authenticated user with their workspaces and subscriber hash.
    /// </summary>
    public sealed partial class PrivateUser
    {
        /// <summary>
        /// Unique string identifier for the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// Numeric model identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Unix timestamp of user creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Authentication provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateUserProviderJsonConverter))]
        public global::Dust.PrivateUserProvider? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullName { get; set; }

        /// <summary>
        /// URL of the user's profile image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastLoginAt")]
        public int? LastLoginAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateWorkspace> Workspaces { get; set; }

        /// <summary>
        /// sId of the currently selected workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectedWorkspace")]
        public string? SelectedWorkspace { get; set; }

        /// <summary>
        /// How the user joined (e.g. invitation, provisioned)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// Hash used for Intercom identity verification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberHash")]
        public string? SubscriberHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUser" /> class.
        /// </summary>
        /// <param name="sId">
        /// Unique string identifier for the user
        /// </param>
        /// <param name="id">
        /// Numeric model identifier
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp of user creation
        /// </param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="fullName"></param>
        /// <param name="workspaces"></param>
        /// <param name="provider">
        /// Authentication provider
        /// </param>
        /// <param name="lastName"></param>
        /// <param name="image">
        /// URL of the user's profile image
        /// </param>
        /// <param name="lastLoginAt"></param>
        /// <param name="selectedWorkspace">
        /// sId of the currently selected workspace
        /// </param>
        /// <param name="origin">
        /// How the user joined (e.g. invitation, provisioned)
        /// </param>
        /// <param name="subscriberHash">
        /// Hash used for Intercom identity verification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateUser(
            string sId,
            int id,
            global::System.DateTimeOffset createdAt,
            string username,
            string email,
            string firstName,
            string fullName,
            global::System.Collections.Generic.IList<global::Dust.PrivateWorkspace> workspaces,
            global::Dust.PrivateUserProvider? provider,
            string? lastName,
            string? image,
            int? lastLoginAt,
            string? selectedWorkspace,
            string? origin,
            string? subscriberHash)
        {
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Provider = provider;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.LastName = lastName;
            this.FullName = fullName ?? throw new global::System.ArgumentNullException(nameof(fullName));
            this.Image = image;
            this.LastLoginAt = lastLoginAt;
            this.Workspaces = workspaces ?? throw new global::System.ArgumentNullException(nameof(workspaces));
            this.SelectedWorkspace = selectedWorkspace;
            this.Origin = origin;
            this.SubscriberHash = subscriberHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateUser" /> class.
        /// </summary>
        public PrivateUser()
        {
        }
    }
}