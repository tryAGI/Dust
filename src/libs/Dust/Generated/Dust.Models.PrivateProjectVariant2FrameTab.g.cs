
#nullable enable

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateProjectVariant2FrameTab
    {
        /// <summary>
        /// Canonical scoped path to the frame file in the Pod filesystem.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Display title for the tab.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Action icon name (e.g. ActionDashboardIcon).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Icon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProjectVariant2FrameTab" /> class.
        /// </summary>
        /// <param name="path">
        /// Canonical scoped path to the frame file in the Pod filesystem.
        /// </param>
        /// <param name="title">
        /// Display title for the tab.
        /// </param>
        /// <param name="icon">
        /// Action icon name (e.g. ActionDashboardIcon).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateProjectVariant2FrameTab(
            string path,
            string title,
            string icon)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProjectVariant2FrameTab" /> class.
        /// </summary>
        public PrivateProjectVariant2FrameTab()
        {
        }

    }
}