
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Mention
    {
        /// <summary>
        /// ID of the mentioned agent configuration<br/>
        /// Example: 7f3a9c2b1e
        /// </summary>
        /// <example>7f3a9c2b1e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Mention" /> class.
        /// </summary>
        /// <param name="configurationId">
        /// ID of the mentioned agent configuration<br/>
        /// Example: 7f3a9c2b1e
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Mention(
            string? configurationId)
        {
            this.ConfigurationId = configurationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mention" /> class.
        /// </summary>
        public Mention()
        {
        }
    }
}