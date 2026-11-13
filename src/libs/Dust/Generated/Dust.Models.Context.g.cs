
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Context
    {
        /// <summary>
        /// Username in the current context<br/>
        /// Example: johndoe123
        /// </summary>
        /// <example>johndoe123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// User's timezone<br/>
        /// Example: America/New_York
        /// </summary>
        /// <example>America/New_York</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// User's full name in the current context<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        /// <summary>
        /// User's email in the current context<br/>
        /// Example: john.doe@example.com
        /// </summary>
        /// <example>john.doe@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// URL of the user's profile picture<br/>
        /// Example: https://example.com/profiles/johndoe123.jpg
        /// </summary>
        /// <example>https://example.com/profiles/johndoe123.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("profilePictureUrl")]
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// Data source tags to exclude from retrieval for this run, as opaque `key:value` strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludedRetrievalTags")]
        public global::System.Collections.Generic.IList<string>? ExcludedRetrievalTags { get; set; }

        /// <summary>
        /// What the user had selected in the app hosting Dust when sending the message, e.g. `Sheet1!C5:D6` in Excel, or, as JSON, a selection in a document open next to the conversation. Stored with the message and shown to the agent in that message's metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostSelection")]
        public string? HostSelection { get; set; }

        /// <summary>
        /// The file open in the app hosting Dust when sending the message, e.g. `Budget.xlsx` in Excel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostDocument")]
        public global::Dust.ContextHostDocument? HostDocument { get; set; }

        /// <summary>
        /// The auth method the message was sent with, e.g. `oauth` for a member's personal login or `api_key`. A sub-agent message reports the one of the message that started it. Set by Dust; ignored when sent.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authMethod")]
        public string? AuthMethod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agenticMessageData")]
        public global::Dust.ContextAgenticMessageData? AgenticMessageData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Context" /> class.
        /// </summary>
        /// <param name="username">
        /// Username in the current context<br/>
        /// Example: johndoe123
        /// </param>
        /// <param name="timezone">
        /// User's timezone<br/>
        /// Example: America/New_York
        /// </param>
        /// <param name="fullName">
        /// User's full name in the current context<br/>
        /// Example: John Doe
        /// </param>
        /// <param name="email">
        /// User's email in the current context<br/>
        /// Example: john.doe@example.com
        /// </param>
        /// <param name="profilePictureUrl">
        /// URL of the user's profile picture<br/>
        /// Example: https://example.com/profiles/johndoe123.jpg
        /// </param>
        /// <param name="excludedRetrievalTags">
        /// Data source tags to exclude from retrieval for this run, as opaque `key:value` strings.
        /// </param>
        /// <param name="hostSelection">
        /// What the user had selected in the app hosting Dust when sending the message, e.g. `Sheet1!C5:D6` in Excel, or, as JSON, a selection in a document open next to the conversation. Stored with the message and shown to the agent in that message's metadata.
        /// </param>
        /// <param name="hostDocument">
        /// The file open in the app hosting Dust when sending the message, e.g. `Budget.xlsx` in Excel.
        /// </param>
        /// <param name="authMethod">
        /// The auth method the message was sent with, e.g. `oauth` for a member's personal login or `api_key`. A sub-agent message reports the one of the message that started it. Set by Dust; ignored when sent.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="agenticMessageData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Context(
            string username,
            string timezone,
            string? fullName,
            string? email,
            string? profilePictureUrl,
            global::System.Collections.Generic.IList<string>? excludedRetrievalTags,
            string? hostSelection,
            global::Dust.ContextHostDocument? hostDocument,
            string? authMethod,
            global::Dust.ContextAgenticMessageData? agenticMessageData)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
            this.FullName = fullName;
            this.Email = email;
            this.ProfilePictureUrl = profilePictureUrl;
            this.ExcludedRetrievalTags = excludedRetrievalTags;
            this.HostSelection = hostSelection;
            this.HostDocument = hostDocument;
            this.AuthMethod = authMethod;
            this.AgenticMessageData = agenticMessageData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Context" /> class.
        /// </summary>
        public Context()
        {
        }

    }
}