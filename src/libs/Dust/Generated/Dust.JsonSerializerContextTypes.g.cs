
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Dust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Dust.Section? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Section>? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConsumption? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConsumptionDetails2? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationConsumptionToolDetails>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConsumptionToolDetails? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationConsumptionModelDetails>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConsumptionModelDetails? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationConsumptionAgentDetails>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConsumptionAgentDetails? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.User? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Workspace? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.WorkspaceRole? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.WorkspaceLocale? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Context? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ContextAgenticMessageData? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ContextAgenticMessageDataType? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.AgentConfiguration? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.AgentConfigurationModel? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.AgentSkill>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.AgentSkill? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.AgentConfigurationTag>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.AgentConfigurationTag? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.AgentConfigurationTagKind? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Conversation? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConversation1? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConversation1ContentItemItem? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Mention>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Mention? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemAction>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConversation1ContentItemItemAction? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemRawContent>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConversation1ContentItemItemRawContent? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharingChange? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharingChangeVariant1? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharingChangeVariant1Permission? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharingChangeVariant2? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharingChangeVariant2Permission? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharing? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharingOwner? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationSharingMember>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharingMember? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationSharingGroup>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharingGroup? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationSharingKey>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationSharingKey? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.RichMention? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.RichMentionType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Message? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ModelSelection? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ModelSelectionReasoningEffort? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ContentFragment? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Space? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SpaceKind? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Datasource? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Table? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.TableSchemaItem>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TableSchemaItem? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TableSchemaItemValueType? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DatasourceView? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DatasourceViewCategory? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DatasourceViewEditedByUser? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DatasourceViewKind? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillSourceMetadata? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Skill? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillStatus? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillSource? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillReinforcement? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.SkillFileAttachment>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillFileAttachment? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillAvailability? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.MCPServerView>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerView? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Run? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.RunStatus? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.RunTraceItem>>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.RunTraceItem>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.RunTraceItem? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Document? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewServerType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewServer? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewServerAuthorization? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewServerAuthorizationSupportedUseCase? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerTool>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewServerTool? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewOAuthUseCase? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewEditedByUser? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Trigger? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TriggerKind? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TriggerStatus? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TriggerExecutionMode? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TriggerWebhookSource? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAnalyticsConsumptionExportRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAnalyticsConsumptionExportRequestFormat? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAnalyticsConsumptionExportRequestFilter? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequest? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestAgent? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestGenerationSettings? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestTag? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestSkill>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestSkill? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemConfiguration? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequest? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgent? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestGenerationSettings? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsCancelRequest? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsRequestVariant1? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsRequestVariant2? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequest? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesEditRequest? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesEditRequestMention? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequest? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesValidateActionRequest? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsSharingRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationSharingChange>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ContentFragment>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsRequestSharedWithItemVariant1? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsRequestSharedWithItemVariant2? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantMentionsParseRequest? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWFilesRequest? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpDeregisterRequest? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpHeartbeatRequest? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpRegisterRequest? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpResultsRequest? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSearchRequest? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSearchToolsUploadRequest? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSkillsRequest? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSkillsRequestOnConflict? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSkillsRequestAvailability? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesAppsRunsRequest? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesAppsRunsRequestConfig? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesAppsRunsRequestConfigModel? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.OneOf<global::Dust.PatchWSpacesDataSourceViewsRequestVariant1, global::Dust.PatchWSpacesDataSourceViewsRequestVariant2>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesDataSourceViewsRequestVariant1? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesDataSourceViewsRequestVariant2? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesDocumentsRequest? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesDocumentsParentsRequest? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesRowsRequest? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRow>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRow? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.OneOf<string, double?, bool?, global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValue2>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValue2? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValueType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesRequest? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAnalyticsExportTable? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAnalyticsExportFormat? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsView? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsWithAuthors? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsVariant? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantMentionsSuggestionsSelectItem>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantMentionsSuggestionsSelectItem? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSearchViewType? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSkillsStatus? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWSkillsAvailabilityItem>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSkillsAvailabilityItem? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWTriggersKind? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsResponse? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.AgentConfiguration>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsResponse2? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsResponse? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWAssistantAgentConfigurationsResponse? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportResponse? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsSearchResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsCancelResponse? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsEventsResponse? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsFeedbacksResponse? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsFeedbacksResponseFeedback>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsFeedbacksResponseFeedback? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsResponse? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMentionsSuggestionsResponse? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.RichMention>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionResponse? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesEditResponse? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMessagesEventsResponse? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesFeedbacksResponse? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWAssistantConversationsMessagesFeedbacksResponse? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesValidateActionResponse? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsSharingResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsSharingResponse? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantMentionsParseResponse? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantMentionsSuggestionsResponse? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWFilesResponse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWFilesResponseFile? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpHeartbeatResponse? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpRegisterResponse? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWMcpRequestsResponse? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWSkillsResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSkillsResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Skill>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSkillsResponse? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWSkillsResponseSkippedItem>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSkillsResponseSkippedItem? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesAppsRunsResponse? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesAppsRunsResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesAppsResponse? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWSpacesAppsResponseApp>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesAppsResponseApp? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourceViewsSearchResponse? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWSpacesDataSourceViewsSearchResponseDocument>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourceViewsSearchResponseDocument? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourceViewsResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.DatasourceView>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesCheckUpsertQueueResponse? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesDocumentsResponse? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesDocumentsResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWSpacesDataSourcesDocumentsResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWSpacesDataSourcesDocumentsResponseDocument? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesDocumentsResponse2? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Document>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesSearchResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWSpacesDataSourcesSearchResponseDocument>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesSearchResponseDocument? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Datasource>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesTablesResponse? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Table>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesResponse? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesResponse? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesMcpServerViewsResponse? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesResponse? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Space>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWTriggersResponse? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWTriggersResponse2? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Trigger>? Type263 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Section>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationConsumptionToolDetails>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationConsumptionModelDetails>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationConsumptionAgentDetails>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.AgentSkill>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.AgentConfigurationTag>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItem>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItem>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Mention>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemAction>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemRawContent>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationSharingMember>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationSharingGroup>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationSharingKey>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.TableSchemaItem>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.SkillFileAttachment>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.MCPServerView>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dust.RunTraceItem>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.RunTraceItem>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.MCPServerViewServerTool>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestSkill>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationSharingChange>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ContentFragment>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRow>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWAssistantMentionsSuggestionsSelectItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWSkillsAvailabilityItem>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.AgentConfiguration>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsFeedbacksResponseFeedback>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.RichMention>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Skill>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWSkillsResponseSkippedItem>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWSpacesAppsResponseApp>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWSpacesDataSourceViewsSearchResponseDocument>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.DatasourceView>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Document>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWSpacesDataSourcesSearchResponseDocument>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Datasource>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Table>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Space>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Trigger>? ListType53 { get; set; }
    }
}