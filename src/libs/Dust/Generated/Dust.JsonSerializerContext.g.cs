
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Dust
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Dust.JsonConverters.PrivateUserProviderJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateUserProviderNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateWorkspaceRoleJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateWorkspaceRoleNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateFullConversationVariant2VisibilityJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateFullConversationVariant2VisibilityNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateUserMessageTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateUserMessageTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateUserMessageVisibilityJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateUserMessageVisibilityNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageVisibilityJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageVisibilityNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageStatusJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentMessageTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentMessageTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentMessageVisibilityJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentMessageVisibilityNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentMessageStatusJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentMessageStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentMessageActivityStepTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentMessageActivityStepTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateContentFragmentTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateContentFragmentTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateContentFragmentVisibilityJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateContentFragmentVisibilityNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateContentFragmentContentFragmentVersionJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateContentFragmentContentFragmentVersionNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateContentFragmentContentFragmentTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateContentFragmentContentFragmentTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateContentFragmentExpiredReasonJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateContentFragmentExpiredReasonNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateCompactionMessageTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateCompactionMessageTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateCompactionMessageVisibilityJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateCompactionMessageVisibilityNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateCompactionMessageStatusJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateCompactionMessageStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentConfigurationStatusJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentConfigurationStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentConfigurationScopeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentConfigurationScopeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentConfigurationModelReasoningEffortJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateLightAgentConfigurationModelReasoningEffortNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateFileWithUploadUrlStatusJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateFileWithUploadUrlStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateFileWithUploadUrlUseCaseJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateFileWithUploadUrlUseCaseNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateSpaceKindJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateSpaceKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateSpaceManagementModeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateSpaceManagementModeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateDataSourceViewCategoryJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateDataSourceViewCategoryNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateDataSourceViewKindJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateDataSourceViewKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateMentionSuggestionTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateMentionSuggestionTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateFeedbackThumbDirectionJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateFeedbackThumbDirectionNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateMentionTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateMentionTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateRichMentionWithStatusTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateRichMentionWithStatusTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateRichMentionWithStatusStatusJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateRichMentionWithStatusStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateUserMessageContextOriginJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateUserMessageContextOriginNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateUserMessageNewEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateUserMessageNewEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageNewEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageNewEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageDoneEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageDoneEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageDoneEventStatusJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageDoneEventStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateCompactionMessageNewEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateCompactionMessageNewEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateCompactionMessageDoneEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateCompactionMessageDoneEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateConversationTitleEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateConversationTitleEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateGenerationTokensEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateGenerationTokensEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateGenerationTokensEventClassificationJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateGenerationTokensEventClassificationNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolCallStartedEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolCallStartedEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentActionSuccessEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentActionSuccessEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMCPActionStatusJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMCPActionStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageSuccessEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageSuccessEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentErrorEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentErrorEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentGenerationCancelledEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentGenerationCancelledEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolErrorEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolErrorEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolParamsEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolParamsEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolApproveExecutionEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolApproveExecutionEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolNotificationEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolNotificationEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolPersonalAuthRequiredEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolPersonalAuthRequiredEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolFileAuthRequiredEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateToolFileAuthRequiredEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentContextPrunedEventTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentContextPrunedEventTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.ContextAgenticMessageDataTypeJsonConverter),

            typeof(global::Dust.JsonConverters.ContextAgenticMessageDataTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.RichMentionTypeJsonConverter),

            typeof(global::Dust.JsonConverters.RichMentionTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.SpaceKindJsonConverter),

            typeof(global::Dust.JsonConverters.SpaceKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.TableSchemaItemValueTypeJsonConverter),

            typeof(global::Dust.JsonConverters.TableSchemaItemValueTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.DatasourceViewCategoryJsonConverter),

            typeof(global::Dust.JsonConverters.DatasourceViewCategoryNullableJsonConverter),

            typeof(global::Dust.JsonConverters.DatasourceViewKindJsonConverter),

            typeof(global::Dust.JsonConverters.DatasourceViewKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewServerTypeJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewServerTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewServerAuthorizationSupportedUseCaseJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewServerAuthorizationSupportedUseCaseNullableJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewOAuthUseCaseJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewOAuthUseCaseNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestAgentScopeJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestAgentScopeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestTagKindJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestTagKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestToolsetItemTypeJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestToolsetItemTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestAgentScopeJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestAgentScopeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestTagKindJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestTagKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestToolsetItemTypeJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestToolsetItemTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirectionJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirectionNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWSpacesDataSourcesTablesRowsRequestRowValueTypeJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWSpacesDataSourcesTablesRowsRequestRowValueTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantConversationsCancelRequestActionJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantConversationsCancelRequestActionNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWAssistantConversationsRequestVariant4AccessModeJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWAssistantConversationsRequestVariant4AccessModeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2JsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2NullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantConversationsRequestVisibilityJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAssistantConversationsRequestVisibilityNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWFilesRequestUseCaseJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWFilesRequestUseCaseNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWSpacesProjectNotificationPreferencesRequestPreferenceJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWSpacesProjectNotificationPreferencesRequestPreferenceNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWSpacesRequestSpaceKindJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWSpacesRequestSpaceKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWSpacesRequestManagementModeJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWSpacesRequestManagementModeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWorkosAuthenticateRequestGrantTypeJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWorkosAuthenticateRequestGrantTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAnalyticsExportTableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAnalyticsExportTableNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAnalyticsExportFormatJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAnalyticsExportFormatNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsViewJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsViewNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthorsJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthorsNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsVariantJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsVariantNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantConversationsMentionsSuggestionsSelectItemJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantConversationsMentionsSuggestionsSelectItemNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectItemJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectItemNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSearchViewTypeJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSearchViewTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWWorkspaceUsageModeJsonConverter),

            typeof(global::Dust.JsonConverters.GetWWorkspaceUsageModeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWWorkspaceUsageFormatJsonConverter),

            typeof(global::Dust.JsonConverters.GetWWorkspaceUsageFormatNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWWorkspaceUsageTableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWWorkspaceUsageTableNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsView2JsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsView2NullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithUsageJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithUsageNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthors2JsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthors2NullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithFeedbacksJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithFeedbacksNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithEditorsJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithEditorsNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsCurrentJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsCurrentNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWFilesVersionJsonConverter),

            typeof(global::Dust.JsonConverters.GetWFilesVersionNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWFilesActionJsonConverter),

            typeof(global::Dust.JsonConverters.GetWFilesActionNullableJsonConverter),

            typeof(global::Dust.JsonConverters.DeleteWSpacesDataSourceViewsForceJsonConverter),

            typeof(global::Dust.JsonConverters.DeleteWSpacesDataSourceViewsForceNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSpacesDataSourceViewsCategoryJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSpacesDataSourceViewsCategoryNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSpacesDataSourceViewsWithDetailsJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSpacesDataSourceViewsWithDetailsNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSpacesDataSourceViewsIncludeEditedByJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSpacesDataSourceViewsIncludeEditedByNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSpacesIncludeAllMembersJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSpacesIncludeAllMembersNullableJsonConverter),

            typeof(global::Dust.JsonConverters.DeleteWSpacesForceJsonConverter),

            typeof(global::Dust.JsonConverters.DeleteWSpacesForceNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirectionJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirectionNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantConversationsMessagesActionsResponseMessageStatusJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantConversationsMessagesActionsResponseMessageStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceJsonConverter),

            typeof(global::Dust.JsonConverters.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceNullableJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateFullConversationJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateProjectJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateConversationEventJsonConverter),

            typeof(global::Dust.JsonConverters.PrivateAgentMessageEventJsonConverter),

            typeof(global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>),

            typeof(global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PatchWSpacesDataSourceViewsRequestVariant1, global::Dust.PatchWSpacesDataSourceViewsRequestVariant2>),

            typeof(global::Dust.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValue2>),

            typeof(global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2, global::Dust.PatchWAssistantConversationsRequestVariant3, global::Dust.PatchWAssistantConversationsRequestVariant4>),

            typeof(global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>),

            typeof(global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>),

            typeof(global::Dust.JsonConverters.AllOfJsonConverter<global::Dust.PrivateSpace, global::Dust.GetWSpacesResponseSpace>),

            typeof(global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateSpace, global::Dust.PrivateProject?>),

            typeof(global::Dust.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserProvider), TypeInfoPropertyName = "PrivateUserProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWorkspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWorkspaceRole), TypeInfoPropertyName = "PrivateWorkspaceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFullConversation), TypeInfoPropertyName = "PrivateFullConversation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFullConversationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFullConversationVariant2Visibility), TypeInfoPropertyName = "PrivateFullConversationVariant2Visibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>), TypeInfoPropertyName = "OneOfPrivateUserMessagePrivateAgentMessagePrivateContentFragmentPrivateCompactionMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageType), TypeInfoPropertyName = "PrivateUserMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageVisibility), TypeInfoPropertyName = "PrivateUserMessageVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateMention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateRichMentionWithStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateRichMentionWithStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateReaction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateReaction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageType), TypeInfoPropertyName = "PrivateAgentMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageVisibility), TypeInfoPropertyName = "PrivateAgentMessageVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageStatus), TypeInfoPropertyName = "PrivateAgentMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateAgentMessageContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageType), TypeInfoPropertyName = "PrivateLightAgentMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageVisibility), TypeInfoPropertyName = "PrivateLightAgentMessageVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageStatus), TypeInfoPropertyName = "PrivateLightAgentMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dust.PrivateCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentMessageGeneratedFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageGeneratedFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentMessageActivityStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageActivityStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageActivityStepType), TypeInfoPropertyName = "PrivateLightAgentMessageActivityStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragmentType), TypeInfoPropertyName = "PrivateContentFragmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragmentVisibility), TypeInfoPropertyName = "PrivateContentFragmentVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragmentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragmentContentFragmentVersion), TypeInfoPropertyName = "PrivateContentFragmentContentFragmentVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragmentContentFragmentType), TypeInfoPropertyName = "PrivateContentFragmentContentFragmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragmentExpiredReason), TypeInfoPropertyName = "PrivateContentFragmentExpiredReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageType), TypeInfoPropertyName = "PrivateCompactionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageVisibility), TypeInfoPropertyName = "PrivateCompactionMessageVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageStatus), TypeInfoPropertyName = "PrivateCompactionMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationStatus), TypeInfoPropertyName = "PrivateLightAgentConfigurationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationScope), TypeInfoPropertyName = "PrivateLightAgentConfigurationScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationModelReasoningEffort), TypeInfoPropertyName = "PrivateLightAgentConfigurationModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfigurationTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfigurationEditor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationEditor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationFeedbacks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFileWithUploadUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFileWithUploadUrlStatus), TypeInfoPropertyName = "PrivateFileWithUploadUrlStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFileWithUploadUrlUseCase), TypeInfoPropertyName = "PrivateFileWithUploadUrlUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSpace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSpaceKind), TypeInfoPropertyName = "PrivateSpaceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSpaceManagementMode), TypeInfoPropertyName = "PrivateSpaceManagementMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateProject), TypeInfoPropertyName = "PrivateProject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateProjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceViewCategory), TypeInfoPropertyName = "PrivateDataSourceViewCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceViewKind), TypeInfoPropertyName = "PrivateDataSourceViewKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceViewEditedByUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateMentionSuggestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateMentionSuggestionType), TypeInfoPropertyName = "PrivateMentionSuggestionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFeatureFlags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateExtensionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFeedbackThumbDirection), TypeInfoPropertyName = "PrivateFeedbackThumbDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateMentionType), TypeInfoPropertyName = "PrivateMentionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateRichMentionWithStatusType), TypeInfoPropertyName = "PrivateRichMentionWithStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateRichMentionWithStatusStatus), TypeInfoPropertyName = "PrivateRichMentionWithStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageContextOrigin), TypeInfoPropertyName = "PrivateUserMessageContextOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateReactionUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateReactionUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationEvent), TypeInfoPropertyName = "PrivateConversationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageNewEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageNewEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageNewEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationTitleEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageNewEventType), TypeInfoPropertyName = "PrivateUserMessageNewEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageNewEventType), TypeInfoPropertyName = "PrivateAgentMessageNewEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageDoneEventType), TypeInfoPropertyName = "PrivateAgentMessageDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageDoneEventStatus), TypeInfoPropertyName = "PrivateAgentMessageDoneEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageNewEventType), TypeInfoPropertyName = "PrivateCompactionMessageNewEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageDoneEventType), TypeInfoPropertyName = "PrivateCompactionMessageDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationTitleEventType), TypeInfoPropertyName = "PrivateConversationTitleEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageEvent), TypeInfoPropertyName = "PrivateAgentMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateGenerationTokensEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolCallStartedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentActionSuccessEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageSuccessEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentGenerationCancelledEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolParamsEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolApproveExecutionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolNotificationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolPersonalAuthRequiredEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolFileAuthRequiredEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentContextPrunedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateGenerationTokensEventType), TypeInfoPropertyName = "PrivateGenerationTokensEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateGenerationTokensEventClassification), TypeInfoPropertyName = "PrivateGenerationTokensEventClassification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolCallStartedEventType), TypeInfoPropertyName = "PrivateToolCallStartedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentActionSuccessEventType), TypeInfoPropertyName = "PrivateAgentActionSuccessEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMCPAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMCPActionStatus), TypeInfoPropertyName = "PrivateAgentMCPActionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMCPActionDisplayLabels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateAgentMCPActionGeneratedFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMCPActionGeneratedFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageSuccessEventType), TypeInfoPropertyName = "PrivateAgentMessageSuccessEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentErrorEventType), TypeInfoPropertyName = "PrivateAgentErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentErrorEventError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentGenerationCancelledEventType), TypeInfoPropertyName = "PrivateAgentGenerationCancelledEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolErrorEventType), TypeInfoPropertyName = "PrivateToolErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolErrorEventError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolParamsEventType), TypeInfoPropertyName = "PrivateToolParamsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolApproveExecutionEventType), TypeInfoPropertyName = "PrivateToolApproveExecutionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolNotificationEventType), TypeInfoPropertyName = "PrivateToolNotificationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolPersonalAuthRequiredEventType), TypeInfoPropertyName = "PrivateToolPersonalAuthRequiredEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolPersonalAuthRequiredEventAuthError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolFileAuthRequiredEventType), TypeInfoPropertyName = "PrivateToolFileAuthRequiredEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolFileAuthRequiredEventFileAuthError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentContextPrunedEventType), TypeInfoPropertyName = "PrivateAgentContextPrunedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Section))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Section>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Workspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ContextAgenticMessageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ContextAgenticMessageDataType), TypeInfoPropertyName = "ContextAgenticMessageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Conversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1ContentItemItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Mention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Mention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemRawContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1ContentItemItemRawContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.RichMention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.RichMentionType), TypeInfoPropertyName = "RichMentionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ContentFragment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Space))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SpaceKind), TypeInfoPropertyName = "SpaceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Datasource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Table))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.TableSchemaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.TableSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.TableSchemaItemValueType), TypeInfoPropertyName = "TableSchemaItemValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DatasourceView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DatasourceViewCategory), TypeInfoPropertyName = "DatasourceViewCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DatasourceViewEditedByUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DatasourceViewKind), TypeInfoPropertyName = "DatasourceViewKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Run))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.RunStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.RunTraceItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.RunTraceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.RunTraceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerType), TypeInfoPropertyName = "MCPServerViewServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerAuthorization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase), TypeInfoPropertyName = "MCPServerViewServerAuthorizationSupportedUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewOAuthUseCase), TypeInfoPropertyName = "MCPServerViewOAuthUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewEditedByUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope), TypeInfoPropertyName = "PatchWAssistantAgentConfigurationsRequestAgentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestGenerationSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind), TypeInfoPropertyName = "PatchWAssistantAgentConfigurationsRequestTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestEditor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestEditor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType), TypeInfoPropertyName = "PatchWAssistantAgentConfigurationsRequestToolsetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope), TypeInfoPropertyName = "CreateWAssistantAgentConfigurationsImportRequestAgentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestGenerationSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind), TypeInfoPropertyName = "CreateWAssistantAgentConfigurationsImportRequestTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestEditor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestEditor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType), TypeInfoPropertyName = "CreateWAssistantAgentConfigurationsImportRequestToolsetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesEditRequestMention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection), TypeInfoPropertyName = "CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesValidateActionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ContentFragment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantMentionsParseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWMcpHeartbeatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWMcpRegisterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWMcpResultsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSearchToolsUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesAppsRunsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesAppsRunsRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesAppsRunsRequestConfigModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PatchWSpacesDataSourceViewsRequestVariant1, global::Dust.PatchWSpacesDataSourceViewsRequestVariant2>), TypeInfoPropertyName = "OneOfPatchWSpacesDataSourceViewsRequestVariant1PatchWSpacesDataSourceViewsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesDataSourceViewsRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesDataSourceViewsRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourcesDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourcesDocumentsParentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourcesTablesRowsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<string, double?, bool?, global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValue2>), TypeInfoPropertyName = "OneOfStringDoubleBooleanCreateWSpacesDataSourcesTablesRowsRequestRowValue22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValue2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValueType), TypeInfoPropertyName = "CreateWSpacesDataSourcesTablesRowsRequestRowValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourcesTablesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelRequestAction), TypeInfoPropertyName = "CreateWAssistantConversationsCancelRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCompactionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCompactionsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsContentFragmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsContentFragmentRequestContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2, global::Dust.PatchWAssistantConversationsRequestVariant3, global::Dust.PatchWAssistantConversationsRequestVariant4>), TypeInfoPropertyName = "PatchWAssistantConversationsRequestVariant4_462926e2d55e1e51")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant4AccessMode), TypeInfoPropertyName = "PatchWAssistantConversationsRequestVariant4AccessMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesEditRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2), TypeInfoPropertyName = "CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesRequestContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequestVisibility), TypeInfoPropertyName = "CreateWAssistantConversationsRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequestMessageContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesRequest3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesRequestUseCase), TypeInfoPropertyName = "CreateWFilesRequestUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesDataSourceViewsRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourceViewsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWSpacesRequestContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesRequestContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesRequestPreference), TypeInfoPropertyName = "PatchWSpacesProjectNotificationPreferencesRequestPreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesRequestSpaceKind), TypeInfoPropertyName = "CreateWSpacesRequestSpaceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesRequestManagementMode), TypeInfoPropertyName = "CreateWSpacesRequestManagementMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWorkosAuthenticateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWorkosAuthenticateRequestGrantType), TypeInfoPropertyName = "CreateWorkosAuthenticateRequestGrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWorkosRevokeSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAnalyticsExportTable), TypeInfoPropertyName = "GetWAnalyticsExportTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAnalyticsExportFormat), TypeInfoPropertyName = "GetWAnalyticsExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsView), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsView2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsWithAuthors2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsVariant), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem), TypeInfoPropertyName = "GetWAssistantConversationsMentionsSuggestionsSelectItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWAssistantMentionsSuggestionsSelectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantMentionsSuggestionsSelectItem), TypeInfoPropertyName = "GetWAssistantMentionsSuggestionsSelectItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSearchViewType), TypeInfoPropertyName = "GetWSearchViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWWorkspaceUsageMode), TypeInfoPropertyName = "GetWWorkspaceUsageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWWorkspaceUsageFormat), TypeInfoPropertyName = "GetWWorkspaceUsageFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWWorkspaceUsageTable), TypeInfoPropertyName = "GetWWorkspaceUsageTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsView2), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsView22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithUsage), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsWithUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors2), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsWithAuthors22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithFeedbacks), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsWithFeedbacks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithEditors), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsWithEditors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantMentionsSuggestionsSelect), TypeInfoPropertyName = "GetWAssistantMentionsSuggestionsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantMentionsSuggestionsCurrent), TypeInfoPropertyName = "GetWAssistantMentionsSuggestionsCurrent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWFilesVersion), TypeInfoPropertyName = "GetWFilesVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWFilesAction), TypeInfoPropertyName = "GetWFilesAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWSpacesDataSourceViewsForce), TypeInfoPropertyName = "DeleteWSpacesDataSourceViewsForce2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourceViewsCategory), TypeInfoPropertyName = "GetWSpacesDataSourceViewsCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourceViewsWithDetails), TypeInfoPropertyName = "GetWSpacesDataSourceViewsWithDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourceViewsIncludeEditedBy), TypeInfoPropertyName = "GetWSpacesDataSourceViewsIncludeEditedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesIncludeAllMembers), TypeInfoPropertyName = "GetWSpacesIncludeAllMembers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWSpacesForce), TypeInfoPropertyName = "DeleteWSpacesForce2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.AgentConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsFeedbacksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsFeedbacksResponseFeedback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsFeedbacksResponseFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection), TypeInfoPropertyName = "GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMentionsSuggestionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.RichMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMessagesEventsResponseEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesEventsResponseEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWAssistantConversationsMessagesFeedbacksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesValidateActionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantMentionsParseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantMentionsSuggestionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesResponseFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWMcpHeartbeatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWMcpRegisterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWMcpRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesAppsRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesAppsRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesAppsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWSpacesAppsResponseApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesAppsResponseApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourceViewsSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWSpacesDataSourceViewsSearchResponseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourceViewsSearchResponseDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourceViewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.DatasourceView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourcesCheckUpsertQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourcesDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourcesDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWSpacesDataSourcesDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWSpacesDataSourcesDocumentsResponseDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourcesDocumentsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourcesSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWSpacesDataSourcesSearchResponseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourcesSearchResponseDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Datasource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Table>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesMcpServerViewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.MCPServerView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Space>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCompactionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsContentFragmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsFeedbacksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateFeedback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesActionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesActionsResponseMessageStatus), TypeInfoPropertyName = "GetWAssistantConversationsMessagesActionsResponseMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesEditResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWAssistantConversationsMessagesFeedbacksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>), TypeInfoPropertyName = "OneOfPrivateUserMessagePrivateAgentMessagePrivateContentFragment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWAssistantConversationsMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesRetryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>), TypeInfoPropertyName = "OneOfPrivateUserMessagePrivateLightAgentMessagePrivateContentFragment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateContentFragment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateAgentMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsParticipantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsParticipantsResponseParticipants))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantMentionsSuggestionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateMentionSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourceViewsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesDataSourceViewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourceViewsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourceViewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWSpacesResponseSpace>), TypeInfoPropertyName = "AllOfPrivateSpaceGetWSpacesResponseSpace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesResponseSpace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dust.GetWSpacesResponseSpaceCategories2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesResponseSpaceCategories2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesResponseSpaceCategoriesUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWSpacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesProjectNotificationPreferencesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference), TypeInfoPropertyName = "GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference), TypeInfoPropertyName = "PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateSpace, global::Dust.PrivateProject?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PrivateSpace, global::Dust.PrivateProject?>), TypeInfoPropertyName = "OneOfPrivateSpacePrivateProject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWorkosAuthenticateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWorkosRevokeSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateRichMentionWithStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateReaction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateAgentMessageContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateLightAgentMessageGeneratedFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateLightAgentMessageActivityStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateLightAgentConfigurationTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateLightAgentConfigurationEditor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateReactionUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateAgentMCPActionGeneratedFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Section>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Mention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemRawContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.TableSchemaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dust.RunTraceItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.RunTraceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.MCPServerViewServerTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestEditor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportRequestEditor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ContentFragment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWSpacesRequestContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantMentionsSuggestionsSelectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.AgentConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsFeedbacksResponseFeedback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.RichMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsMessagesEventsResponseEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWSpacesAppsResponseApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWSpacesDataSourceViewsSearchResponseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.DatasourceView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWSpacesDataSourcesSearchResponseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Datasource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Table>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.MCPServerView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Space>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateLightAgentConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateFeedback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateContentFragment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateAgentMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateMentionSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateDataSourceView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.OneOf<global::Dust.PrivateSpace, global::Dust.PrivateProject?>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}