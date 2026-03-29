
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// Unique string identifier for the user<br/>
        /// Example: 0ec9852c2f
        /// </summary>
        /// <example>0ec9852c2f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Example: 1625097600
        /// </summary>
        /// <example>1625097600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// User's chosen username<br/>
        /// Example: johndoe
        /// </summary>
        /// <example>johndoe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// User's email address<br/>
        /// Example: john.doe@example.com
        /// </summary>
        /// <example>john.doe@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// User's first name<br/>
        /// Example: John
        /// </summary>
        /// <example>John</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// User's last name<br/>
        /// Example: Doe
        /// </summary>
        /// <example>Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// User's full name<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        /// <summary>
        /// Authentication provider used by the user<br/>
        /// Example: google
        /// </summary>
        /// <example>google</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// URL of the user's profile image<br/>
        /// Example: https://example.com/profile/johndoe.jpg
        /// </summary>
        /// <example>https://example.com/profile/johndoe.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="sId">
        /// Unique string identifier for the user<br/>
        /// Example: 0ec9852c2f
        /// </param>
        /// <param name="id">
        /// Example: 12345
        /// </param>
        /// <param name="createdAt">
        /// Example: 1625097600
        /// </param>
        /// <param name="username">
        /// User's chosen username<br/>
        /// Example: johndoe
        /// </param>
        /// <param name="email">
        /// User's email address<br/>
        /// Example: john.doe@example.com
        /// </param>
        /// <param name="firstName">
        /// User's first name<br/>
        /// Example: John
        /// </param>
        /// <param name="lastName">
        /// User's last name<br/>
        /// Example: Doe
        /// </param>
        /// <param name="fullName">
        /// User's full name<br/>
        /// Example: John Doe
        /// </param>
        /// <param name="provider">
        /// Authentication provider used by the user<br/>
        /// Example: google
        /// </param>
        /// <param name="image">
        /// URL of the user's profile image<br/>
        /// Example: https://example.com/profile/johndoe.jpg
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public User(
            string? sId,
            int? id,
            int? createdAt,
            string? username,
            string? email,
            string? firstName,
            string? lastName,
            string? fullName,
            string? provider,
            string? image)
        {
            this.SId = sId;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Username = username;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
            this.Provider = provider;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }
    }
}