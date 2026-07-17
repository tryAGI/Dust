
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Message
    {
        /// <summary>
        /// The content of the message. Should not be empty.<br/>
        /// Example: This is my message
        /// </summary>
        /// <example>This is my message</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Empty array is accepted but won't trigger any agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mentions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.Mention> Mentions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Dust.Context? Context { get; set; }

        /// <summary>
        /// Optional per-message model and reasoning-effort override applied to the<br/>
        /// mentioned agent(s). When omitted, each agent runs its configured model.<br/>
        /// If the requested model is not available to the workspace, the agent's<br/>
        /// configured model is used instead. An unknown provider, model, or<br/>
        /// reasoning effort results in a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelSelection")]
        public global::Dust.ModelSelection? ModelSelection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message. Should not be empty.<br/>
        /// Example: This is my message
        /// </param>
        /// <param name="mentions">
        /// Empty array is accepted but won't trigger any agent.
        /// </param>
        /// <param name="context"></param>
        /// <param name="modelSelection">
        /// Optional per-message model and reasoning-effort override applied to the<br/>
        /// mentioned agent(s). When omitted, each agent runs its configured model.<br/>
        /// If the requested model is not available to the workspace, the agent's<br/>
        /// configured model is used instead. An unknown provider, model, or<br/>
        /// reasoning effort results in a 400.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Message(
            string content,
            global::System.Collections.Generic.IList<global::Dust.Mention> mentions,
            global::Dust.Context? context,
            global::Dust.ModelSelection? modelSelection)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Mentions = mentions ?? throw new global::System.ArgumentNullException(nameof(mentions));
            this.Context = context;
            this.ModelSelection = modelSelection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        public Message()
        {
        }

    }
}