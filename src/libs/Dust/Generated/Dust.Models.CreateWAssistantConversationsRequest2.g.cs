
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWAssistantConversationsRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.CreateWAssistantConversationsRequestVisibilityJsonConverter))]
        public global::Dust.CreateWAssistantConversationsRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceId")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::Dust.CreateWAssistantConversationsRequestMessage? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentFragments")]
        public global::System.Collections.Generic.IList<object>? ContentFragments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipToolsValidation")]
        public bool? SkipToolsValidation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequest2" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="visibility"></param>
        /// <param name="spaceId"></param>
        /// <param name="message"></param>
        /// <param name="contentFragments"></param>
        /// <param name="metadata"></param>
        /// <param name="skipToolsValidation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWAssistantConversationsRequest2(
            string? title,
            global::Dust.CreateWAssistantConversationsRequestVisibility? visibility,
            string? spaceId,
            global::Dust.CreateWAssistantConversationsRequestMessage? message,
            global::System.Collections.Generic.IList<object>? contentFragments,
            object? metadata,
            bool? skipToolsValidation)
        {
            this.Title = title;
            this.Visibility = visibility;
            this.SpaceId = spaceId;
            this.Message = message;
            this.ContentFragments = contentFragments;
            this.Metadata = metadata;
            this.SkipToolsValidation = skipToolsValidation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWAssistantConversationsRequest2" /> class.
        /// </summary>
        public CreateWAssistantConversationsRequest2()
        {
        }
    }
}