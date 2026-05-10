
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateProjectVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMember")]
        public bool? IsMember { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archivedAt")]
        public int? ArchivedAt { get; set; }

        /// <summary>
        /// Whether automatic todo suggestions from project activity are enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("todoGenerationEnabled")]
        public bool? TodoGenerationEnabled { get; set; }

        /// <summary>
        /// Unix timestamp (ms) of the last automatic todo suggestion scan, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastTodoAnalysisAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? LastTodoAnalysisAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProjectVariant2" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="isMember"></param>
        /// <param name="archivedAt"></param>
        /// <param name="todoGenerationEnabled">
        /// Whether automatic todo suggestions from project activity are enabled.
        /// </param>
        /// <param name="lastTodoAnalysisAt">
        /// Unix timestamp (ms) of the last automatic todo suggestion scan, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateProjectVariant2(
            string? description,
            bool? isMember,
            int? archivedAt,
            bool? todoGenerationEnabled,
            global::System.DateTimeOffset? lastTodoAnalysisAt)
        {
            this.Description = description;
            this.IsMember = isMember;
            this.ArchivedAt = archivedAt;
            this.TodoGenerationEnabled = todoGenerationEnabled;
            this.LastTodoAnalysisAt = lastTodoAnalysisAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProjectVariant2" /> class.
        /// </summary>
        public PrivateProjectVariant2()
        {
        }

    }
}