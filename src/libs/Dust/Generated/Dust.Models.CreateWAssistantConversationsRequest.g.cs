
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.Message Message { get; set; }

        /// <summary>
        /// The list of content fragments to attach to this conversation (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentFragments")]
        public global::System.Collections.Generic.IList<global::Dust.ContentFragment>? ContentFragments { get; set; }

        /// <summary>
        /// The title of the conversation<br/>
        /// Example: My conversation
        /// </summary>
        /// <example>My conversation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Whether to skip the tools validation of the agent messages triggered by this user message (optional, defaults to false)<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipToolsValidation")]
        public bool? SkipToolsValidation { get; set; }

        /// <summary>
        /// Whether to wait for the agent to generate the initial message. If true the query will wait for the agent's answer. If false (default), the API will return a conversation ID directly and you will need to use streaming events to get the messages.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking")]
        public bool? Blocking { get; set; }

        /// <summary>
        /// The sId of the space (project) in which to create the conversation (optional). If not provided, the conversation is created outside projects<br/>
        /// Example: space_abc123
        /// </summary>
        /// <example>space_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceId")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequest" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="contentFragments">
        /// The list of content fragments to attach to this conversation (optional)
        /// </param>
        /// <param name="title">
        /// The title of the conversation<br/>
        /// Example: My conversation
        /// </param>
        /// <param name="skipToolsValidation">
        /// Whether to skip the tools validation of the agent messages triggered by this user message (optional, defaults to false)<br/>
        /// Example: false
        /// </param>
        /// <param name="blocking">
        /// Whether to wait for the agent to generate the initial message. If true the query will wait for the agent's answer. If false (default), the API will return a conversation ID directly and you will need to use streaming events to get the messages.<br/>
        /// Example: true
        /// </param>
        /// <param name="spaceId">
        /// The sId of the space (project) in which to create the conversation (optional). If not provided, the conversation is created outside projects<br/>
        /// Example: space_abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsRequest(
            global::Dust.Message message,
            global::System.Collections.Generic.IList<global::Dust.ContentFragment>? contentFragments,
            string? title,
            bool? skipToolsValidation,
            bool? blocking,
            string? spaceId)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ContentFragments = contentFragments;
            this.Title = title;
            this.SkipToolsValidation = skipToolsValidation;
            this.Blocking = blocking;
            this.SpaceId = spaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequest" /> class.
        /// </summary>
        public CreateWAssistantConversationsRequest()
        {
        }
    }
}