
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextAgenticMessageData
    {
        /// <summary>
        /// Type of the agentic message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.ContextAgenticMessageDataTypeJsonConverter))]
        public global::Dust.ContextAgenticMessageDataType? Type { get; set; }

        /// <summary>
        /// ID of the origin message<br/>
        /// Example: 2b8e4f6a0c
        /// </summary>
        /// <example>2b8e4f6a0c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("originMessageId")]
        public string? OriginMessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextAgenticMessageData" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the agentic message
        /// </param>
        /// <param name="originMessageId">
        /// ID of the origin message<br/>
        /// Example: 2b8e4f6a0c
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextAgenticMessageData(
            global::Dust.ContextAgenticMessageDataType? type,
            string? originMessageId)
        {
            this.Type = type;
            this.OriginMessageId = originMessageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextAgenticMessageData" /> class.
        /// </summary>
        public ContextAgenticMessageData()
        {
        }
    }
}