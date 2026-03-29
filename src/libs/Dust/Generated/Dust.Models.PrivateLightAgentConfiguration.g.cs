
#nullable enable

namespace Dust
{
    /// <summary>
    /// Agent configuration as returned by the private list endpoint.
    /// </summary>
    public sealed partial class PrivateLightAgentConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionCreatedAt")]
        public string? VersionCreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionAuthorId")]
        public int? VersionAuthorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PictureUrl { get; set; }

        /// <summary>
        /// Agent status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateLightAgentConfigurationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateLightAgentConfigurationStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dust.JsonConverters.PrivateLightAgentConfigurationScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateLightAgentConfigurationScope Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFavorite")]
        public bool? UserFavorite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dust.PrivateLightAgentConfigurationModel Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxStepsPerRun")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxStepsPerRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfigurationTag> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateId")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedGroupIds")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? RequestedGroupIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedSpaceIds")]
        public global::System.Collections.Generic.IList<string>? RequestedSpaceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canRead")]
        public bool? CanRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canEdit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Optional, returned when withAuthors query param is set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAuthors")]
        public global::System.Collections.Generic.IList<string>? LastAuthors { get; set; }

        /// <summary>
        /// Optional, returned when withEditors query param is set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editors")]
        public global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfigurationEditor>? Editors { get; set; }

        /// <summary>
        /// Optional, returned when withUsage query param is set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Dust.PrivateLightAgentConfigurationUsage? Usage { get; set; }

        /// <summary>
        /// Optional, returned when withFeedbacks query param is set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedbacks")]
        public global::Dust.PrivateLightAgentConfigurationFeedbacks? Feedbacks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentConfiguration" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sId"></param>
        /// <param name="version"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="pictureUrl"></param>
        /// <param name="status">
        /// Agent status
        /// </param>
        /// <param name="scope"></param>
        /// <param name="model"></param>
        /// <param name="maxStepsPerRun"></param>
        /// <param name="tags"></param>
        /// <param name="versionCreatedAt"></param>
        /// <param name="versionAuthorId"></param>
        /// <param name="instructions"></param>
        /// <param name="userFavorite"></param>
        /// <param name="templateId"></param>
        /// <param name="requestedGroupIds"></param>
        /// <param name="requestedSpaceIds"></param>
        /// <param name="canRead"></param>
        /// <param name="canEdit"></param>
        /// <param name="lastAuthors">
        /// Optional, returned when withAuthors query param is set
        /// </param>
        /// <param name="editors">
        /// Optional, returned when withEditors query param is set
        /// </param>
        /// <param name="usage">
        /// Optional, returned when withUsage query param is set
        /// </param>
        /// <param name="feedbacks">
        /// Optional, returned when withFeedbacks query param is set
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateLightAgentConfiguration(
            int id,
            string sId,
            int version,
            string name,
            string description,
            string pictureUrl,
            global::Dust.PrivateLightAgentConfigurationStatus status,
            global::Dust.PrivateLightAgentConfigurationScope scope,
            global::Dust.PrivateLightAgentConfigurationModel model,
            int maxStepsPerRun,
            global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfigurationTag> tags,
            string? versionCreatedAt,
            int? versionAuthorId,
            string? instructions,
            bool? userFavorite,
            string? templateId,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? requestedGroupIds,
            global::System.Collections.Generic.IList<string>? requestedSpaceIds,
            bool? canRead,
            bool? canEdit,
            global::System.Collections.Generic.IList<string>? lastAuthors,
            global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfigurationEditor>? editors,
            global::Dust.PrivateLightAgentConfigurationUsage? usage,
            global::Dust.PrivateLightAgentConfigurationFeedbacks? feedbacks)
        {
            this.Id = id;
            this.SId = sId ?? throw new global::System.ArgumentNullException(nameof(sId));
            this.Version = version;
            this.VersionCreatedAt = versionCreatedAt;
            this.VersionAuthorId = versionAuthorId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Instructions = instructions;
            this.PictureUrl = pictureUrl ?? throw new global::System.ArgumentNullException(nameof(pictureUrl));
            this.Status = status;
            this.Scope = scope;
            this.UserFavorite = userFavorite;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxStepsPerRun = maxStepsPerRun;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.TemplateId = templateId;
            this.RequestedGroupIds = requestedGroupIds;
            this.RequestedSpaceIds = requestedSpaceIds;
            this.CanRead = canRead;
            this.CanEdit = canEdit;
            this.LastAuthors = lastAuthors;
            this.Editors = editors;
            this.Usage = usage;
            this.Feedbacks = feedbacks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLightAgentConfiguration" /> class.
        /// </summary>
        public PrivateLightAgentConfiguration()
        {
        }
    }
}