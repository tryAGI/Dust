
#nullable enable

namespace Dust
{
    /// <summary>
    /// Composer draft resolved from a Contentful conversation go template.
    /// </summary>
    public sealed partial class GetGoTemplateDraftResponseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.GetGoTemplateDraftResponseBodyAttachment> Attachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachmentErrors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.GetGoTemplateDraftResponseBodyAttachmentError> AttachmentErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGoTemplateDraftResponseBody" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="prompt"></param>
        /// <param name="attachments"></param>
        /// <param name="attachmentErrors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetGoTemplateDraftResponseBody(
            string title,
            string prompt,
            global::System.Collections.Generic.IList<global::Dust.GetGoTemplateDraftResponseBodyAttachment> attachments,
            global::System.Collections.Generic.IList<global::Dust.GetGoTemplateDraftResponseBodyAttachmentError> attachmentErrors)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Attachments = attachments ?? throw new global::System.ArgumentNullException(nameof(attachments));
            this.AttachmentErrors = attachmentErrors ?? throw new global::System.ArgumentNullException(nameof(attachmentErrors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGoTemplateDraftResponseBody" /> class.
        /// </summary>
        public GetGoTemplateDraftResponseBody()
        {
        }

    }
}