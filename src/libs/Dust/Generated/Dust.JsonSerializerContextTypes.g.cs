
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
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConsumptionFacet? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConsumptionFacetScope? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConsumptionFacetTier? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateUser? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateUserProvider? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateWorkspace>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateWorkspace? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateWorkspaceRole? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationConsumptionToolDetails? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationConsumptionModelDetails? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationConsumptionAgentDetails? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionToolDetails>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionModelDetails>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationConsumptionDetails? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateConversationConsumptionAgentDetails>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversation? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationForkingData? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationForkUser? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationForkUserProvider? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationForkedFrom? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationForkedFromFileCopyStatus? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationForkedChild? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateConversationForkedChild>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateFullConversation? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateFullConversationVariant2? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateFullConversationVariant2Visibility? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>>>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateUserMessage? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessage? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateContentFragment? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateCompactionMessage? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateUserMessageType? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateUserMessageVisibility? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateUserMessageUser? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateMention>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateMention? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateRichMentionWithStatus>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateRichMentionWithStatus? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateUserMessageContext? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateReaction>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateReaction? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageType? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageVisibility? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageStatus? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageError? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentConfiguration? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateAgentMessageContent>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageContent? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageResolvedModel? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageModelResolutionMethod? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentMessage? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentMessageType? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentMessageVisibility? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentMessageStatus? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentMessageError? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentMessageConfiguration? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dust.PrivateCitation>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateCitation? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentMessageGeneratedFile>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentMessageGeneratedFile? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentMessageResolvedModel? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentMessageModelResolutionMethod? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentMessageActivityStep>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentMessageActivityStep? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentMessageActivityStepType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateContentFragmentType? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateContentFragmentVisibility? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateContentFragmentContext? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateContentFragmentContentFragmentVersion? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateContentFragmentContentFragmentType? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateContentFragmentExpiredReason? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateCompactionMessageType? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateCompactionMessageVisibility? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateCompactionMessageStatus? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentConfigurationStatus? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentConfigurationScope? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentConfigurationModel? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentConfigurationModelReasoningEffort? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfigurationTag>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentConfigurationTag? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfigurationEditor>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentConfigurationEditor? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentConfigurationUsage? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateLightAgentConfigurationFeedbacks? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetGoTemplateDraftResponseBody? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetGoTemplateDraftResponseBodyAttachment>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetGoTemplateDraftResponseBodyAttachment? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetGoTemplateDraftResponseBodyAttachmentError>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetGoTemplateDraftResponseBodyAttachmentError? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateFileWithUploadUrl? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateFileWithUploadUrlStatus? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateFileWithUploadUrlUseCase? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSpace? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSpaceKind? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSpaceManagementMode? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateProject? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateProjectVariant2? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateProjectVariant2FrameTab>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateProjectVariant2FrameTab? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateDataSourceView? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateDataSourceViewCategory? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateDataSourceViewKind? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateDataSource? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateDataSourceViewEditedByUser? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateDataSourceViewUsage? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceViewUsageAgent>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateDataSourceViewUsageAgent? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceViewUsageSkill>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateDataSourceViewUsageSkill? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateMentionSuggestion? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateMentionSuggestionType? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateFeatureFlags? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateExtensionConfig? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateFeedback? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateFeedbackThumbDirection? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateWakeUp? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.OneOf<global::Dust.PrivateWakeUpScheduleConfigVariant1, global::Dust.PrivateWakeUpScheduleConfigVariant2>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateWakeUpScheduleConfigVariant1? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateWakeUpScheduleConfigVariant1Type? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateWakeUpScheduleConfigVariant2? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateWakeUpScheduleConfigVariant2Type? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateWakeUpStatus? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateMentionType? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateRichMentionWithStatusType? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateRichMentionWithStatusStatus? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateUserMessageContextOrigin? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateReactionUser>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateReactionUser? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationEvent? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateUserMessageNewEvent? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageNewEvent? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageConsumptionUpdatedEvent? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageDoneEvent? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateCompactionMessageNewEvent? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateCompactionMessageDoneEvent? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationForkPreparedEvent? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationTitleEvent? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateWakeUpUpdatedEvent? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationEventDiscriminator? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationEventDiscriminatorType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateUserMessageNewEventType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageNewEventType? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageDoneEventType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageDoneEventStatus? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageConsumptionUpdatedEventType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateCompactionMessageNewEventType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateCompactionMessageDoneEventType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationForkPreparedEventType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateConversationTitleEventType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateWakeUpUpdatedEventType? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationEvent? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationCreatedEvent? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationResultEvent? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationErrorEvent? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationEventDiscriminator? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationEventDiscriminatorType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationCreatedEventType? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocation? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationResultEventType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationErrorEventType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateSandboxFunctionInvocationErrorEventError? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageEvent? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateGenerationTokensEvent? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolCallStartedEvent? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentActionSuccessEvent? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageSuccessEvent? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentErrorEvent? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentGenerationCancelledEvent? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolErrorEvent? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolParamsEvent? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolApproveExecutionEvent? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolNotificationEvent? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolPersonalAuthRequiredEvent? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolFileAuthRequiredEvent? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentContextPrunedEvent? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageEventDiscriminator? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageEventDiscriminatorType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateGenerationTokensEventType? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateGenerationTokensEventClassification? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolCallStartedEventType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentActionSuccessEventType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMCPAction? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMCPActionStatus? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMCPActionDisplayLabels? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateAgentMCPActionGeneratedFile>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMCPActionGeneratedFile? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentMessageSuccessEventType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentErrorEventType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentErrorEventError? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentGenerationCancelledEventType? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolErrorEventType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolErrorEventError? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolParamsEventType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolApproveExecutionEventType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolNotificationEventType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolPersonalAuthRequiredEventType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolPersonalAuthRequiredEventAuthError? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolFileAuthRequiredEventType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateToolFileAuthRequiredEventFileAuthError? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PrivateAgentContextPrunedEventType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Section? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Section>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.User? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Workspace? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Context? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ContextAgenticMessageData? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ContextAgenticMessageDataType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.AgentConfiguration? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.AgentConfigurationModel? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Conversation? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConversation1? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItem>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConversation1ContentItemItem? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Mention>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Mention? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemAction>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConversation1ContentItemItemAction? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ConversationConversation1ContentItemItemRawContent>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ConversationConversation1ContentItemItemRawContent? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.RichMention? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.RichMentionType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Message? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ModelSelection? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ModelSelectionReasoningEffort? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.ContentFragment? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Space? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SpaceKind? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Datasource? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Table? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.TableSchemaItem>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TableSchemaItem? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TableSchemaItemValueType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DatasourceView? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DatasourceViewCategory? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DatasourceViewEditedByUser? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DatasourceViewKind? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillSourceMetadata? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Skill? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillStatus? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillSource? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillReinforcement? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.SkillFileAttachment>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillFileAttachment? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.SkillAvailability? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.MCPServerView>? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerView? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Run? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.RunStatus? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dust.RunTraceItem>>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.RunTraceItem>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.RunTraceItem? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Document? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewServerType? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewServer? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewServerAuthorization? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewServerAuthorizationSupportedUseCase? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.MCPServerViewServerTool>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewServerTool? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewOAuthUseCase? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.MCPServerViewEditedByUser? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.Trigger? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TriggerKind? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TriggerStatus? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TriggerExecutionMode? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.TriggerWebhookSource? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchUserRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequest? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestAgent? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestAgentScope? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestGenerationSettings? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestTag? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestTagKind? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestSkill>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestSkill? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemType? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItemConfiguration? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequest? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgent? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestAgentScope? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestGenerationSettings? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestTagKind? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItemType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsCancelRequest? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.OneOf<global::Dust.PatchWAssistantConversationsRequestVariant1, global::Dust.PatchWAssistantConversationsRequestVariant2>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsRequestVariant1? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsRequestVariant2? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequest? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionRequestAnswer? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesEditRequest? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesEditRequestMention? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequest? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesValidateActionRequest? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsRequest? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.ContentFragment>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantMentionsParseRequest? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWFilesRequest? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpDeregisterRequest? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpHeartbeatRequest? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpRegisterRequest? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpResultsRequest? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSearchRequest? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSearchToolsUploadRequest? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSkillsRequest? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSkillsRequestOnConflict? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSkillsRequestAvailability? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesAppsRunsRequest? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesAppsRunsRequestConfig? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesAppsRunsRequestConfigModel? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.OneOf<global::Dust.PatchWSpacesDataSourceViewsRequestVariant1, global::Dust.PatchWSpacesDataSourceViewsRequestVariant2>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesDataSourceViewsRequestVariant1? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesDataSourceViewsRequestVariant2? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesDocumentsRequest? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesDocumentsParentsRequest? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesRowsRequest? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRow>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRow? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.OneOf<string, double?, bool?, global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValue2>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValue2? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRowValueType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesRequest? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAnalyticsConsumptionFacetsRequest? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAnalyticsConsumptionFacetsRequestPeriod? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAnalyticsConsumptionFacetsRequestScope? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWAnalyticsConsumptionFacetsRequestDimension>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAnalyticsConsumptionFacetsRequestDimension? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAnalyticsConsumptionFacetsRequestFilter? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsRequest? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsCancelRequest2? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsCancelRequestAction? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsCompactionsRequest? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsCompactionsRequestModel? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsContentFragmentRequest? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsContentFragmentRequestContext? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsRequestVariant12? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsRequestVariant22? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsRequestVariant3? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsRequestVariant4? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsRequestVariant4AccessMode? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesEditRequest2? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequest2? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesFeedbacksRequestThumbDirection2? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesRequest? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesRequestContext? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesRequestModelSelection? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsSelectedSpacesRequest? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsSelectedSpacesRequestMode? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsRequest2? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsRequestVisibility? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsRequestMessage? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsRequestMessageContext? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsRequestMetadata? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWFilesRequest2? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWFilesRequest3? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWFilesRequestUseCase? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesDataSourceViewsRequest2? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourceViewsRequest? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesRequest? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PatchWSpacesRequestContentItem>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesRequestContentItem? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesProjectNotificationPreferencesRequest? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesProjectNotificationPreferencesRequestPreference? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesRequest? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesRequestSpaceKind? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesRequestManagementMode? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWorkosAuthenticateRequest? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWorkosAuthenticateRequestGrantType? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWorkosRevokeSessionRequest? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAnalyticsExportTable? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAnalyticsExportFormat? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsView? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsWithAuthors? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsVariant? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantMentionsSuggestionsSelectItem>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantMentionsSuggestionsSelectItem? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSearchViewType? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSkillsStatus? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWSkillsAvailabilityItem>? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSkillsAvailabilityItem? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWTriggersKind? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsView2? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsWithUsage? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsWithAuthors2? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsWithFeedbacks? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsWithEditors? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantMentionsSuggestionsSelect? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantMentionsSuggestionsCurrent? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWFilesVersion? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWFilesAction? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWSpacesDataSourceViewsForce? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourceViewsCategory? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourceViewsWithDetails? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourceViewsIncludeEditedBy? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesIncludeAllMembers? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWSpacesForce? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWSpacesKindItem>? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesKindItem? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetUserResponse? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchUserResponse? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsResponse? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.AgentConfiguration>? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsResponse2? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsResponse? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWAssistantAgentConfigurationsResponse? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportResponse? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsSearchResponse? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsCancelResponse? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsFeedbacksResponse? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsFeedbacksResponseFeedback>? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsFeedbacksResponseFeedback? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsFeedbacksResponseFeedbackThumbDirection? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsResponse? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMentionsSuggestionsResponse? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.RichMention>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesAnswerQuestionResponse? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesEditResponse? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMessagesEventsResponse? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMessagesEventsResponseEvent>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMessagesEventsResponseEvent? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesFeedbacksResponse? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWAssistantConversationsMessagesFeedbacksResponse? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesValidateActionResponse? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantMentionsParseResponse? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantMentionsSuggestionsResponse? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWFilesResponse? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWFilesResponseFile? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpHeartbeatResponse? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWMcpRegisterResponse? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWMcpRequestsResponse? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWSkillsResponse? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSkillsResponse? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Skill>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSkillsResponse? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.CreateWSkillsResponseSkippedItem>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSkillsResponseSkippedItem? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesAppsRunsResponse? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesAppsRunsResponse? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesAppsResponse? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWSpacesAppsResponseApp>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesAppsResponseApp? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourceViewsSearchResponse? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWSpacesDataSourceViewsSearchResponseDocument>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourceViewsSearchResponseDocument? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourceViewsResponse? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.DatasourceView>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesCheckUpsertQueueResponse? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesDocumentsResponse? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesDocumentsResponse? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWSpacesDataSourcesDocumentsResponse? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWSpacesDataSourcesDocumentsResponseDocument? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesDocumentsResponse2? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Document>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesSearchResponse? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWSpacesDataSourcesSearchResponseDocument>? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesSearchResponseDocument? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Datasource>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesTablesResponse? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Table>? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourcesTablesResponse? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourcesResponse? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesMcpServerViewsResponse? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesResponse? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Space>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWTriggersResponse? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWTriggersResponse2? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.Trigger>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAnalyticsConsumptionFacetsResponse? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAnalyticsConsumptionFacetsResponsePeriod? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAnalyticsConsumptionFacetsResponseFacets? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateConsumptionFacet>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantAgentConfigurationsResponse3? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateLightAgentConfiguration>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantAgentConfigurationsResponse? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsCancelResponse2? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsCompactionsResponse? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsConsumptionResponse? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsContentFragmentResponse? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsFeedbacksResponse2? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateFeedback>? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsResponse? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWAssistantConversationsResponse2? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMessagesActionsResponse? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMessagesActionsResponseMessageStatus? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMessagesConsumptionResponse? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetails? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetailsTool>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetailsTool? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesEditResponse2? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesFeedbacksResponse2? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWAssistantConversationsMessagesFeedbacksResponse2? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMessagesResponse? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWAssistantConversationsMessagesResponse? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesRetryResponse? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsMessagesResponse2? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsMessagesResponse? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateContentFragment>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateAgentMessage>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsParticipantsResponse? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsParticipantsResponseParticipants? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsAgent>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsAgent? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsUser>? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsUser? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsSelectableSpacesResponse? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace>>? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsSelectedSpacesResponse? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace>>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsSelectedSpacesResponseEffectiveAcl? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWAssistantConversationsWakeupsResponse? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsWakeupsResponse? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateWakeUp>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantConversationsResponse2? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateConversation>? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWAssistantConversationsResponse? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWAssistantMentionsSuggestionsResponse2? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateMentionSuggestion>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWFilesResponse2? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWFilesResponse3? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourceViewsResponse2? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesDataSourceViewsResponse? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesDataSourceViewsResponse3? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.PrivateDataSourceView>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesDataSourceViewsResponse? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesResponse2? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWSpacesResponseSpace>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesResponseSpace? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dust.GetWSpacesResponseSpaceCategories2>? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesResponseSpaceCategories2? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesResponseSpaceCategoriesUsage? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWSpacesResponseSpaceGroup>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesResponseSpaceGroup? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesResponseSpaceGroupRole? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.GetWSpacesResponseSpaceFrameTab>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesResponseSpaceFrameTab? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesResponse? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.DeleteWSpacesResponse? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesProjectNotificationPreferencesResponse? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesProjectNotificationPreferencesResponse? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreference? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.PatchWSpacesProjectNotificationPreferencesResponseUserProjectNotificationPreferencePreference? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.GetWSpacesResponse3? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dust.OneOf<global::Dust.PrivateSpace, global::Dust.PrivateProject?>>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.OneOf<global::Dust.PrivateSpace, global::Dust.PrivateProject?>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWSpacesResponse? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWorkosAuthenticateResponse? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Dust.CreateWorkosRevokeSessionResponse? Type589 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateWorkspace>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateConversationConsumptionToolDetails>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateConversationConsumptionModelDetails>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateConversationConsumptionAgentDetails>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateConversationForkedChild>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>>>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateAgentMessage, global::Dust.PrivateContentFragment, global::Dust.PrivateCompactionMessage>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateMention>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateRichMentionWithStatus>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateReaction>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateAgentMessageContent>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateLightAgentMessageGeneratedFile>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateLightAgentMessageActivityStep>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateLightAgentConfigurationTag>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateLightAgentConfigurationEditor>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetGoTemplateDraftResponseBodyAttachment>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetGoTemplateDraftResponseBodyAttachmentError>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateProjectVariant2FrameTab>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateDataSourceViewUsageAgent>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateDataSourceViewUsageSkill>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateReactionUser>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateAgentMCPActionGeneratedFile>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Section>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItem>>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Mention>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemAction>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemActionGeneratedFile>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ConversationConversation1ContentItemItemRawContent>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.TableSchemaItem>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.SkillFileAttachment>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.MCPServerView>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dust.RunTraceItem>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.RunTraceItem>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.MCPServerViewServerAuthorizationSupportedUseCase>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.MCPServerViewServerTool>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestTag>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestSkill>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsRequestToolsetItem>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportRequestTag>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportRequestToolsetItem>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWAssistantConversationsMessagesEditRequestMention>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.ContentFragment>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWSpacesDataSourcesTablesRowsRequestRow>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWAnalyticsConsumptionFacetsRequestDimension>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PatchWSpacesRequestContentItem>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsMentionsSuggestionsSelectItem>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWAssistantMentionsSuggestionsSelectItem>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWSkillsAvailabilityItem>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWSpacesKindItem>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.AgentConfiguration>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PatchWAssistantAgentConfigurationsResponseSkippedAction>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWAssistantAgentConfigurationsImportResponseSkippedAction>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsFeedbacksResponseFeedback>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.RichMention>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsMessagesEventsResponseEvent>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Skill>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.CreateWSkillsResponseSkippedItem>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWSpacesAppsResponseApp>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWSpacesDataSourceViewsSearchResponseDocument>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.DatasourceView>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Document>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWSpacesDataSourcesSearchResponseDocument>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Datasource>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Table>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Space>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.Trigger>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateConsumptionFacet>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateLightAgentConfiguration>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateFeedback>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsMessagesConsumptionResponseDetailsTool>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.OneOf<global::Dust.PrivateUserMessage, global::Dust.PrivateLightAgentMessage, global::Dust.PrivateContentFragment>>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateContentFragment>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateAgentMessage>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsAgent>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWAssistantConversationsParticipantsResponseParticipantsUser>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.GetWAssistantConversationsSelectableSpacesResponseSpace>>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.AllOf<global::Dust.PrivateSpace, global::Dust.CreateWAssistantConversationsSelectedSpacesResponseSelectedSpace>>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateWakeUp>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateConversation>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateMentionSuggestion>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.PrivateDataSourceView>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWSpacesResponseSpaceGroup>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.GetWSpacesResponseSpaceFrameTab>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Dust.OneOf<global::Dust.PrivateSpace, global::Dust.PrivateProject?>>? ListType89 { get; set; }
    }
}