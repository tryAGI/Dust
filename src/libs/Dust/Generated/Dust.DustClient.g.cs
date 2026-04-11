
#nullable enable

namespace Dust
{
    /// <summary>
    /// The OpenAPI specification for the Dust.tt API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class DustClient : global::Dust.IDustClient, global::System.IDisposable
    {
        /// <summary>
        /// Dust.tt API (us-central1)
        /// </summary>
        public const string DefaultBaseUrl = "https://dust.tt/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => ResolveDisplayedBaseUri();

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Dust.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::Dust.AutoSDKClientOptions Options { get; }


        internal global::Dust.AutoSDKServerConfiguration AutoSDKServerConfiguration { get; set; } = new global::Dust.AutoSDKServerConfiguration();
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Dust.SourceGenerationContext.Default;


        /// <summary>
        /// Agent configurations.
        /// </summary>
        public AgentsClient Agents => new AgentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Dust apps.
        /// </summary>
        public AppsClient Apps => new AppsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Conversations.
        /// </summary>
        public ConversationsClient Conversations => new ConversationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Data source views.
        /// </summary>
        public DatasourceViewsClient DatasourceViews => new DatasourceViewsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Data sources.
        /// </summary>
        public DatasourcesClient Datasources => new DatasourcesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Message feedbacks.
        /// </summary>
        public FeedbacksClient Feedbacks => new FeedbacksClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// MCP servers.
        /// </summary>
        public McpClient Mcp => new McpClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Mentions.
        /// </summary>
        public MentionsClient Mentions => new MentionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private API - Agent configurations.
        /// </summary>
        public PrivateAgentsClient PrivateAgents => new PrivateAgentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private API - Authentication (WorkOS).
        /// </summary>
        public PrivateAuthenticationClient PrivateAuthentication => new PrivateAuthenticationClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private API - Conversations.
        /// </summary>
        public PrivateConversationsClient PrivateConversations => new PrivateConversationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private API - SSE event streams.
        /// </summary>
        public PrivateEventsClient PrivateEvents => new PrivateEventsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private API - Extension configuration.
        /// </summary>
        public PrivateExtensionClient PrivateExtension => new PrivateExtensionClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private API - File uploads.
        /// </summary>
        public PrivateFilesClient PrivateFiles => new PrivateFilesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private API - Mention suggestions.
        /// </summary>
        public PrivateMentionsClient PrivateMentions => new PrivateMentionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private API - Messages.
        /// </summary>
        public PrivateMessagesClient PrivateMessages => new PrivateMessagesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private API - Spaces and data source views.
        /// </summary>
        public PrivateSpacesClient PrivateSpaces => new PrivateSpacesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private API - User.
        /// </summary>
        public PrivateUserClient PrivateUser => new PrivateUserClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Private API - Workspace settings.
        /// </summary>
        public PrivateWorkspaceClient PrivateWorkspace => new PrivateWorkspaceClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Search.
        /// </summary>
        public SearchClient Search => new SearchClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Spaces.
        /// </summary>
        public SpacesClient Spaces => new SpacesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Tools.
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Triggers.
        /// </summary>
        public TriggersClient Triggers => new TriggersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Workspace.
        /// </summary>
        public WorkspaceClient Workspace => new WorkspaceClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };


        private static readonly global::Dust.AutoSDKServer[] s_availableServers = new global::Dust.AutoSDKServer[]
        {            new global::Dust.AutoSDKServer(
                id: "https-dust-tt",
                name: "Dust.tt API (us-central1)",
                url: "https://dust.tt/",
                description: "Dust.tt API (us-central1)"),
            new global::Dust.AutoSDKServer(
                id: "https-eu-dust-tt",
                name: "Dust.tt API (europe-west1)",
                url: "https://eu.dust.tt/",
                description: "Dust.tt API (europe-west1)"),
        };

        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::Dust.AutoSDKServer> AvailableServers => s_availableServers;

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::Dust.AutoSDKServer? SelectedServer
        {
            get => ResolveSelectedServer();
            set => SelectServer(value);
        }

        /// <summary>
        /// Creates a new instance of the DustClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public DustClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Dust.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the DustClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public DustClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Dust.EndPointAuthorization>? authorizations = null,
            global::Dust.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Dust.EndPointAuthorization>();
            Options = options ?? new global::Dust.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            AutoSDKServerConfiguration.ExplicitBaseUri = baseUri ?? httpClient?.BaseAddress;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);


        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId)
        {
            if (string.IsNullOrWhiteSpace(serverId))
            {
                return false;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, serverId, global::System.StringComparison.OrdinalIgnoreCase))
                {
                    AutoSDKServerConfiguration.SelectedServer = server;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer()
        {
            AutoSDKServerConfiguration.SelectedServer = null;
        }

        private global::Dust.AutoSDKServer? ResolveSelectedServer()
        {
            var selectedServer = AutoSDKServerConfiguration.SelectedServer;
            if (selectedServer is null)
            {
                return null;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                {
                    return server;
                }
            }

            return null;
        }

        private void SelectServer(global::Dust.AutoSDKServer? server)
        {
            if (server is null)
            {
                AutoSDKServerConfiguration.SelectedServer = null;
                return;
            }

            foreach (var candidate in s_availableServers)
            {
                if (string.Equals(candidate.Id, server.Id, global::System.StringComparison.Ordinal))
                {
                    AutoSDKServerConfiguration.SelectedServer = candidate;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return;
                }
            }

            throw new global::System.ArgumentException("The provided server is not available for this client.", nameof(server));
        }

        private global::System.Uri? ResolveDisplayedBaseUri()
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            return ResolveSelectedServer()?.Uri ?? HttpClient.BaseAddress;
        }

        private global::System.Uri? ResolveBaseUri(
            global::Dust.AutoSDKServer[] servers,
            string defaultBaseUrl)
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            if (AutoSDKServerConfiguration.SelectedServer is global::Dust.AutoSDKServer selectedServer)
            {
                foreach (var server in servers)
                {
                    if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                    {
                        return server.Uri;
                    }
                }
            }

            if (servers.Length > 0)
            {
                return servers[0].Uri;
            }

            return string.IsNullOrWhiteSpace(defaultBaseUrl)
                ? HttpClient.BaseAddress
                : new global::System.Uri(defaultBaseUrl, global::System.UriKind.RelativeOrAbsolute);
        }
    }
}