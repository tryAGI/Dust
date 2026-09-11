
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
            typeof(global::Dust.JsonConverters.ContextAgenticMessageDataTypeJsonConverter),

            typeof(global::Dust.JsonConverters.ContextAgenticMessageDataTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.AgentConfigurationTagKindJsonConverter),

            typeof(global::Dust.JsonConverters.AgentConfigurationTagKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.RichMentionTypeJsonConverter),

            typeof(global::Dust.JsonConverters.RichMentionTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.ModelSelectionReasoningEffortJsonConverter),

            typeof(global::Dust.JsonConverters.ModelSelectionReasoningEffortNullableJsonConverter),

            typeof(global::Dust.JsonConverters.SpaceKindJsonConverter),

            typeof(global::Dust.JsonConverters.SpaceKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.TableSchemaItemValueTypeJsonConverter),

            typeof(global::Dust.JsonConverters.TableSchemaItemValueTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.DatasourceViewCategoryJsonConverter),

            typeof(global::Dust.JsonConverters.DatasourceViewCategoryNullableJsonConverter),

            typeof(global::Dust.JsonConverters.DatasourceViewKindJsonConverter),

            typeof(global::Dust.JsonConverters.DatasourceViewKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.SkillStatusJsonConverter),

            typeof(global::Dust.JsonConverters.SkillStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.SkillSourceJsonConverter),

            typeof(global::Dust.JsonConverters.SkillSourceNullableJsonConverter),

            typeof(global::Dust.JsonConverters.SkillReinforcementJsonConverter),

            typeof(global::Dust.JsonConverters.SkillReinforcementNullableJsonConverter),

            typeof(global::Dust.JsonConverters.SkillAvailabilityJsonConverter),

            typeof(global::Dust.JsonConverters.SkillAvailabilityNullableJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewServerTypeJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewServerTypeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewServerAuthorizationSupportedUseCaseJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewServerAuthorizationSupportedUseCaseNullableJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewOAuthUseCaseJsonConverter),

            typeof(global::Dust.JsonConverters.MCPServerViewOAuthUseCaseNullableJsonConverter),

            typeof(global::Dust.JsonConverters.TriggerKindJsonConverter),

            typeof(global::Dust.JsonConverters.TriggerKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.TriggerStatusJsonConverter),

            typeof(global::Dust.JsonConverters.TriggerStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.TriggerExecutionModeJsonConverter),

            typeof(global::Dust.JsonConverters.TriggerExecutionModeNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAnalyticsConsumptionExportRequestFormatJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWAnalyticsConsumptionExportRequestFormatNullableJsonConverter),

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

            typeof(global::Dust.JsonConverters.CreateWSkillsRequestOnConflictJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWSkillsRequestOnConflictNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWSkillsRequestAvailabilityJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWSkillsRequestAvailabilityNullableJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWSpacesDataSourcesTablesRowsRequestRowValueTypeJsonConverter),

            typeof(global::Dust.JsonConverters.CreateWSpacesDataSourcesTablesRowsRequestRowValueTypeNullableJsonConverter),

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

            typeof(global::Dust.JsonConverters.GetWSkillsStatusJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSkillsStatusNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSkillsAvailabilityItemJsonConverter),

            typeof(global::Dust.JsonConverters.GetWSkillsAvailabilityItemNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWTriggersKindJsonConverter),

            typeof(global::Dust.JsonConverters.GetWTriggersKindNullableJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirectionJsonConverter),

            typeof(global::Dust.JsonConverters.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirectionNullableJsonConverter),

            typeof(global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2>),

            typeof(global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PatchWSpacesDataSourceViewsRequestVariant1, global::Dust.PatchWSpacesDataSourceViewsRequestVariant2>),

            typeof(global::Dust.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValue2>),

            typeof(global::Dust.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Section))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Section>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Workspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ContextAgenticMessageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ContextAgenticMessageDataType), TypeInfoPropertyName = "ContextAgenticMessageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.AgentConfigurationTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AgentConfigurationTagKind), TypeInfoPropertyName = "AgentConfigurationTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Conversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1ContentItemItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Mention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Mention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1ContentItemItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemRawContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ConversationConversation1ContentItemItemRawContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.RichMention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.RichMentionType), TypeInfoPropertyName = "RichMentionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ModelSelection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ModelSelectionReasoningEffort), TypeInfoPropertyName = "ModelSelectionReasoningEffort2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillSourceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Skill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillStatus), TypeInfoPropertyName = "SkillStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillSource), TypeInfoPropertyName = "SkillSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillReinforcement), TypeInfoPropertyName = "SkillReinforcement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.SkillFileAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillFileAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillAvailability), TypeInfoPropertyName = "SkillAvailability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.MCPServerView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Run))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.RunStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.RunTraceItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.RunTraceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.RunTraceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerType), TypeInfoPropertyName = "MCPServerViewServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerAuthorization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase), TypeInfoPropertyName = "MCPServerViewServerAuthorizationSupportedUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewOAuthUseCase), TypeInfoPropertyName = "MCPServerViewOAuthUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewEditedByUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Trigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.TriggerKind), TypeInfoPropertyName = "TriggerKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.TriggerStatus), TypeInfoPropertyName = "TriggerStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.TriggerExecutionMode), TypeInfoPropertyName = "TriggerExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.TriggerWebhookSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAnalyticsConsumptionExportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAnalyticsConsumptionExportRequestFormat), TypeInfoPropertyName = "CreateWAnalyticsConsumptionExportRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAnalyticsConsumptionExportRequestFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope), TypeInfoPropertyName = "PatchWAssistantAgentConfigurationsRequestAgentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestGenerationSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind), TypeInfoPropertyName = "PatchWAssistantAgentConfigurationsRequestTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType), TypeInfoPropertyName = "PatchWAssistantAgentConfigurationsRequestToolsetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope), TypeInfoPropertyName = "CreateWAssistantAgentConfigurationsImportRequestAgentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestGenerationSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind), TypeInfoPropertyName = "CreateWAssistantAgentConfigurationsImportRequestTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType), TypeInfoPropertyName = "CreateWAssistantAgentConfigurationsImportRequestToolsetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2>), TypeInfoPropertyName = "OneOfPatchWAssistantConversationsRequestVariant1PatchWAssistantConversationsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesEditRequestMention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection), TypeInfoPropertyName = "CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesValidateActionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.ContentFragment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantMentionsParseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWMcpDeregisterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWMcpHeartbeatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWMcpRegisterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWMcpResultsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSearchToolsUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsRequestOnConflict), TypeInfoPropertyName = "CreateWSkillsRequestOnConflict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsRequestAvailability), TypeInfoPropertyName = "CreateWSkillsRequestAvailability2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAnalyticsExportTable), TypeInfoPropertyName = "GetWAnalyticsExportTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAnalyticsExportFormat), TypeInfoPropertyName = "GetWAnalyticsExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsView), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsWithAuthors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsVariant), TypeInfoPropertyName = "GetWAssistantAgentConfigurationsVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem), TypeInfoPropertyName = "GetWAssistantConversationsMentionsSuggestionsSelectItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWAssistantMentionsSuggestionsSelectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantMentionsSuggestionsSelectItem), TypeInfoPropertyName = "GetWAssistantMentionsSuggestionsSelectItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSearchViewType), TypeInfoPropertyName = "GetWSearchViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsStatus), TypeInfoPropertyName = "GetWSkillsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWSkillsAvailabilityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsAvailabilityItem), TypeInfoPropertyName = "GetWSkillsAvailabilityItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWTriggersKind), TypeInfoPropertyName = "GetWTriggersKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.AgentConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWAssistantAgentConfigurationsResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWSkillsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Skill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.CreateWSkillsResponseSkippedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsResponseSkippedItem))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourcesTablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Table>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourcesTablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesMcpServerViewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Space>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWTriggersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWTriggersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Trigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Section>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.AgentSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.AgentConfigurationTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Mention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemRawContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.TableSchemaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.SkillFileAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.MCPServerView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dust.RunTraceItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.RunTraceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.MCPServerViewServerTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.ContentFragment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantMentionsSuggestionsSelectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWSkillsAvailabilityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.AgentConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsFeedbacksResponseFeedback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.RichMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsMessagesEventsResponseEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Skill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.CreateWSkillsResponseSkippedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWSpacesAppsResponseApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWSpacesDataSourceViewsSearchResponseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.DatasourceView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWSpacesDataSourcesSearchResponseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Datasource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Table>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Space>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Trigger>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}