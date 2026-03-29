
#nullable enable

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateLightAgentConfigurationEditor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentConfigurationEditor" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="fullName"></param>
        /// <param name="image"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateLightAgentConfigurationEditor(
            string? sId,
            string? fullName,
            string? image)
        {
            this.SId = sId;
            this.FullName = fullName;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentConfigurationEditor" /> class.
        /// </summary>
        public PrivateLightAgentConfigurationEditor()
        {
        }
    }
}