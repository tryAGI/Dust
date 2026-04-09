
#nullable enable

namespace Dust
{
    /// <summary>
    /// The OpenAPI specification for the Dust.tt API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IDustClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Agent configurations.
        /// </summary>
        public AgentsClient Agents { get; }

        /// <summary>
        /// Dust apps.
        /// </summary>
        public AppsClient Apps { get; }

        /// <summary>
        /// Conversations.
        /// </summary>
        public ConversationsClient Conversations { get; }

        /// <summary>
        /// Data source views.
        /// </summary>
        public DatasourceViewsClient DatasourceViews { get; }

        /// <summary>
        /// Data sources.
        /// </summary>
        public DatasourcesClient Datasources { get; }

        /// <summary>
        /// Message feedbacks.
        /// </summary>
        public FeedbacksClient Feedbacks { get; }

        /// <summary>
        /// MCP servers.
        /// </summary>
        public McpClient Mcp { get; }

        /// <summary>
        /// Mentions.
        /// </summary>
        public MentionsClient Mentions { get; }

        /// <summary>
        /// Private API - Agent configurations.
        /// </summary>
        public PrivateAgentsClient PrivateAgents { get; }

        /// <summary>
        /// Private API - Authentication (WorkOS).
        /// </summary>
        public PrivateAuthenticationClient PrivateAuthentication { get; }

        /// <summary>
        /// Private API - Conversations.
        /// </summary>
        public PrivateConversationsClient PrivateConversations { get; }

        /// <summary>
        /// Private API - SSE event streams.
        /// </summary>
        public PrivateEventsClient PrivateEvents { get; }

        /// <summary>
        /// Private API - Extension configuration.
        /// </summary>
        public PrivateExtensionClient PrivateExtension { get; }

        /// <summary>
        /// Private API - File uploads.
        /// </summary>
        public PrivateFilesClient PrivateFiles { get; }

        /// <summary>
        /// Private API - Mention suggestions.
        /// </summary>
        public PrivateMentionsClient PrivateMentions { get; }

        /// <summary>
        /// Private API - Messages.
        /// </summary>
        public PrivateMessagesClient PrivateMessages { get; }

        /// <summary>
        /// Private API - Spaces and data source views.
        /// </summary>
        public PrivateSpacesClient PrivateSpaces { get; }

        /// <summary>
        /// Private API - User.
        /// </summary>
        public PrivateUserClient PrivateUser { get; }

        /// <summary>
        /// Private API - Workspace settings.
        /// </summary>
        public PrivateWorkspaceClient PrivateWorkspace { get; }

        /// <summary>
        /// Search.
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        /// Spaces.
        /// </summary>
        public SpacesClient Spaces { get; }

        /// <summary>
        /// Tools.
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        /// Triggers.
        /// </summary>
        public TriggersClient Triggers { get; }

        /// <summary>
        /// Workspace.
        /// </summary>
        public WorkspaceClient Workspace { get; }

    }
}