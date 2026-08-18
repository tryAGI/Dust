
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant12, global::Dust.PatchWAssistantConversationsRequestVariant22, global::Dust.PatchWAssistantConversationsRequestVariant3, global::Dust.PatchWAssistantConversationsRequestVariant4>), TypeInfoPropertyName = "PatchWAssistantConversationsRequestVariant4_c4fb3fa444308b4c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant12, global::Dust.PatchWAssistantConversationsRequestVariant22, global::Dust.PatchWAssistantConversationsRequestVariant3, global::Dust.PatchWAssistantConversationsRequestVariant4>?), TypeInfoPropertyName = "PatchWAssistantConversationsRequestVariant4_2edd0c100c08755a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConsumptionFacet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConsumptionFacetScope), TypeInfoPropertyName = "PrivateConsumptionFacetScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConsumptionFacetTier), TypeInfoPropertyName = "PrivateConsumptionFacetTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserProvider), TypeInfoPropertyName = "PrivateUserProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWorkspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWorkspaceRole), TypeInfoPropertyName = "PrivateWorkspaceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationConsumptionToolDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationConsumptionModelDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationConsumptionAgentDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionToolDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionModelDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationConsumptionDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionAgentDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationForkingData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationForkUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationForkUserProvider), TypeInfoPropertyName = "PrivateConversationForkUserProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationForkedFrom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationForkedFromFileCopyStatus), TypeInfoPropertyName = "PrivateConversationForkedFromFileCopyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationForkedChild))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateConversationForkedChild>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageResolvedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageModelResolutionMethod), TypeInfoPropertyName = "PrivateAgentMessageModelResolutionMethod2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageResolvedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageModelResolutionMethod), TypeInfoPropertyName = "PrivateLightAgentMessageModelResolutionMethod2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationModelReasoningEffort), TypeInfoPropertyName = "PrivateLightAgentConfigurationModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfigurationTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfigurationEditor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationEditor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationFeedbacks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetGoTemplateDraftResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetGoTemplateDraftResponseBodyAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetGoTemplateDraftResponseBodyAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetGoTemplateDraftResponseBodyAttachmentError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetGoTemplateDraftResponseBodyAttachmentError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFileWithUploadUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFileWithUploadUrlStatus), TypeInfoPropertyName = "PrivateFileWithUploadUrlStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFileWithUploadUrlUseCase), TypeInfoPropertyName = "PrivateFileWithUploadUrlUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSpace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSpaceKind), TypeInfoPropertyName = "PrivateSpaceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSpaceManagementMode), TypeInfoPropertyName = "PrivateSpaceManagementMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateProject), TypeInfoPropertyName = "PrivateProject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateProjectVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateProjectVariant2FrameTab>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateProjectVariant2FrameTab))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceViewCategory), TypeInfoPropertyName = "PrivateDataSourceViewCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceViewKind), TypeInfoPropertyName = "PrivateDataSourceViewKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceViewEditedByUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceViewUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceViewUsageAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceViewUsageAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceViewUsageSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceViewUsageSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateMentionSuggestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateMentionSuggestionType), TypeInfoPropertyName = "PrivateMentionSuggestionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFeatureFlags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateExtensionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFeedbackThumbDirection), TypeInfoPropertyName = "PrivateFeedbackThumbDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PrivateWakeUpScheduleConfigVariant1, global::Dust.PrivateWakeUpScheduleConfigVariant2>), TypeInfoPropertyName = "OneOfPrivateWakeUpScheduleConfigVariant1PrivateWakeUpScheduleConfigVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUpScheduleConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUpScheduleConfigVariant1Type), TypeInfoPropertyName = "PrivateWakeUpScheduleConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUpScheduleConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUpScheduleConfigVariant2Type), TypeInfoPropertyName = "PrivateWakeUpScheduleConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUpStatus), TypeInfoPropertyName = "PrivateWakeUpStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateMentionType), TypeInfoPropertyName = "PrivateMentionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateRichMentionWithStatusType), TypeInfoPropertyName = "PrivateRichMentionWithStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateRichMentionWithStatusStatus), TypeInfoPropertyName = "PrivateRichMentionWithStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageContextOrigin), TypeInfoPropertyName = "PrivateUserMessageContextOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateReactionUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateReactionUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationEvent), TypeInfoPropertyName = "PrivateConversationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageNewEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageNewEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageConsumptionUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageNewEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationForkPreparedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationTitleEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUpUpdatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationEventDiscriminatorType), TypeInfoPropertyName = "PrivateConversationEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageNewEventType), TypeInfoPropertyName = "PrivateUserMessageNewEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageNewEventType), TypeInfoPropertyName = "PrivateAgentMessageNewEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageDoneEventType), TypeInfoPropertyName = "PrivateAgentMessageDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageDoneEventStatus), TypeInfoPropertyName = "PrivateAgentMessageDoneEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageConsumptionUpdatedEventType), TypeInfoPropertyName = "PrivateAgentMessageConsumptionUpdatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageNewEventType), TypeInfoPropertyName = "PrivateCompactionMessageNewEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageDoneEventType), TypeInfoPropertyName = "PrivateCompactionMessageDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationForkPreparedEventType), TypeInfoPropertyName = "PrivateConversationForkPreparedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationTitleEventType), TypeInfoPropertyName = "PrivateConversationTitleEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUpUpdatedEventType), TypeInfoPropertyName = "PrivateWakeUpUpdatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationEvent), TypeInfoPropertyName = "PrivateSandboxFunctionInvocationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationEventDiscriminatorType), TypeInfoPropertyName = "PrivateSandboxFunctionInvocationEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventType), TypeInfoPropertyName = "PrivateSandboxFunctionInvocationCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus), TypeInfoPropertyName = "PrivateSandboxFunctionInvocationCreatedEventInvocationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationResultEventType), TypeInfoPropertyName = "PrivateSandboxFunctionInvocationResultEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationErrorEventType), TypeInfoPropertyName = "PrivateSandboxFunctionInvocationErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationErrorEventError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageEventDiscriminatorType), TypeInfoPropertyName = "PrivateAgentMessageEventDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.RunTraceItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.RunTraceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.RunTraceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.Document))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection), TypeInfoPropertyName = "CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAnalyticsConsumptionFacetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAnalyticsConsumptionFacetsRequestPeriod), TypeInfoPropertyName = "CreateWAnalyticsConsumptionFacetsRequestPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAnalyticsConsumptionFacetsRequestFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelRequestAction), TypeInfoPropertyName = "CreateWAssistantConversationsCancelRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCompactionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCompactionsRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsContentFragmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsContentFragmentRequestContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant4AccessMode), TypeInfoPropertyName = "PatchWAssistantConversationsRequestVariant4AccessMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesEditRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2), TypeInfoPropertyName = "CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesRequestContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesRequestModelSelection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsSelectedSpacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsSelectedSpacesRequestMode), TypeInfoPropertyName = "CreateWAssistantConversationsSelectedSpacesRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequestVisibility), TypeInfoPropertyName = "CreateWAssistantConversationsRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequestMessageContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequestMetadata))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsStatus), TypeInfoPropertyName = "GetWSkillsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWSkillsAvailabilityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsAvailabilityItem), TypeInfoPropertyName = "GetWSkillsAvailabilityItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWSpacesKindItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesKindItem), TypeInfoPropertyName = "GetWSpacesKindItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchUserResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Table>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesMcpServerViewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.Space>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAnalyticsConsumptionFacetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAnalyticsConsumptionFacetsResponsePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAnalyticsConsumptionFacetsResponseFacets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelResponse2))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant12, global::Dust.PatchWAssistantConversationsRequestVariant22, global::Dust.PatchWAssistantConversationsRequestVariant3, global::Dust.PatchWAssistantConversationsRequestVariant4>), TypeInfoPropertyName = "PatchWAssistantConversationsRequestVariant4_c4fb3fa444308b4c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant12, global::Dust.PatchWAssistantConversationsRequestVariant22, global::Dust.PatchWAssistantConversationsRequestVariant3, global::Dust.PatchWAssistantConversationsRequestVariant4>?), TypeInfoPropertyName = "PatchWAssistantConversationsRequestVariant4_2edd0c100c08755a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCompactionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsConsumptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsContentFragmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsFeedbacksResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateFeedback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesActionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesActionsResponseMessageStatus), TypeInfoPropertyName = "GetWAssistantConversationsMessagesActionsResponseMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesConsumptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetailsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetailsTool))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsSelectableSpacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace>), TypeInfoPropertyName = "AllOfPrivateSpaceGetWAssistantConversationsSelectableSpacesResponseSpace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsSelectedSpacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace>), TypeInfoPropertyName = "AllOfPrivateSpaceCreateWAssistantConversationsSelectedSpacesResponseSelectedSpace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsSelectedSpacesResponseEffectiveAcl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWAssistantConversationsWakeupsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsWakeupsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.PrivateWakeUp>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dust.GetWSpacesResponseSpaceFrameTab>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesResponseSpaceFrameTab))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConsumptionFacetScope?), TypeInfoPropertyName = "NullablePrivateConsumptionFacetScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConsumptionFacetTier?), TypeInfoPropertyName = "NullablePrivateConsumptionFacetTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserProvider?), TypeInfoPropertyName = "NullablePrivateUserProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWorkspaceRole?), TypeInfoPropertyName = "NullablePrivateWorkspaceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationForkUserProvider?), TypeInfoPropertyName = "NullablePrivateConversationForkUserProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationForkedFromFileCopyStatus?), TypeInfoPropertyName = "NullablePrivateConversationForkedFromFileCopyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFullConversation?), TypeInfoPropertyName = "NullablePrivateFullConversation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFullConversationVariant2Visibility?), TypeInfoPropertyName = "NullablePrivateFullConversationVariant2Visibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>?), TypeInfoPropertyName = "NullableOneOfPrivateUserMessagePrivateAgentMessagePrivateContentFragmentPrivateCompactionMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageType?), TypeInfoPropertyName = "NullablePrivateUserMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageVisibility?), TypeInfoPropertyName = "NullablePrivateUserMessageVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageType?), TypeInfoPropertyName = "NullablePrivateAgentMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageVisibility?), TypeInfoPropertyName = "NullablePrivateAgentMessageVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageStatus?), TypeInfoPropertyName = "NullablePrivateAgentMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageModelResolutionMethod?), TypeInfoPropertyName = "NullablePrivateAgentMessageModelResolutionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageType?), TypeInfoPropertyName = "NullablePrivateLightAgentMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageVisibility?), TypeInfoPropertyName = "NullablePrivateLightAgentMessageVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageStatus?), TypeInfoPropertyName = "NullablePrivateLightAgentMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageModelResolutionMethod?), TypeInfoPropertyName = "NullablePrivateLightAgentMessageModelResolutionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentMessageActivityStepType?), TypeInfoPropertyName = "NullablePrivateLightAgentMessageActivityStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragmentType?), TypeInfoPropertyName = "NullablePrivateContentFragmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragmentVisibility?), TypeInfoPropertyName = "NullablePrivateContentFragmentVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragmentContentFragmentVersion?), TypeInfoPropertyName = "NullablePrivateContentFragmentContentFragmentVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragmentContentFragmentType?), TypeInfoPropertyName = "NullablePrivateContentFragmentContentFragmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateContentFragmentExpiredReason?), TypeInfoPropertyName = "NullablePrivateContentFragmentExpiredReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageType?), TypeInfoPropertyName = "NullablePrivateCompactionMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageVisibility?), TypeInfoPropertyName = "NullablePrivateCompactionMessageVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageStatus?), TypeInfoPropertyName = "NullablePrivateCompactionMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationStatus?), TypeInfoPropertyName = "NullablePrivateLightAgentConfigurationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationScope?), TypeInfoPropertyName = "NullablePrivateLightAgentConfigurationScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateLightAgentConfigurationModelReasoningEffort?), TypeInfoPropertyName = "NullablePrivateLightAgentConfigurationModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFileWithUploadUrlStatus?), TypeInfoPropertyName = "NullablePrivateFileWithUploadUrlStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFileWithUploadUrlUseCase?), TypeInfoPropertyName = "NullablePrivateFileWithUploadUrlUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSpaceKind?), TypeInfoPropertyName = "NullablePrivateSpaceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSpaceManagementMode?), TypeInfoPropertyName = "NullablePrivateSpaceManagementMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateProject?), TypeInfoPropertyName = "NullablePrivateProject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceViewCategory?), TypeInfoPropertyName = "NullablePrivateDataSourceViewCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateDataSourceViewKind?), TypeInfoPropertyName = "NullablePrivateDataSourceViewKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateMentionSuggestionType?), TypeInfoPropertyName = "NullablePrivateMentionSuggestionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateFeedbackThumbDirection?), TypeInfoPropertyName = "NullablePrivateFeedbackThumbDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PrivateWakeUpScheduleConfigVariant1, global::Dust.PrivateWakeUpScheduleConfigVariant2>?), TypeInfoPropertyName = "NullableOneOfPrivateWakeUpScheduleConfigVariant1PrivateWakeUpScheduleConfigVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUpScheduleConfigVariant1Type?), TypeInfoPropertyName = "NullablePrivateWakeUpScheduleConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUpScheduleConfigVariant2Type?), TypeInfoPropertyName = "NullablePrivateWakeUpScheduleConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUpStatus?), TypeInfoPropertyName = "NullablePrivateWakeUpStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateMentionType?), TypeInfoPropertyName = "NullablePrivateMentionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateRichMentionWithStatusType?), TypeInfoPropertyName = "NullablePrivateRichMentionWithStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateRichMentionWithStatusStatus?), TypeInfoPropertyName = "NullablePrivateRichMentionWithStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageContextOrigin?), TypeInfoPropertyName = "NullablePrivateUserMessageContextOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationEvent?), TypeInfoPropertyName = "NullablePrivateConversationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationEventDiscriminatorType?), TypeInfoPropertyName = "NullablePrivateConversationEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateUserMessageNewEventType?), TypeInfoPropertyName = "NullablePrivateUserMessageNewEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageNewEventType?), TypeInfoPropertyName = "NullablePrivateAgentMessageNewEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageDoneEventType?), TypeInfoPropertyName = "NullablePrivateAgentMessageDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageDoneEventStatus?), TypeInfoPropertyName = "NullablePrivateAgentMessageDoneEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageConsumptionUpdatedEventType?), TypeInfoPropertyName = "NullablePrivateAgentMessageConsumptionUpdatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageNewEventType?), TypeInfoPropertyName = "NullablePrivateCompactionMessageNewEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateCompactionMessageDoneEventType?), TypeInfoPropertyName = "NullablePrivateCompactionMessageDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationForkPreparedEventType?), TypeInfoPropertyName = "NullablePrivateConversationForkPreparedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateConversationTitleEventType?), TypeInfoPropertyName = "NullablePrivateConversationTitleEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateWakeUpUpdatedEventType?), TypeInfoPropertyName = "NullablePrivateWakeUpUpdatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationEvent?), TypeInfoPropertyName = "NullablePrivateSandboxFunctionInvocationEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationEventDiscriminatorType?), TypeInfoPropertyName = "NullablePrivateSandboxFunctionInvocationEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventType?), TypeInfoPropertyName = "NullablePrivateSandboxFunctionInvocationCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus?), TypeInfoPropertyName = "NullablePrivateSandboxFunctionInvocationCreatedEventInvocationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationResultEventType?), TypeInfoPropertyName = "NullablePrivateSandboxFunctionInvocationResultEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateSandboxFunctionInvocationErrorEventType?), TypeInfoPropertyName = "NullablePrivateSandboxFunctionInvocationErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageEvent?), TypeInfoPropertyName = "NullablePrivateAgentMessageEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageEventDiscriminatorType?), TypeInfoPropertyName = "NullablePrivateAgentMessageEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateGenerationTokensEventType?), TypeInfoPropertyName = "NullablePrivateGenerationTokensEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateGenerationTokensEventClassification?), TypeInfoPropertyName = "NullablePrivateGenerationTokensEventClassification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolCallStartedEventType?), TypeInfoPropertyName = "NullablePrivateToolCallStartedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentActionSuccessEventType?), TypeInfoPropertyName = "NullablePrivateAgentActionSuccessEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMCPActionStatus?), TypeInfoPropertyName = "NullablePrivateAgentMCPActionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentMessageSuccessEventType?), TypeInfoPropertyName = "NullablePrivateAgentMessageSuccessEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentErrorEventType?), TypeInfoPropertyName = "NullablePrivateAgentErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentGenerationCancelledEventType?), TypeInfoPropertyName = "NullablePrivateAgentGenerationCancelledEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolErrorEventType?), TypeInfoPropertyName = "NullablePrivateToolErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolParamsEventType?), TypeInfoPropertyName = "NullablePrivateToolParamsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolApproveExecutionEventType?), TypeInfoPropertyName = "NullablePrivateToolApproveExecutionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolNotificationEventType?), TypeInfoPropertyName = "NullablePrivateToolNotificationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolPersonalAuthRequiredEventType?), TypeInfoPropertyName = "NullablePrivateToolPersonalAuthRequiredEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateToolFileAuthRequiredEventType?), TypeInfoPropertyName = "NullablePrivateToolFileAuthRequiredEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PrivateAgentContextPrunedEventType?), TypeInfoPropertyName = "NullablePrivateAgentContextPrunedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ContextAgenticMessageDataType?), TypeInfoPropertyName = "NullableContextAgenticMessageDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.RichMentionType?), TypeInfoPropertyName = "NullableRichMentionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.ModelSelectionReasoningEffort?), TypeInfoPropertyName = "NullableModelSelectionReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SpaceKind?), TypeInfoPropertyName = "NullableSpaceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.TableSchemaItemValueType?), TypeInfoPropertyName = "NullableTableSchemaItemValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DatasourceViewCategory?), TypeInfoPropertyName = "NullableDatasourceViewCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DatasourceViewKind?), TypeInfoPropertyName = "NullableDatasourceViewKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillStatus?), TypeInfoPropertyName = "NullableSkillStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillSource?), TypeInfoPropertyName = "NullableSkillSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillReinforcement?), TypeInfoPropertyName = "NullableSkillReinforcement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.SkillAvailability?), TypeInfoPropertyName = "NullableSkillAvailability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerType?), TypeInfoPropertyName = "NullableMCPServerViewServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase?), TypeInfoPropertyName = "NullableMCPServerViewServerAuthorizationSupportedUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.MCPServerViewOAuthUseCase?), TypeInfoPropertyName = "NullableMCPServerViewOAuthUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope?), TypeInfoPropertyName = "NullablePatchWAssistantAgentConfigurationsRequestAgentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind?), TypeInfoPropertyName = "NullablePatchWAssistantAgentConfigurationsRequestTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType?), TypeInfoPropertyName = "NullablePatchWAssistantAgentConfigurationsRequestToolsetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope?), TypeInfoPropertyName = "NullableCreateWAssistantAgentConfigurationsImportRequestAgentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind?), TypeInfoPropertyName = "NullableCreateWAssistantAgentConfigurationsImportRequestTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType?), TypeInfoPropertyName = "NullableCreateWAssistantAgentConfigurationsImportRequestToolsetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2>?), TypeInfoPropertyName = "NullableOneOfPatchWAssistantConversationsRequestVariant1PatchWAssistantConversationsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection?), TypeInfoPropertyName = "NullableCreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsRequestOnConflict?), TypeInfoPropertyName = "NullableCreateWSkillsRequestOnConflict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSkillsRequestAvailability?), TypeInfoPropertyName = "NullableCreateWSkillsRequestAvailability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PatchWSpacesDataSourceViewsRequestVariant1, global::Dust.PatchWSpacesDataSourceViewsRequestVariant2>?), TypeInfoPropertyName = "NullableOneOfPatchWSpacesDataSourceViewsRequestVariant1PatchWSpacesDataSourceViewsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<string, double?, bool?, global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValue2>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanCreateWSpacesDataSourcesTablesRowsRequestRowValue22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValueType?), TypeInfoPropertyName = "NullableCreateWSpacesDataSourcesTablesRowsRequestRowValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAnalyticsConsumptionFacetsRequestPeriod?), TypeInfoPropertyName = "NullableCreateWAnalyticsConsumptionFacetsRequestPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsCancelRequestAction?), TypeInfoPropertyName = "NullableCreateWAssistantConversationsCancelRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWAssistantConversationsRequestVariant4AccessMode?), TypeInfoPropertyName = "NullablePatchWAssistantConversationsRequestVariant4AccessMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2?), TypeInfoPropertyName = "NullableCreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsSelectedSpacesRequestMode?), TypeInfoPropertyName = "NullableCreateWAssistantConversationsSelectedSpacesRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWAssistantConversationsRequestVisibility?), TypeInfoPropertyName = "NullableCreateWAssistantConversationsRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWFilesRequestUseCase?), TypeInfoPropertyName = "NullableCreateWFilesRequestUseCase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesRequestPreference?), TypeInfoPropertyName = "NullablePatchWSpacesProjectNotificationPreferencesRequestPreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesRequestSpaceKind?), TypeInfoPropertyName = "NullableCreateWSpacesRequestSpaceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWSpacesRequestManagementMode?), TypeInfoPropertyName = "NullableCreateWSpacesRequestManagementMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.CreateWorkosAuthenticateRequestGrantType?), TypeInfoPropertyName = "NullableCreateWorkosAuthenticateRequestGrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAnalyticsExportTable?), TypeInfoPropertyName = "NullableGetWAnalyticsExportTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAnalyticsExportFormat?), TypeInfoPropertyName = "NullableGetWAnalyticsExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsView?), TypeInfoPropertyName = "NullableGetWAssistantAgentConfigurationsView2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors?), TypeInfoPropertyName = "NullableGetWAssistantAgentConfigurationsWithAuthors2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsVariant?), TypeInfoPropertyName = "NullableGetWAssistantAgentConfigurationsVariant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem?), TypeInfoPropertyName = "NullableGetWAssistantConversationsMentionsSuggestionsSelectItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantMentionsSuggestionsSelectItem?), TypeInfoPropertyName = "NullableGetWAssistantMentionsSuggestionsSelectItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSearchViewType?), TypeInfoPropertyName = "NullableGetWSearchViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsStatus?), TypeInfoPropertyName = "NullableGetWSkillsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSkillsAvailabilityItem?), TypeInfoPropertyName = "NullableGetWSkillsAvailabilityItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsView2?), TypeInfoPropertyName = "NullableGetWAssistantAgentConfigurationsView22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithUsage?), TypeInfoPropertyName = "NullableGetWAssistantAgentConfigurationsWithUsage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors2?), TypeInfoPropertyName = "NullableGetWAssistantAgentConfigurationsWithAuthors22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithFeedbacks?), TypeInfoPropertyName = "NullableGetWAssistantAgentConfigurationsWithFeedbacks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantAgentConfigurationsWithEditors?), TypeInfoPropertyName = "NullableGetWAssistantAgentConfigurationsWithEditors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantMentionsSuggestionsSelect?), TypeInfoPropertyName = "NullableGetWAssistantMentionsSuggestionsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantMentionsSuggestionsCurrent?), TypeInfoPropertyName = "NullableGetWAssistantMentionsSuggestionsCurrent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWFilesVersion?), TypeInfoPropertyName = "NullableGetWFilesVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWFilesAction?), TypeInfoPropertyName = "NullableGetWFilesAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWSpacesDataSourceViewsForce?), TypeInfoPropertyName = "NullableDeleteWSpacesDataSourceViewsForce2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourceViewsCategory?), TypeInfoPropertyName = "NullableGetWSpacesDataSourceViewsCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourceViewsWithDetails?), TypeInfoPropertyName = "NullableGetWSpacesDataSourceViewsWithDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesDataSourceViewsIncludeEditedBy?), TypeInfoPropertyName = "NullableGetWSpacesDataSourceViewsIncludeEditedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesIncludeAllMembers?), TypeInfoPropertyName = "NullableGetWSpacesIncludeAllMembers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.DeleteWSpacesForce?), TypeInfoPropertyName = "NullableDeleteWSpacesForce2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesKindItem?), TypeInfoPropertyName = "NullableGetWSpacesKindItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection?), TypeInfoPropertyName = "NullableGetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWAssistantConversationsMessagesActionsResponseMessageStatus?), TypeInfoPropertyName = "NullableGetWAssistantConversationsMessagesActionsResponseMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>?), TypeInfoPropertyName = "NullableOneOfPrivateUserMessagePrivateAgentMessagePrivateContentFragment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>?), TypeInfoPropertyName = "NullableOneOfPrivateUserMessagePrivateLightAgentMessagePrivateContentFragment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace>?), TypeInfoPropertyName = "NullableAllOfPrivateSpaceGetWAssistantConversationsSelectableSpacesResponseSpace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace>?), TypeInfoPropertyName = "NullableAllOfPrivateSpaceCreateWAssistantConversationsSelectedSpacesResponseSelectedSpace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWSpacesResponseSpace>?), TypeInfoPropertyName = "NullableAllOfPrivateSpaceGetWSpacesResponseSpace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference?), TypeInfoPropertyName = "NullableGetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference?), TypeInfoPropertyName = "NullablePatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dust.OneOf<global::Dust.PrivateSpace, global::Dust.PrivateProject?>?), TypeInfoPropertyName = "NullableOneOfPrivateSpacePrivateProject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateConversationConsumptionToolDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateConversationConsumptionModelDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateConversationConsumptionAgentDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateConversationForkedChild>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetGoTemplateDraftResponseBodyAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetGoTemplateDraftResponseBodyAttachmentError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateProjectVariant2FrameTab>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateDataSourceViewUsageAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateDataSourceViewUsageSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateReactionUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateAgentMCPActionGeneratedFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.Section>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PatchWSpacesRequestContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantMentionsSuggestionsSelectItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWSkillsAvailabilityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWSpacesKindItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateConsumptionFacet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateLightAgentConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateFeedback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetailsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateContentFragment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateAgentMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateWakeUp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateMentionSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.PrivateDataSourceView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.GetWSpacesResponseSpaceFrameTab>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dust.OneOf<global::Dust.PrivateSpace, global::Dust.PrivateProject?>>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Dust.JsonConverters.PrivateFullConversationJsonConverter());
            options.Converters.Add(new global::Dust.JsonConverters.PrivateProjectJsonConverter());
            options.Converters.Add(new global::Dust.JsonConverters.PrivateConversationEventJsonConverter());
            options.Converters.Add(new global::Dust.JsonConverters.PrivateSandboxFunctionInvocationEventJsonConverter());
            options.Converters.Add(new global::Dust.JsonConverters.PrivateAgentMessageEventJsonConverter());
            options.Converters.Add(new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>());
            options.Converters.Add(new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateWakeUpScheduleConfigVariant1, global::Dust.PrivateWakeUpScheduleConfigVariant2>());
            options.Converters.Add(new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2>());
            options.Converters.Add(new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PatchWSpacesDataSourceViewsRequestVariant1, global::Dust.PatchWSpacesDataSourceViewsRequestVariant2>());
            options.Converters.Add(new global::Dust.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValue2>());
            options.Converters.Add(new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PatchWAssistantConversationsRequestVariant12, global::Dust.PatchWAssistantConversationsRequestVariant22, global::Dust.PatchWAssistantConversationsRequestVariant3, global::Dust.PatchWAssistantConversationsRequestVariant4>());
            options.Converters.Add(new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>());
            options.Converters.Add(new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>());
            options.Converters.Add(new global::Dust.JsonConverters.AllOfJsonConverter<global::Dust.PrivateSpace, global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace>());
            options.Converters.Add(new global::Dust.JsonConverters.AllOfJsonConverter<global::Dust.PrivateSpace, global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace>());
            options.Converters.Add(new global::Dust.JsonConverters.AllOfJsonConverter<global::Dust.PrivateSpace, global::Dust.GetWSpacesResponseSpace>());
            options.Converters.Add(new global::Dust.JsonConverters.OneOfJsonConverter<global::Dust.PrivateSpace, global::Dust.PrivateProject?>());
            options.Converters.Add(new global::Dust.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Dust.PrivateConsumptionFacetScope)

                    || typeToConvert == typeof(global::Dust.PrivateConsumptionFacetScope?)

                    || typeToConvert == typeof(global::Dust.PrivateConsumptionFacetTier)

                    || typeToConvert == typeof(global::Dust.PrivateConsumptionFacetTier?)

                    || typeToConvert == typeof(global::Dust.PrivateUserProvider)

                    || typeToConvert == typeof(global::Dust.PrivateUserProvider?)

                    || typeToConvert == typeof(global::Dust.PrivateWorkspaceRole)

                    || typeToConvert == typeof(global::Dust.PrivateWorkspaceRole?)

                    || typeToConvert == typeof(global::Dust.PrivateConversationForkUserProvider)

                    || typeToConvert == typeof(global::Dust.PrivateConversationForkUserProvider?)

                    || typeToConvert == typeof(global::Dust.PrivateConversationForkedFromFileCopyStatus)

                    || typeToConvert == typeof(global::Dust.PrivateConversationForkedFromFileCopyStatus?)

                    || typeToConvert == typeof(global::Dust.PrivateFullConversationVariant2Visibility)

                    || typeToConvert == typeof(global::Dust.PrivateFullConversationVariant2Visibility?)

                    || typeToConvert == typeof(global::Dust.PrivateUserMessageType)

                    || typeToConvert == typeof(global::Dust.PrivateUserMessageType?)

                    || typeToConvert == typeof(global::Dust.PrivateUserMessageVisibility)

                    || typeToConvert == typeof(global::Dust.PrivateUserMessageVisibility?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageType)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageType?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageVisibility)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageVisibility?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageStatus)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageStatus?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageModelResolutionMethod)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageModelResolutionMethod?)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentMessageType)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentMessageType?)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentMessageVisibility)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentMessageVisibility?)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentMessageStatus)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentMessageStatus?)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentMessageModelResolutionMethod)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentMessageModelResolutionMethod?)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentMessageActivityStepType)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentMessageActivityStepType?)

                    || typeToConvert == typeof(global::Dust.PrivateContentFragmentType)

                    || typeToConvert == typeof(global::Dust.PrivateContentFragmentType?)

                    || typeToConvert == typeof(global::Dust.PrivateContentFragmentVisibility)

                    || typeToConvert == typeof(global::Dust.PrivateContentFragmentVisibility?)

                    || typeToConvert == typeof(global::Dust.PrivateContentFragmentContentFragmentVersion)

                    || typeToConvert == typeof(global::Dust.PrivateContentFragmentContentFragmentVersion?)

                    || typeToConvert == typeof(global::Dust.PrivateContentFragmentContentFragmentType)

                    || typeToConvert == typeof(global::Dust.PrivateContentFragmentContentFragmentType?)

                    || typeToConvert == typeof(global::Dust.PrivateContentFragmentExpiredReason)

                    || typeToConvert == typeof(global::Dust.PrivateContentFragmentExpiredReason?)

                    || typeToConvert == typeof(global::Dust.PrivateCompactionMessageType)

                    || typeToConvert == typeof(global::Dust.PrivateCompactionMessageType?)

                    || typeToConvert == typeof(global::Dust.PrivateCompactionMessageVisibility)

                    || typeToConvert == typeof(global::Dust.PrivateCompactionMessageVisibility?)

                    || typeToConvert == typeof(global::Dust.PrivateCompactionMessageStatus)

                    || typeToConvert == typeof(global::Dust.PrivateCompactionMessageStatus?)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationStatus)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationStatus?)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationScope)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationScope?)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationModelReasoningEffort)

                    || typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationModelReasoningEffort?)

                    || typeToConvert == typeof(global::Dust.PrivateFileWithUploadUrlStatus)

                    || typeToConvert == typeof(global::Dust.PrivateFileWithUploadUrlStatus?)

                    || typeToConvert == typeof(global::Dust.PrivateFileWithUploadUrlUseCase)

                    || typeToConvert == typeof(global::Dust.PrivateFileWithUploadUrlUseCase?)

                    || typeToConvert == typeof(global::Dust.PrivateSpaceKind)

                    || typeToConvert == typeof(global::Dust.PrivateSpaceKind?)

                    || typeToConvert == typeof(global::Dust.PrivateSpaceManagementMode)

                    || typeToConvert == typeof(global::Dust.PrivateSpaceManagementMode?)

                    || typeToConvert == typeof(global::Dust.PrivateDataSourceViewCategory)

                    || typeToConvert == typeof(global::Dust.PrivateDataSourceViewCategory?)

                    || typeToConvert == typeof(global::Dust.PrivateDataSourceViewKind)

                    || typeToConvert == typeof(global::Dust.PrivateDataSourceViewKind?)

                    || typeToConvert == typeof(global::Dust.PrivateMentionSuggestionType)

                    || typeToConvert == typeof(global::Dust.PrivateMentionSuggestionType?)

                    || typeToConvert == typeof(global::Dust.PrivateFeedbackThumbDirection)

                    || typeToConvert == typeof(global::Dust.PrivateFeedbackThumbDirection?)

                    || typeToConvert == typeof(global::Dust.PrivateWakeUpScheduleConfigVariant1Type)

                    || typeToConvert == typeof(global::Dust.PrivateWakeUpScheduleConfigVariant1Type?)

                    || typeToConvert == typeof(global::Dust.PrivateWakeUpScheduleConfigVariant2Type)

                    || typeToConvert == typeof(global::Dust.PrivateWakeUpScheduleConfigVariant2Type?)

                    || typeToConvert == typeof(global::Dust.PrivateWakeUpStatus)

                    || typeToConvert == typeof(global::Dust.PrivateWakeUpStatus?)

                    || typeToConvert == typeof(global::Dust.PrivateMentionType)

                    || typeToConvert == typeof(global::Dust.PrivateMentionType?)

                    || typeToConvert == typeof(global::Dust.PrivateRichMentionWithStatusType)

                    || typeToConvert == typeof(global::Dust.PrivateRichMentionWithStatusType?)

                    || typeToConvert == typeof(global::Dust.PrivateRichMentionWithStatusStatus)

                    || typeToConvert == typeof(global::Dust.PrivateRichMentionWithStatusStatus?)

                    || typeToConvert == typeof(global::Dust.PrivateUserMessageContextOrigin)

                    || typeToConvert == typeof(global::Dust.PrivateUserMessageContextOrigin?)

                    || typeToConvert == typeof(global::Dust.PrivateConversationEventDiscriminatorType)

                    || typeToConvert == typeof(global::Dust.PrivateConversationEventDiscriminatorType?)

                    || typeToConvert == typeof(global::Dust.PrivateUserMessageNewEventType)

                    || typeToConvert == typeof(global::Dust.PrivateUserMessageNewEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageNewEventType)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageNewEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageDoneEventType)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageDoneEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageDoneEventStatus)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageDoneEventStatus?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageConsumptionUpdatedEventType)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageConsumptionUpdatedEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateCompactionMessageNewEventType)

                    || typeToConvert == typeof(global::Dust.PrivateCompactionMessageNewEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateCompactionMessageDoneEventType)

                    || typeToConvert == typeof(global::Dust.PrivateCompactionMessageDoneEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateConversationForkPreparedEventType)

                    || typeToConvert == typeof(global::Dust.PrivateConversationForkPreparedEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateConversationTitleEventType)

                    || typeToConvert == typeof(global::Dust.PrivateConversationTitleEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateWakeUpUpdatedEventType)

                    || typeToConvert == typeof(global::Dust.PrivateWakeUpUpdatedEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationEventDiscriminatorType)

                    || typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationEventDiscriminatorType?)

                    || typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventType)

                    || typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus)

                    || typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus?)

                    || typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationResultEventType)

                    || typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationResultEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationErrorEventType)

                    || typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationErrorEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageEventDiscriminatorType)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageEventDiscriminatorType?)

                    || typeToConvert == typeof(global::Dust.PrivateGenerationTokensEventType)

                    || typeToConvert == typeof(global::Dust.PrivateGenerationTokensEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateGenerationTokensEventClassification)

                    || typeToConvert == typeof(global::Dust.PrivateGenerationTokensEventClassification?)

                    || typeToConvert == typeof(global::Dust.PrivateToolCallStartedEventType)

                    || typeToConvert == typeof(global::Dust.PrivateToolCallStartedEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentActionSuccessEventType)

                    || typeToConvert == typeof(global::Dust.PrivateAgentActionSuccessEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMCPActionStatus)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMCPActionStatus?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageSuccessEventType)

                    || typeToConvert == typeof(global::Dust.PrivateAgentMessageSuccessEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentErrorEventType)

                    || typeToConvert == typeof(global::Dust.PrivateAgentErrorEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentGenerationCancelledEventType)

                    || typeToConvert == typeof(global::Dust.PrivateAgentGenerationCancelledEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateToolErrorEventType)

                    || typeToConvert == typeof(global::Dust.PrivateToolErrorEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateToolParamsEventType)

                    || typeToConvert == typeof(global::Dust.PrivateToolParamsEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateToolApproveExecutionEventType)

                    || typeToConvert == typeof(global::Dust.PrivateToolApproveExecutionEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateToolNotificationEventType)

                    || typeToConvert == typeof(global::Dust.PrivateToolNotificationEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateToolPersonalAuthRequiredEventType)

                    || typeToConvert == typeof(global::Dust.PrivateToolPersonalAuthRequiredEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateToolFileAuthRequiredEventType)

                    || typeToConvert == typeof(global::Dust.PrivateToolFileAuthRequiredEventType?)

                    || typeToConvert == typeof(global::Dust.PrivateAgentContextPrunedEventType)

                    || typeToConvert == typeof(global::Dust.PrivateAgentContextPrunedEventType?)

                    || typeToConvert == typeof(global::Dust.ContextAgenticMessageDataType)

                    || typeToConvert == typeof(global::Dust.ContextAgenticMessageDataType?)

                    || typeToConvert == typeof(global::Dust.RichMentionType)

                    || typeToConvert == typeof(global::Dust.RichMentionType?)

                    || typeToConvert == typeof(global::Dust.ModelSelectionReasoningEffort)

                    || typeToConvert == typeof(global::Dust.ModelSelectionReasoningEffort?)

                    || typeToConvert == typeof(global::Dust.SpaceKind)

                    || typeToConvert == typeof(global::Dust.SpaceKind?)

                    || typeToConvert == typeof(global::Dust.TableSchemaItemValueType)

                    || typeToConvert == typeof(global::Dust.TableSchemaItemValueType?)

                    || typeToConvert == typeof(global::Dust.DatasourceViewCategory)

                    || typeToConvert == typeof(global::Dust.DatasourceViewCategory?)

                    || typeToConvert == typeof(global::Dust.DatasourceViewKind)

                    || typeToConvert == typeof(global::Dust.DatasourceViewKind?)

                    || typeToConvert == typeof(global::Dust.SkillStatus)

                    || typeToConvert == typeof(global::Dust.SkillStatus?)

                    || typeToConvert == typeof(global::Dust.SkillSource)

                    || typeToConvert == typeof(global::Dust.SkillSource?)

                    || typeToConvert == typeof(global::Dust.SkillReinforcement)

                    || typeToConvert == typeof(global::Dust.SkillReinforcement?)

                    || typeToConvert == typeof(global::Dust.SkillAvailability)

                    || typeToConvert == typeof(global::Dust.SkillAvailability?)

                    || typeToConvert == typeof(global::Dust.MCPServerViewServerType)

                    || typeToConvert == typeof(global::Dust.MCPServerViewServerType?)

                    || typeToConvert == typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase)

                    || typeToConvert == typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase?)

                    || typeToConvert == typeof(global::Dust.MCPServerViewOAuthUseCase)

                    || typeToConvert == typeof(global::Dust.MCPServerViewOAuthUseCase?)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope?)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind?)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType?)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope?)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind?)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType?)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection?)

                    || typeToConvert == typeof(global::Dust.CreateWSkillsRequestOnConflict)

                    || typeToConvert == typeof(global::Dust.CreateWSkillsRequestOnConflict?)

                    || typeToConvert == typeof(global::Dust.CreateWSkillsRequestAvailability)

                    || typeToConvert == typeof(global::Dust.CreateWSkillsRequestAvailability?)

                    || typeToConvert == typeof(global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValueType)

                    || typeToConvert == typeof(global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValueType?)

                    || typeToConvert == typeof(global::Dust.CreateWAnalyticsConsumptionFacetsRequestPeriod)

                    || typeToConvert == typeof(global::Dust.CreateWAnalyticsConsumptionFacetsRequestPeriod?)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantConversationsCancelRequestAction)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantConversationsCancelRequestAction?)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantConversationsRequestVariant4AccessMode)

                    || typeToConvert == typeof(global::Dust.PatchWAssistantConversationsRequestVariant4AccessMode?)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2?)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantConversationsSelectedSpacesRequestMode)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantConversationsSelectedSpacesRequestMode?)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantConversationsRequestVisibility)

                    || typeToConvert == typeof(global::Dust.CreateWAssistantConversationsRequestVisibility?)

                    || typeToConvert == typeof(global::Dust.CreateWFilesRequestUseCase)

                    || typeToConvert == typeof(global::Dust.CreateWFilesRequestUseCase?)

                    || typeToConvert == typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesRequestPreference)

                    || typeToConvert == typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesRequestPreference?)

                    || typeToConvert == typeof(global::Dust.CreateWSpacesRequestSpaceKind)

                    || typeToConvert == typeof(global::Dust.CreateWSpacesRequestSpaceKind?)

                    || typeToConvert == typeof(global::Dust.CreateWSpacesRequestManagementMode)

                    || typeToConvert == typeof(global::Dust.CreateWSpacesRequestManagementMode?)

                    || typeToConvert == typeof(global::Dust.CreateWorkosAuthenticateRequestGrantType)

                    || typeToConvert == typeof(global::Dust.CreateWorkosAuthenticateRequestGrantType?)

                    || typeToConvert == typeof(global::Dust.GetWAnalyticsExportTable)

                    || typeToConvert == typeof(global::Dust.GetWAnalyticsExportTable?)

                    || typeToConvert == typeof(global::Dust.GetWAnalyticsExportFormat)

                    || typeToConvert == typeof(global::Dust.GetWAnalyticsExportFormat?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsVariant)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsVariant?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem)

                    || typeToConvert == typeof(global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsSelectItem)

                    || typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsSelectItem?)

                    || typeToConvert == typeof(global::Dust.GetWSearchViewType)

                    || typeToConvert == typeof(global::Dust.GetWSearchViewType?)

                    || typeToConvert == typeof(global::Dust.GetWSkillsStatus)

                    || typeToConvert == typeof(global::Dust.GetWSkillsStatus?)

                    || typeToConvert == typeof(global::Dust.GetWSkillsAvailabilityItem)

                    || typeToConvert == typeof(global::Dust.GetWSkillsAvailabilityItem?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView2)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView2?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithUsage)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithUsage?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors2)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors2?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithFeedbacks)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithFeedbacks?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithEditors)

                    || typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithEditors?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsSelect)

                    || typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsSelect?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsCurrent)

                    || typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsCurrent?)

                    || typeToConvert == typeof(global::Dust.GetWFilesVersion)

                    || typeToConvert == typeof(global::Dust.GetWFilesVersion?)

                    || typeToConvert == typeof(global::Dust.GetWFilesAction)

                    || typeToConvert == typeof(global::Dust.GetWFilesAction?)

                    || typeToConvert == typeof(global::Dust.DeleteWSpacesDataSourceViewsForce)

                    || typeToConvert == typeof(global::Dust.DeleteWSpacesDataSourceViewsForce?)

                    || typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsCategory)

                    || typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsCategory?)

                    || typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsWithDetails)

                    || typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsWithDetails?)

                    || typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsIncludeEditedBy)

                    || typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsIncludeEditedBy?)

                    || typeToConvert == typeof(global::Dust.GetWSpacesIncludeAllMembers)

                    || typeToConvert == typeof(global::Dust.GetWSpacesIncludeAllMembers?)

                    || typeToConvert == typeof(global::Dust.DeleteWSpacesForce)

                    || typeToConvert == typeof(global::Dust.DeleteWSpacesForce?)

                    || typeToConvert == typeof(global::Dust.GetWSpacesKindItem)

                    || typeToConvert == typeof(global::Dust.GetWSpacesKindItem?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection)

                    || typeToConvert == typeof(global::Dust.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection?)

                    || typeToConvert == typeof(global::Dust.GetWAssistantConversationsMessagesActionsResponseMessageStatus)

                    || typeToConvert == typeof(global::Dust.GetWAssistantConversationsMessagesActionsResponseMessageStatus?)

                    || typeToConvert == typeof(global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference)

                    || typeToConvert == typeof(global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference?)

                    || typeToConvert == typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference)

                    || typeToConvert == typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dust.PrivateConsumptionFacetScope))
                {
                    return new global::Dust.JsonConverters.PrivateConsumptionFacetScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConsumptionFacetScope?))
                {
                    return new global::Dust.JsonConverters.PrivateConsumptionFacetScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConsumptionFacetTier))
                {
                    return new global::Dust.JsonConverters.PrivateConsumptionFacetTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConsumptionFacetTier?))
                {
                    return new global::Dust.JsonConverters.PrivateConsumptionFacetTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateUserProvider))
                {
                    return new global::Dust.JsonConverters.PrivateUserProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateUserProvider?))
                {
                    return new global::Dust.JsonConverters.PrivateUserProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateWorkspaceRole))
                {
                    return new global::Dust.JsonConverters.PrivateWorkspaceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateWorkspaceRole?))
                {
                    return new global::Dust.JsonConverters.PrivateWorkspaceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConversationForkUserProvider))
                {
                    return new global::Dust.JsonConverters.PrivateConversationForkUserProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConversationForkUserProvider?))
                {
                    return new global::Dust.JsonConverters.PrivateConversationForkUserProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConversationForkedFromFileCopyStatus))
                {
                    return new global::Dust.JsonConverters.PrivateConversationForkedFromFileCopyStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConversationForkedFromFileCopyStatus?))
                {
                    return new global::Dust.JsonConverters.PrivateConversationForkedFromFileCopyStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateFullConversationVariant2Visibility))
                {
                    return new global::Dust.JsonConverters.PrivateFullConversationVariant2VisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateFullConversationVariant2Visibility?))
                {
                    return new global::Dust.JsonConverters.PrivateFullConversationVariant2VisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateUserMessageType))
                {
                    return new global::Dust.JsonConverters.PrivateUserMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateUserMessageType?))
                {
                    return new global::Dust.JsonConverters.PrivateUserMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateUserMessageVisibility))
                {
                    return new global::Dust.JsonConverters.PrivateUserMessageVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateUserMessageVisibility?))
                {
                    return new global::Dust.JsonConverters.PrivateUserMessageVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageType))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageType?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageVisibility))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageVisibility?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageStatus))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageStatus?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageModelResolutionMethod))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageModelResolutionMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageModelResolutionMethod?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageModelResolutionMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentMessageType))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentMessageType?))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentMessageVisibility))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentMessageVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentMessageVisibility?))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentMessageVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentMessageStatus))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentMessageStatus?))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentMessageModelResolutionMethod))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentMessageModelResolutionMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentMessageModelResolutionMethod?))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentMessageModelResolutionMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentMessageActivityStepType))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentMessageActivityStepTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentMessageActivityStepType?))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentMessageActivityStepTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateContentFragmentType))
                {
                    return new global::Dust.JsonConverters.PrivateContentFragmentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateContentFragmentType?))
                {
                    return new global::Dust.JsonConverters.PrivateContentFragmentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateContentFragmentVisibility))
                {
                    return new global::Dust.JsonConverters.PrivateContentFragmentVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateContentFragmentVisibility?))
                {
                    return new global::Dust.JsonConverters.PrivateContentFragmentVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateContentFragmentContentFragmentVersion))
                {
                    return new global::Dust.JsonConverters.PrivateContentFragmentContentFragmentVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateContentFragmentContentFragmentVersion?))
                {
                    return new global::Dust.JsonConverters.PrivateContentFragmentContentFragmentVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateContentFragmentContentFragmentType))
                {
                    return new global::Dust.JsonConverters.PrivateContentFragmentContentFragmentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateContentFragmentContentFragmentType?))
                {
                    return new global::Dust.JsonConverters.PrivateContentFragmentContentFragmentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateContentFragmentExpiredReason))
                {
                    return new global::Dust.JsonConverters.PrivateContentFragmentExpiredReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateContentFragmentExpiredReason?))
                {
                    return new global::Dust.JsonConverters.PrivateContentFragmentExpiredReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateCompactionMessageType))
                {
                    return new global::Dust.JsonConverters.PrivateCompactionMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateCompactionMessageType?))
                {
                    return new global::Dust.JsonConverters.PrivateCompactionMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateCompactionMessageVisibility))
                {
                    return new global::Dust.JsonConverters.PrivateCompactionMessageVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateCompactionMessageVisibility?))
                {
                    return new global::Dust.JsonConverters.PrivateCompactionMessageVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateCompactionMessageStatus))
                {
                    return new global::Dust.JsonConverters.PrivateCompactionMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateCompactionMessageStatus?))
                {
                    return new global::Dust.JsonConverters.PrivateCompactionMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationStatus))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentConfigurationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationStatus?))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentConfigurationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationScope))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentConfigurationScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationScope?))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentConfigurationScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationModelReasoningEffort))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentConfigurationModelReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateLightAgentConfigurationModelReasoningEffort?))
                {
                    return new global::Dust.JsonConverters.PrivateLightAgentConfigurationModelReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateFileWithUploadUrlStatus))
                {
                    return new global::Dust.JsonConverters.PrivateFileWithUploadUrlStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateFileWithUploadUrlStatus?))
                {
                    return new global::Dust.JsonConverters.PrivateFileWithUploadUrlStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateFileWithUploadUrlUseCase))
                {
                    return new global::Dust.JsonConverters.PrivateFileWithUploadUrlUseCaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateFileWithUploadUrlUseCase?))
                {
                    return new global::Dust.JsonConverters.PrivateFileWithUploadUrlUseCaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSpaceKind))
                {
                    return new global::Dust.JsonConverters.PrivateSpaceKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSpaceKind?))
                {
                    return new global::Dust.JsonConverters.PrivateSpaceKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSpaceManagementMode))
                {
                    return new global::Dust.JsonConverters.PrivateSpaceManagementModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSpaceManagementMode?))
                {
                    return new global::Dust.JsonConverters.PrivateSpaceManagementModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateDataSourceViewCategory))
                {
                    return new global::Dust.JsonConverters.PrivateDataSourceViewCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateDataSourceViewCategory?))
                {
                    return new global::Dust.JsonConverters.PrivateDataSourceViewCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateDataSourceViewKind))
                {
                    return new global::Dust.JsonConverters.PrivateDataSourceViewKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateDataSourceViewKind?))
                {
                    return new global::Dust.JsonConverters.PrivateDataSourceViewKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateMentionSuggestionType))
                {
                    return new global::Dust.JsonConverters.PrivateMentionSuggestionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateMentionSuggestionType?))
                {
                    return new global::Dust.JsonConverters.PrivateMentionSuggestionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateFeedbackThumbDirection))
                {
                    return new global::Dust.JsonConverters.PrivateFeedbackThumbDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateFeedbackThumbDirection?))
                {
                    return new global::Dust.JsonConverters.PrivateFeedbackThumbDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateWakeUpScheduleConfigVariant1Type))
                {
                    return new global::Dust.JsonConverters.PrivateWakeUpScheduleConfigVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateWakeUpScheduleConfigVariant1Type?))
                {
                    return new global::Dust.JsonConverters.PrivateWakeUpScheduleConfigVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateWakeUpScheduleConfigVariant2Type))
                {
                    return new global::Dust.JsonConverters.PrivateWakeUpScheduleConfigVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateWakeUpScheduleConfigVariant2Type?))
                {
                    return new global::Dust.JsonConverters.PrivateWakeUpScheduleConfigVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateWakeUpStatus))
                {
                    return new global::Dust.JsonConverters.PrivateWakeUpStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateWakeUpStatus?))
                {
                    return new global::Dust.JsonConverters.PrivateWakeUpStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateMentionType))
                {
                    return new global::Dust.JsonConverters.PrivateMentionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateMentionType?))
                {
                    return new global::Dust.JsonConverters.PrivateMentionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateRichMentionWithStatusType))
                {
                    return new global::Dust.JsonConverters.PrivateRichMentionWithStatusTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateRichMentionWithStatusType?))
                {
                    return new global::Dust.JsonConverters.PrivateRichMentionWithStatusTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateRichMentionWithStatusStatus))
                {
                    return new global::Dust.JsonConverters.PrivateRichMentionWithStatusStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateRichMentionWithStatusStatus?))
                {
                    return new global::Dust.JsonConverters.PrivateRichMentionWithStatusStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateUserMessageContextOrigin))
                {
                    return new global::Dust.JsonConverters.PrivateUserMessageContextOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateUserMessageContextOrigin?))
                {
                    return new global::Dust.JsonConverters.PrivateUserMessageContextOriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConversationEventDiscriminatorType))
                {
                    return new global::Dust.JsonConverters.PrivateConversationEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConversationEventDiscriminatorType?))
                {
                    return new global::Dust.JsonConverters.PrivateConversationEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateUserMessageNewEventType))
                {
                    return new global::Dust.JsonConverters.PrivateUserMessageNewEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateUserMessageNewEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateUserMessageNewEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageNewEventType))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageNewEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageNewEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageNewEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageDoneEventType))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageDoneEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageDoneEventStatus))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageDoneEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageDoneEventStatus?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageDoneEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageConsumptionUpdatedEventType))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageConsumptionUpdatedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageConsumptionUpdatedEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageConsumptionUpdatedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateCompactionMessageNewEventType))
                {
                    return new global::Dust.JsonConverters.PrivateCompactionMessageNewEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateCompactionMessageNewEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateCompactionMessageNewEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateCompactionMessageDoneEventType))
                {
                    return new global::Dust.JsonConverters.PrivateCompactionMessageDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateCompactionMessageDoneEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateCompactionMessageDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConversationForkPreparedEventType))
                {
                    return new global::Dust.JsonConverters.PrivateConversationForkPreparedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConversationForkPreparedEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateConversationForkPreparedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConversationTitleEventType))
                {
                    return new global::Dust.JsonConverters.PrivateConversationTitleEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateConversationTitleEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateConversationTitleEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateWakeUpUpdatedEventType))
                {
                    return new global::Dust.JsonConverters.PrivateWakeUpUpdatedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateWakeUpUpdatedEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateWakeUpUpdatedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationEventDiscriminatorType))
                {
                    return new global::Dust.JsonConverters.PrivateSandboxFunctionInvocationEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationEventDiscriminatorType?))
                {
                    return new global::Dust.JsonConverters.PrivateSandboxFunctionInvocationEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventType))
                {
                    return new global::Dust.JsonConverters.PrivateSandboxFunctionInvocationCreatedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateSandboxFunctionInvocationCreatedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus))
                {
                    return new global::Dust.JsonConverters.PrivateSandboxFunctionInvocationCreatedEventInvocationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus?))
                {
                    return new global::Dust.JsonConverters.PrivateSandboxFunctionInvocationCreatedEventInvocationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationResultEventType))
                {
                    return new global::Dust.JsonConverters.PrivateSandboxFunctionInvocationResultEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationResultEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateSandboxFunctionInvocationResultEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationErrorEventType))
                {
                    return new global::Dust.JsonConverters.PrivateSandboxFunctionInvocationErrorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateSandboxFunctionInvocationErrorEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateSandboxFunctionInvocationErrorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageEventDiscriminatorType))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageEventDiscriminatorType?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateGenerationTokensEventType))
                {
                    return new global::Dust.JsonConverters.PrivateGenerationTokensEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateGenerationTokensEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateGenerationTokensEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateGenerationTokensEventClassification))
                {
                    return new global::Dust.JsonConverters.PrivateGenerationTokensEventClassificationJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateGenerationTokensEventClassification?))
                {
                    return new global::Dust.JsonConverters.PrivateGenerationTokensEventClassificationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolCallStartedEventType))
                {
                    return new global::Dust.JsonConverters.PrivateToolCallStartedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolCallStartedEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateToolCallStartedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentActionSuccessEventType))
                {
                    return new global::Dust.JsonConverters.PrivateAgentActionSuccessEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentActionSuccessEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentActionSuccessEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMCPActionStatus))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMCPActionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMCPActionStatus?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMCPActionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageSuccessEventType))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageSuccessEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentMessageSuccessEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentMessageSuccessEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentErrorEventType))
                {
                    return new global::Dust.JsonConverters.PrivateAgentErrorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentErrorEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentErrorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentGenerationCancelledEventType))
                {
                    return new global::Dust.JsonConverters.PrivateAgentGenerationCancelledEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentGenerationCancelledEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentGenerationCancelledEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolErrorEventType))
                {
                    return new global::Dust.JsonConverters.PrivateToolErrorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolErrorEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateToolErrorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolParamsEventType))
                {
                    return new global::Dust.JsonConverters.PrivateToolParamsEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolParamsEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateToolParamsEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolApproveExecutionEventType))
                {
                    return new global::Dust.JsonConverters.PrivateToolApproveExecutionEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolApproveExecutionEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateToolApproveExecutionEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolNotificationEventType))
                {
                    return new global::Dust.JsonConverters.PrivateToolNotificationEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolNotificationEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateToolNotificationEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolPersonalAuthRequiredEventType))
                {
                    return new global::Dust.JsonConverters.PrivateToolPersonalAuthRequiredEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolPersonalAuthRequiredEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateToolPersonalAuthRequiredEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolFileAuthRequiredEventType))
                {
                    return new global::Dust.JsonConverters.PrivateToolFileAuthRequiredEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateToolFileAuthRequiredEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateToolFileAuthRequiredEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentContextPrunedEventType))
                {
                    return new global::Dust.JsonConverters.PrivateAgentContextPrunedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PrivateAgentContextPrunedEventType?))
                {
                    return new global::Dust.JsonConverters.PrivateAgentContextPrunedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.ContextAgenticMessageDataType))
                {
                    return new global::Dust.JsonConverters.ContextAgenticMessageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.ContextAgenticMessageDataType?))
                {
                    return new global::Dust.JsonConverters.ContextAgenticMessageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.RichMentionType))
                {
                    return new global::Dust.JsonConverters.RichMentionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.RichMentionType?))
                {
                    return new global::Dust.JsonConverters.RichMentionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.ModelSelectionReasoningEffort))
                {
                    return new global::Dust.JsonConverters.ModelSelectionReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.ModelSelectionReasoningEffort?))
                {
                    return new global::Dust.JsonConverters.ModelSelectionReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SpaceKind))
                {
                    return new global::Dust.JsonConverters.SpaceKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SpaceKind?))
                {
                    return new global::Dust.JsonConverters.SpaceKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.TableSchemaItemValueType))
                {
                    return new global::Dust.JsonConverters.TableSchemaItemValueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.TableSchemaItemValueType?))
                {
                    return new global::Dust.JsonConverters.TableSchemaItemValueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.DatasourceViewCategory))
                {
                    return new global::Dust.JsonConverters.DatasourceViewCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.DatasourceViewCategory?))
                {
                    return new global::Dust.JsonConverters.DatasourceViewCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.DatasourceViewKind))
                {
                    return new global::Dust.JsonConverters.DatasourceViewKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.DatasourceViewKind?))
                {
                    return new global::Dust.JsonConverters.DatasourceViewKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillStatus))
                {
                    return new global::Dust.JsonConverters.SkillStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillStatus?))
                {
                    return new global::Dust.JsonConverters.SkillStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillSource))
                {
                    return new global::Dust.JsonConverters.SkillSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillSource?))
                {
                    return new global::Dust.JsonConverters.SkillSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillReinforcement))
                {
                    return new global::Dust.JsonConverters.SkillReinforcementJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillReinforcement?))
                {
                    return new global::Dust.JsonConverters.SkillReinforcementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillAvailability))
                {
                    return new global::Dust.JsonConverters.SkillAvailabilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.SkillAvailability?))
                {
                    return new global::Dust.JsonConverters.SkillAvailabilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewServerType))
                {
                    return new global::Dust.JsonConverters.MCPServerViewServerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewServerType?))
                {
                    return new global::Dust.JsonConverters.MCPServerViewServerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase))
                {
                    return new global::Dust.JsonConverters.MCPServerViewServerAuthorizationSupportedUseCaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewServerAuthorizationSupportedUseCase?))
                {
                    return new global::Dust.JsonConverters.MCPServerViewServerAuthorizationSupportedUseCaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewOAuthUseCase))
                {
                    return new global::Dust.JsonConverters.MCPServerViewOAuthUseCaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.MCPServerViewOAuthUseCase?))
                {
                    return new global::Dust.JsonConverters.MCPServerViewOAuthUseCaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestAgentScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope?))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestAgentScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestTagKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind?))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestTagKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestToolsetItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType?))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantAgentConfigurationsRequestToolsetItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestAgentScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope?))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestAgentScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestTagKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind?))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestTagKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestToolsetItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType?))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantAgentConfigurationsImportRequestToolsetItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection?))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSkillsRequestOnConflict))
                {
                    return new global::Dust.JsonConverters.CreateWSkillsRequestOnConflictJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSkillsRequestOnConflict?))
                {
                    return new global::Dust.JsonConverters.CreateWSkillsRequestOnConflictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSkillsRequestAvailability))
                {
                    return new global::Dust.JsonConverters.CreateWSkillsRequestAvailabilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSkillsRequestAvailability?))
                {
                    return new global::Dust.JsonConverters.CreateWSkillsRequestAvailabilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValueType))
                {
                    return new global::Dust.JsonConverters.CreateWSpacesDataSourcesTablesRowsRequestRowValueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValueType?))
                {
                    return new global::Dust.JsonConverters.CreateWSpacesDataSourcesTablesRowsRequestRowValueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAnalyticsConsumptionFacetsRequestPeriod))
                {
                    return new global::Dust.JsonConverters.CreateWAnalyticsConsumptionFacetsRequestPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAnalyticsConsumptionFacetsRequestPeriod?))
                {
                    return new global::Dust.JsonConverters.CreateWAnalyticsConsumptionFacetsRequestPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantConversationsCancelRequestAction))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantConversationsCancelRequestActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantConversationsCancelRequestAction?))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantConversationsCancelRequestActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantConversationsRequestVariant4AccessMode))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantConversationsRequestVariant4AccessModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWAssistantConversationsRequestVariant4AccessMode?))
                {
                    return new global::Dust.JsonConverters.PatchWAssistantConversationsRequestVariant4AccessModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2JsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2?))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantConversationsSelectedSpacesRequestMode))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantConversationsSelectedSpacesRequestModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantConversationsSelectedSpacesRequestMode?))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantConversationsSelectedSpacesRequestModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantConversationsRequestVisibility))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantConversationsRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWAssistantConversationsRequestVisibility?))
                {
                    return new global::Dust.JsonConverters.CreateWAssistantConversationsRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWFilesRequestUseCase))
                {
                    return new global::Dust.JsonConverters.CreateWFilesRequestUseCaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWFilesRequestUseCase?))
                {
                    return new global::Dust.JsonConverters.CreateWFilesRequestUseCaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesRequestPreference))
                {
                    return new global::Dust.JsonConverters.PatchWSpacesProjectNotificationPreferencesRequestPreferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesRequestPreference?))
                {
                    return new global::Dust.JsonConverters.PatchWSpacesProjectNotificationPreferencesRequestPreferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSpacesRequestSpaceKind))
                {
                    return new global::Dust.JsonConverters.CreateWSpacesRequestSpaceKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSpacesRequestSpaceKind?))
                {
                    return new global::Dust.JsonConverters.CreateWSpacesRequestSpaceKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSpacesRequestManagementMode))
                {
                    return new global::Dust.JsonConverters.CreateWSpacesRequestManagementModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWSpacesRequestManagementMode?))
                {
                    return new global::Dust.JsonConverters.CreateWSpacesRequestManagementModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWorkosAuthenticateRequestGrantType))
                {
                    return new global::Dust.JsonConverters.CreateWorkosAuthenticateRequestGrantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.CreateWorkosAuthenticateRequestGrantType?))
                {
                    return new global::Dust.JsonConverters.CreateWorkosAuthenticateRequestGrantTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAnalyticsExportTable))
                {
                    return new global::Dust.JsonConverters.GetWAnalyticsExportTableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAnalyticsExportTable?))
                {
                    return new global::Dust.JsonConverters.GetWAnalyticsExportTableNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAnalyticsExportFormat))
                {
                    return new global::Dust.JsonConverters.GetWAnalyticsExportFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAnalyticsExportFormat?))
                {
                    return new global::Dust.JsonConverters.GetWAnalyticsExportFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsViewJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsViewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthorsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthorsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsVariant))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsVariantJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsVariant?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsVariantNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem))
                {
                    return new global::Dust.JsonConverters.GetWAssistantConversationsMentionsSuggestionsSelectItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantConversationsMentionsSuggestionsSelectItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsSelectItem))
                {
                    return new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsSelectItem?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSearchViewType))
                {
                    return new global::Dust.JsonConverters.GetWSearchViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSearchViewType?))
                {
                    return new global::Dust.JsonConverters.GetWSearchViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSkillsStatus))
                {
                    return new global::Dust.JsonConverters.GetWSkillsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSkillsStatus?))
                {
                    return new global::Dust.JsonConverters.GetWSkillsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSkillsAvailabilityItem))
                {
                    return new global::Dust.JsonConverters.GetWSkillsAvailabilityItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSkillsAvailabilityItem?))
                {
                    return new global::Dust.JsonConverters.GetWSkillsAvailabilityItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView2))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsView2JsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsView2?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsView2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithUsage))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithUsageJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithUsage?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithUsageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors2))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthors2JsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithAuthors2?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithAuthors2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithFeedbacks))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithFeedbacksJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithFeedbacks?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithFeedbacksNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithEditors))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithEditorsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantAgentConfigurationsWithEditors?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantAgentConfigurationsWithEditorsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsSelect))
                {
                    return new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsSelect?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsCurrent))
                {
                    return new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsCurrentJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantMentionsSuggestionsCurrent?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantMentionsSuggestionsCurrentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWFilesVersion))
                {
                    return new global::Dust.JsonConverters.GetWFilesVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWFilesVersion?))
                {
                    return new global::Dust.JsonConverters.GetWFilesVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWFilesAction))
                {
                    return new global::Dust.JsonConverters.GetWFilesActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWFilesAction?))
                {
                    return new global::Dust.JsonConverters.GetWFilesActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.DeleteWSpacesDataSourceViewsForce))
                {
                    return new global::Dust.JsonConverters.DeleteWSpacesDataSourceViewsForceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.DeleteWSpacesDataSourceViewsForce?))
                {
                    return new global::Dust.JsonConverters.DeleteWSpacesDataSourceViewsForceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsCategory))
                {
                    return new global::Dust.JsonConverters.GetWSpacesDataSourceViewsCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsCategory?))
                {
                    return new global::Dust.JsonConverters.GetWSpacesDataSourceViewsCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsWithDetails))
                {
                    return new global::Dust.JsonConverters.GetWSpacesDataSourceViewsWithDetailsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsWithDetails?))
                {
                    return new global::Dust.JsonConverters.GetWSpacesDataSourceViewsWithDetailsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsIncludeEditedBy))
                {
                    return new global::Dust.JsonConverters.GetWSpacesDataSourceViewsIncludeEditedByJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesDataSourceViewsIncludeEditedBy?))
                {
                    return new global::Dust.JsonConverters.GetWSpacesDataSourceViewsIncludeEditedByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesIncludeAllMembers))
                {
                    return new global::Dust.JsonConverters.GetWSpacesIncludeAllMembersJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesIncludeAllMembers?))
                {
                    return new global::Dust.JsonConverters.GetWSpacesIncludeAllMembersNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.DeleteWSpacesForce))
                {
                    return new global::Dust.JsonConverters.DeleteWSpacesForceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.DeleteWSpacesForce?))
                {
                    return new global::Dust.JsonConverters.DeleteWSpacesForceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesKindItem))
                {
                    return new global::Dust.JsonConverters.GetWSpacesKindItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesKindItem?))
                {
                    return new global::Dust.JsonConverters.GetWSpacesKindItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection))
                {
                    return new global::Dust.JsonConverters.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantConversationsMessagesActionsResponseMessageStatus))
                {
                    return new global::Dust.JsonConverters.GetWAssistantConversationsMessagesActionsResponseMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWAssistantConversationsMessagesActionsResponseMessageStatus?))
                {
                    return new global::Dust.JsonConverters.GetWAssistantConversationsMessagesActionsResponseMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference))
                {
                    return new global::Dust.JsonConverters.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference?))
                {
                    return new global::Dust.JsonConverters.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference))
                {
                    return new global::Dust.JsonConverters.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference?))
                {
                    return new global::Dust.JsonConverters.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreferenceNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}