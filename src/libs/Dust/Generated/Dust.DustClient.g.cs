
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
        public const string DefaultBaseUrl = "https://dust.tt";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Dust.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Dust.JsonConverters.PrivateUserProviderJsonConverter(),
                    new global::Dust.JsonConverters.PrivateUserProviderNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateWorkspaceRoleJsonConverter(),
                    new global::Dust.JsonConverters.PrivateWorkspaceRoleNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateFullConversationVariant2VisibilityJsonConverter(),
                    new global::Dust.JsonConverters.PrivateFullConversationVariant2VisibilityNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateUserMessageTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateUserMessageTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateUserMessageVisibilityJsonConverter(),
                    new global::Dust.JsonConverters.PrivateUserMessageVisibilityNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageVisibilityJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageVisibilityNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageStatusJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageStatusNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentMessageTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentMessageTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentMessageVisibilityJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentMessageVisibilityNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentMessageStatusJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentMessageStatusNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentMessageActivityStepTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentMessageActivityStepTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateContentFragmentTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateContentFragmentTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateContentFragmentVisibilityJsonConverter(),
                    new global::Dust.JsonConverters.PrivateContentFragmentVisibilityNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateContentFragmentContentFragmentVersionJsonConverter(),
                    new global::Dust.JsonConverters.PrivateContentFragmentContentFragmentVersionNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateContentFragmentContentFragmentTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateContentFragmentContentFragmentTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateContentFragmentExpiredReasonJsonConverter(),
                    new global::Dust.JsonConverters.PrivateContentFragmentExpiredReasonNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentConfigurationStatusJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentConfigurationStatusNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentConfigurationScopeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentConfigurationScopeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentConfigurationModelReasoningEffortJsonConverter(),
                    new global::Dust.JsonConverters.PrivateLightAgentConfigurationModelReasoningEffortNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateFileWithUploadUrlStatusJsonConverter(),
                    new global::Dust.JsonConverters.PrivateFileWithUploadUrlStatusNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateFileWithUploadUrlUseCaseJsonConverter(),
                    new global::Dust.JsonConverters.PrivateFileWithUploadUrlUseCaseNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateSpaceKindJsonConverter(),
                    new global::Dust.JsonConverters.PrivateSpaceKindNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateSpaceManagementModeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateSpaceManagementModeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateDataSourceViewCategoryJsonConverter(),
                    new global::Dust.JsonConverters.PrivateDataSourceViewCategoryNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateDataSourceViewKindJsonConverter(),
                    new global::Dust.JsonConverters.PrivateDataSourceViewKindNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateMentionSuggestionTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateMentionSuggestionTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateFeedbackThumbDirectionJsonConverter(),
                    new global::Dust.JsonConverters.PrivateFeedbackThumbDirectionNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateMentionTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateMentionTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateRichMentionWithStatusTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateRichMentionWithStatusTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateRichMentionWithStatusStatusJsonConverter(),
                    new global::Dust.JsonConverters.PrivateRichMentionWithStatusStatusNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateUserMessageContextOriginJsonConverter(),
                    new global::Dust.JsonConverters.PrivateUserMessageContextOriginNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateUserMessageNewEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateUserMessageNewEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageNewEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageNewEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageDoneEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageDoneEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageDoneEventStatusJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageDoneEventStatusNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateConversationTitleEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateConversationTitleEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateButlerSuggestionCreatedEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateButlerSuggestionCreatedEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateButlerThinkingEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateButlerThinkingEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateButlerDoneEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateButlerDoneEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateGenerationTokensEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateGenerationTokensEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateGenerationTokensEventClassificationJsonConverter(),
                    new global::Dust.JsonConverters.PrivateGenerationTokensEventClassificationNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentActionSuccessEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentActionSuccessEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageSuccessEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageSuccessEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentErrorEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentErrorEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentGenerationCancelledEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentGenerationCancelledEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolErrorEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolErrorEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolParamsEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolParamsEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolApproveExecutionEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolApproveExecutionEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolNotificationEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolNotificationEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolPersonalAuthRequiredEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolPersonalAuthRequiredEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolFileAuthRequiredEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateToolFileAuthRequiredEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentContextPrunedEventTypeJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentContextPrunedEventTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.ContextAgenticMessageDataTypeJsonConverter(),
                    new global::Dust.JsonConverters.ContextAgenticMessageDataTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.RichMentionTypeJsonConverter(),
                    new global::Dust.JsonConverters.RichMentionTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.SpaceKindJsonConverter(),
                    new global::Dust.JsonConverters.SpaceKindNullableJsonConverter(),
                    new global::Dust.JsonConverters.TableSchemaItemValueTypeJsonConverter(),
                    new global::Dust.JsonConverters.TableSchemaItemValueTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.DatasourceViewCategoryJsonConverter(),
                    new global::Dust.JsonConverters.DatasourceViewCategoryNullableJsonConverter(),
                    new global::Dust.JsonConverters.DatasourceViewKindJsonConverter(),
                    new global::Dust.JsonConverters.DatasourceViewKindNullableJsonConverter(),
                    new global::Dust.JsonConverters.MCPServerViewServerTypeJsonConverter(),
                    new global::Dust.JsonConverters.MCPServerViewServerTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.MCPServerViewServerAuthorizationSupportedUseCaseJsonConverter(),
                    new global::Dust.JsonConverters.MCPServerViewServerAuthorizationSupportedUseCaseNullableJsonConverter(),
                    new global::Dust.JsonConverters.MCPServerViewOAuthUseCaseJsonConverter(),
                    new global::Dust.JsonConverters.MCPServerViewOAuthUseCaseNullableJsonConverter(),
                    new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestAgentScopeJsonConverter(),
                    new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestAgentScopeNullableJsonConverter(),
                    new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestTagKindJsonConverter(),
                    new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestTagKindNullableJsonConverter(),
                    new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestToolsetItemTypeJsonConverter(),
                    new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestToolsetItemTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestAgentScopeJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestAgentScopeNullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestTagKindJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestTagKindNullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestToolsetItemTypeJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestToolsetItemTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirectionJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirectionNullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWSpacesDataSourcesTablesRowsRequestRowValueTypeJsonConverter(),
                    new global::Dust.JsonConverters.CreateWSpacesDataSourcesTablesRowsRequestRowValueTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantConversationsCancelRequestActionJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantConversationsCancelRequestActionNullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2JsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2NullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantConversationsRequestVisibilityJsonConverter(),
                    new global::Dust.JsonConverters.CreateWAssistantConversationsRequestVisibilityNullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWFilesRequestUseCaseJsonConverter(),
                    new global::Dust.JsonConverters.CreateWFilesRequestUseCaseNullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWSpacesRequestSpaceKindJsonConverter(),
                    new global::Dust.JsonConverters.CreateWSpacesRequestSpaceKindNullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWSpacesRequestManagementModeJsonConverter(),
                    new global::Dust.JsonConverters.CreateWSpacesRequestManagementModeNullableJsonConverter(),
                    new global::Dust.JsonConverters.CreateWorkosAuthenticateRequestGrantTypeJsonConverter(),
                    new global::Dust.JsonConverters.CreateWorkosAuthenticateRequestGrantTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsViewJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsViewNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthorsJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthorsNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsVariantJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsVariantNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantConversationsMentionsSuggestionsSelectItemJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantConversationsMentionsSuggestionsSelectItemNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectItemJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectItemNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWSearchViewTypeJsonConverter(),
                    new global::Dust.JsonConverters.GetWSearchViewTypeNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWWorkspaceUsageModeJsonConverter(),
                    new global::Dust.JsonConverters.GetWWorkspaceUsageModeNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWWorkspaceUsageFormatJsonConverter(),
                    new global::Dust.JsonConverters.GetWWorkspaceUsageFormatNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWWorkspaceUsageTableJsonConverter(),
                    new global::Dust.JsonConverters.GetWWorkspaceUsageTableNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsView2JsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsView2NullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithUsageJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithUsageNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthors2JsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthors2NullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithFeedbacksJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithFeedbacksNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithEditorsJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithEditorsNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsCurrentJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsCurrentNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWFilesVersionJsonConverter(),
                    new global::Dust.JsonConverters.GetWFilesVersionNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWFilesActionJsonConverter(),
                    new global::Dust.JsonConverters.GetWFilesActionNullableJsonConverter(),
                    new global::Dust.JsonConverters.DeleteWSpacesDataSourceViewsForceJsonConverter(),
                    new global::Dust.JsonConverters.DeleteWSpacesDataSourceViewsForceNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWSpacesDataSourceViewsCategoryJsonConverter(),
                    new global::Dust.JsonConverters.GetWSpacesDataSourceViewsCategoryNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWSpacesDataSourceViewsWithDetailsJsonConverter(),
                    new global::Dust.JsonConverters.GetWSpacesDataSourceViewsWithDetailsNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWSpacesDataSourceViewsIncludeEditedByJsonConverter(),
                    new global::Dust.JsonConverters.GetWSpacesDataSourceViewsIncludeEditedByNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWSpacesIncludeAllMembersJsonConverter(),
                    new global::Dust.JsonConverters.GetWSpacesIncludeAllMembersNullableJsonConverter(),
                    new global::Dust.JsonConverters.DeleteWSpacesForceJsonConverter(),
                    new global::Dust.JsonConverters.DeleteWSpacesForceNullableJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirectionJsonConverter(),
                    new global::Dust.JsonConverters.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirectionNullableJsonConverter(),
                    new global::Dust.JsonConverters.PrivateFullConversationJsonConverter(),
                    new global::Dust.JsonConverters.PrivateProjectJsonConverter(),
                    new global::Dust.JsonConverters.PrivateConversationEventJsonConverter(),
                    new global::Dust.JsonConverters.PrivateAgentMessageEventJsonConverter(),
                    new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>(),
                    new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PatchWSpacesDataSourceViewsRequestVariant1, global::Dust.PatchWSpacesDataSourceViewsRequestVariant2>(),
                    new global::Dust.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValue2>(),
                    new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2, global::Dust.PatchWAssistantConversationsRequestVariant3>(),
                    new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>(),
                    new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>(),
                    new global::Dust.JsonConverters.AllOfJsonConverter<global::Dust.PrivateSpace, global::Dust.GetWSpacesResponseSpace>(),
                    new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateSpace, global::Dust.PrivateProject?>(),
                    new global::Dust.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Agent configurations
        /// </summary>
        public AgentsClient Agents => new AgentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Dust apps
        /// </summary>
        public AppsClient Apps => new AppsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Conversations
        /// </summary>
        public ConversationsClient Conversations => new ConversationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Data source views
        /// </summary>
        public DatasourceViewsClient DatasourceViews => new DatasourceViewsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Data sources
        /// </summary>
        public DatasourcesClient Datasources => new DatasourcesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Message feedbacks
        /// </summary>
        public FeedbacksClient Feedbacks => new FeedbacksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// MCP servers
        /// </summary>
        public McpClient Mcp => new McpClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Mentions
        /// </summary>
        public MentionsClient Mentions => new MentionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private API - Agent configurations
        /// </summary>
        public PrivateAgentsClient PrivateAgents => new PrivateAgentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private API - Authentication (WorkOS)
        /// </summary>
        public PrivateAuthenticationClient PrivateAuthentication => new PrivateAuthenticationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private API - Conversations
        /// </summary>
        public PrivateConversationsClient PrivateConversations => new PrivateConversationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private API - SSE event streams
        /// </summary>
        public PrivateEventsClient PrivateEvents => new PrivateEventsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private API - Extension configuration
        /// </summary>
        public PrivateExtensionClient PrivateExtension => new PrivateExtensionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private API - File uploads
        /// </summary>
        public PrivateFilesClient PrivateFiles => new PrivateFilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private API - Mention suggestions
        /// </summary>
        public PrivateMentionsClient PrivateMentions => new PrivateMentionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private API - Messages
        /// </summary>
        public PrivateMessagesClient PrivateMessages => new PrivateMessagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private API - Spaces and data source views
        /// </summary>
        public PrivateSpacesClient PrivateSpaces => new PrivateSpacesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private API - User
        /// </summary>
        public PrivateUserClient PrivateUser => new PrivateUserClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Private API - Workspace settings
        /// </summary>
        public PrivateWorkspaceClient PrivateWorkspace => new PrivateWorkspaceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Search
        /// </summary>
        public SearchClient Search => new SearchClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Spaces
        /// </summary>
        public SpacesClient Spaces => new SpacesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Tools
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Triggers
        /// </summary>
        public TriggersClient Triggers => new TriggersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Workspace
        /// </summary>
        public WorkspaceClient Workspace => new WorkspaceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

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
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Dust.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

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
    }
}