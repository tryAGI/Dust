
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateDataSourceViewUsageAgent
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateDataSourceViewUsageAgent" /> class.
        /// </summary>
        /// <param name="sId"></param>
        /// <param name="name"></param>
        /// <param name="pictureUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateDataSourceViewUsageAgent(
            string? sId,
            string? name,
            string? pictureUrl)
        {
            this.SId = sId;
            this.Name = name;
            this.PictureUrl = pictureUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateDataSourceViewUsageAgent" /> class.
        /// </summary>
        public PrivateDataSourceViewUsageAgent()
        {
        }

    }
}