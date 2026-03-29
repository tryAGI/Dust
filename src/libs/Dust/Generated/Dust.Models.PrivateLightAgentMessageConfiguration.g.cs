
#nullable enable

namespace Dust
{
    /// <summary>
    /// Minimal agent configuration info
    /// </summary>
    public sealed partial class PrivateLightAgentMessageConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        public string? SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canRead")]
        public bool? CanRead { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentMessageConfiguration" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="name"></param>
        /// <param name="pictureUrl"></param>
        /// <param name="status"></param>
        /// <param name="canRead"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateLightAgentMessageConfiguration(
            string? sId,
            string? name,
            string? pictureUrl,
            string? status,
            bool? canRead)
        {
            this.SId = sId;
            this.Name = name;
            this.PictureUrl = pictureUrl;
            this.Status = status;
            this.CanRead = canRead;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentMessageConfiguration" /> class.
        /// </summary>
        public PrivateLightAgentMessageConfiguration()
        {
        }
    }
}