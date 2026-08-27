
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetWSpacesResponseSpaceFrameTab
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponseSpaceFrameTab" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="title"></param>
        /// <param name="icon"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWSpacesResponseSpaceFrameTab(
            string? path,
            string? title,
            string? icon)
        {
            this.Path = path;
            this.Title = title;
            this.Icon = icon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWSpacesResponseSpaceFrameTab" /> class.
        /// </summary>
        public GetWSpacesResponseSpaceFrameTab()
        {
        }

    }
}