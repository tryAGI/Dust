
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
        [global::System.Text.Json.Serialization.JsonPropertyName("groupIds")]
        public global::System.Collections.Generic.IList<string>? GroupIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isRestricted")]
        public bool? IsRestricted { get; set; }

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
        /// Scoped path to the frame file pinned as the Pod banner (e.g. project/banner.html).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinnedFramePath")]
        public string? PinnedFramePath { get; set; }

        /// <summary>
        /// Frames promoted as custom Pod tabs (shared for all members).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameTabs")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateProjectVariant2FrameTab>? FrameTabs { get; set; }

        /// <summary>
        /// Interleaved system tab ids and frame paths before Settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tabsOrder")]
        public global::System.Collections.Generic.IList<string>? TabsOrder { get; set; }

        /// <summary>
        /// Whether workspace admins control membership and connected data for this Pod.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAdminControlled")]
        public bool? IsAdminControlled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProjectVariant2" /> class.
        /// </summary>
        /// <param name="groupIds"></param>
        /// <param name="isRestricted"></param>
        /// <param name="description"></param>
        /// <param name="isMember"></param>
        /// <param name="archivedAt"></param>
        /// <param name="todoGenerationEnabled">
        /// Whether automatic todo suggestions from project activity are enabled.
        /// </param>
        /// <param name="lastTodoAnalysisAt">
        /// Unix timestamp (ms) of the last automatic todo suggestion scan, if any.
        /// </param>
        /// <param name="pinnedFramePath">
        /// Scoped path to the frame file pinned as the Pod banner (e.g. project/banner.html).
        /// </param>
        /// <param name="frameTabs">
        /// Frames promoted as custom Pod tabs (shared for all members).
        /// </param>
        /// <param name="tabsOrder">
        /// Interleaved system tab ids and frame paths before Settings.
        /// </param>
        /// <param name="isAdminControlled">
        /// Whether workspace admins control membership and connected data for this Pod.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateProjectVariant2(
            global::System.Collections.Generic.IList<string>? groupIds,
            bool? isRestricted,
            string? description,
            bool? isMember,
            int? archivedAt,
            bool? todoGenerationEnabled,
            global::System.DateTimeOffset? lastTodoAnalysisAt,
            string? pinnedFramePath,
            global::System.Collections.Generic.IList<global::Dust.PrivateProjectVariant2FrameTab>? frameTabs,
            global::System.Collections.Generic.IList<string>? tabsOrder,
            bool? isAdminControlled)
        {
            this.GroupIds = groupIds;
            this.IsRestricted = isRestricted;
            this.Description = description;
            this.IsMember = isMember;
            this.ArchivedAt = archivedAt;
            this.TodoGenerationEnabled = todoGenerationEnabled;
            this.LastTodoAnalysisAt = lastTodoAnalysisAt;
            this.PinnedFramePath = pinnedFramePath;
            this.FrameTabs = frameTabs;
            this.TabsOrder = tabsOrder;
            this.IsAdminControlled = isAdminControlled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProjectVariant2" /> class.
        /// </summary>
        public PrivateProjectVariant2()
        {
        }

    }
}