
#nullable enable

namespace Dust
{
    /// <summary>
    /// A mention in a message (agent or user).
    /// </summary>
    public sealed partial class PrivateMention
    {
        /// <summary>
        /// Agent configuration sId (for agent mentions)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Present only for user mentions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateMentionTypeJsonConverter))]
        public global::Dust.PrivateMentionType? Type { get; set; }

        /// <summary>
        /// User sId (for user mentions)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateMention" /> class.
        /// </summary>
        /// <param name="configurationId">
        /// Agent configuration sId (for agent mentions)
        /// </param>
        /// <param name="type">
        /// Present only for user mentions
        /// </param>
        /// <param name="userId">
        /// User sId (for user mentions)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateMention(
            string? configurationId,
            global::Dust.PrivateMentionType? type,
            string? userId)
        {
            this.ConfigurationId = configurationId;
            this.Type = type;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateMention" /> class.
        /// </summary>
        public PrivateMention()
        {
        }
    }
}