
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateGenerationTokensEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateGenerationTokensEventTypeJsonConverter))]
        public global::Dust.PrivateGenerationTokensEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// The token(s) generated in this chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateGenerationTokensEventClassificationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateGenerationTokensEventClassification Classification { get; set; }

        /// <summary>
        /// Present when classification is opening_delimiter or closing_delimiter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delimiterClassification")]
        public string? DelimiterClassification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public int? Step { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateGenerationTokensEvent" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="configurationId"></param>
        /// <param name="messageId"></param>
        /// <param name="text">
        /// The token(s) generated in this chunk
        /// </param>
        /// <param name="classification"></param>
        /// <param name="type"></param>
        /// <param name="delimiterClassification">
        /// Present when classification is opening_delimiter or closing_delimiter
        /// </param>
        /// <param name="step"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateGenerationTokensEvent(
            int created,
            string configurationId,
            string messageId,
            string text,
            global::Dust.PrivateGenerationTokensEventClassification classification,
            global::Dust.PrivateGenerationTokensEventType type,
            string? delimiterClassification,
            int? step)
        {
            this.Type = type;
            this.Created = created;
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Classification = classification;
            this.DelimiterClassification = delimiterClassification;
            this.Step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateGenerationTokensEvent" /> class.
        /// </summary>
        public PrivateGenerationTokensEvent()
        {
        }
    }
}