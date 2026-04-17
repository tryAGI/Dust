#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public class PrivateAgentMessageEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.PrivateAgentMessageEvent>
    {
        /// <inheritdoc />
        public override global::Dust.PrivateAgentMessageEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("classification")) __score0++;
            if (__jsonProps.Contains("configurationId")) __score0++;
            if (__jsonProps.Contains("created")) __score0++;
            if (__jsonProps.Contains("delimiterClassification")) __score0++;
            if (__jsonProps.Contains("messageId")) __score0++;
            if (__jsonProps.Contains("step")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("configurationId")) __score1++;
            if (__jsonProps.Contains("created")) __score1++;
            if (__jsonProps.Contains("messageId")) __score1++;
            if (__jsonProps.Contains("step")) __score1++;
            if (__jsonProps.Contains("toolCallId")) __score1++;
            if (__jsonProps.Contains("toolCallIndex")) __score1++;
            if (__jsonProps.Contains("toolName")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("action")) __score2++;
            if (__jsonProps.Contains("action.agentMessageId")) __score2++;
            if (__jsonProps.Contains("action.citations")) __score2++;
            if (__jsonProps.Contains("action.citationsAllocated")) __score2++;
            if (__jsonProps.Contains("action.createdAt")) __score2++;
            if (__jsonProps.Contains("action.displayLabels")) __score2++;
            if (__jsonProps.Contains("action.executionDurationMs")) __score2++;
            if (__jsonProps.Contains("action.functionCallId")) __score2++;
            if (__jsonProps.Contains("action.functionCallName")) __score2++;
            if (__jsonProps.Contains("action.generatedFiles")) __score2++;
            if (__jsonProps.Contains("action.id")) __score2++;
            if (__jsonProps.Contains("action.internalMCPServerName")) __score2++;
            if (__jsonProps.Contains("action.mcpServerId")) __score2++;
            if (__jsonProps.Contains("action.output")) __score2++;
            if (__jsonProps.Contains("action.params")) __score2++;
            if (__jsonProps.Contains("action.sId")) __score2++;
            if (__jsonProps.Contains("action.status")) __score2++;
            if (__jsonProps.Contains("action.step")) __score2++;
            if (__jsonProps.Contains("action.toolName")) __score2++;
            if (__jsonProps.Contains("action.updatedAt")) __score2++;
            if (__jsonProps.Contains("configurationId")) __score2++;
            if (__jsonProps.Contains("created")) __score2++;
            if (__jsonProps.Contains("messageId")) __score2++;
            if (__jsonProps.Contains("step")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("configurationId")) __score3++;
            if (__jsonProps.Contains("created")) __score3++;
            if (__jsonProps.Contains("message")) __score3++;
            if (__jsonProps.Contains("message.actions")) __score3++;
            if (__jsonProps.Contains("message.agentMessageId")) __score3++;
            if (__jsonProps.Contains("message.chainOfThought")) __score3++;
            if (__jsonProps.Contains("message.completedTs")) __score3++;
            if (__jsonProps.Contains("message.completionDurationMs")) __score3++;
            if (__jsonProps.Contains("message.configuration")) __score3++;
            if (__jsonProps.Contains("message.content")) __score3++;
            if (__jsonProps.Contains("message.contents")) __score3++;
            if (__jsonProps.Contains("message.created")) __score3++;
            if (__jsonProps.Contains("message.error")) __score3++;
            if (__jsonProps.Contains("message.id")) __score3++;
            if (__jsonProps.Contains("message.parentAgentMessageId")) __score3++;
            if (__jsonProps.Contains("message.parentMessageId")) __score3++;
            if (__jsonProps.Contains("message.rank")) __score3++;
            if (__jsonProps.Contains("message.reactions")) __score3++;
            if (__jsonProps.Contains("message.richMentions")) __score3++;
            if (__jsonProps.Contains("message.sId")) __score3++;
            if (__jsonProps.Contains("message.skipToolsValidation")) __score3++;
            if (__jsonProps.Contains("message.status")) __score3++;
            if (__jsonProps.Contains("message.type")) __score3++;
            if (__jsonProps.Contains("message.version")) __score3++;
            if (__jsonProps.Contains("message.visibility")) __score3++;
            if (__jsonProps.Contains("messageId")) __score3++;
            if (__jsonProps.Contains("runIds")) __score3++;
            if (__jsonProps.Contains("step")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("configurationId")) __score4++;
            if (__jsonProps.Contains("created")) __score4++;
            if (__jsonProps.Contains("error")) __score4++;
            if (__jsonProps.Contains("error.code")) __score4++;
            if (__jsonProps.Contains("error.message")) __score4++;
            if (__jsonProps.Contains("messageId")) __score4++;
            if (__jsonProps.Contains("runIds")) __score4++;
            if (__jsonProps.Contains("step")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("configurationId")) __score5++;
            if (__jsonProps.Contains("created")) __score5++;
            if (__jsonProps.Contains("messageId")) __score5++;
            if (__jsonProps.Contains("step")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("configurationId")) __score6++;
            if (__jsonProps.Contains("conversationId")) __score6++;
            if (__jsonProps.Contains("created")) __score6++;
            if (__jsonProps.Contains("error")) __score6++;
            if (__jsonProps.Contains("error.code")) __score6++;
            if (__jsonProps.Contains("error.message")) __score6++;
            if (__jsonProps.Contains("isLastBlockingEventForStep")) __score6++;
            if (__jsonProps.Contains("messageId")) __score6++;
            if (__jsonProps.Contains("step")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("action")) __score7++;
            if (__jsonProps.Contains("configurationId")) __score7++;
            if (__jsonProps.Contains("created")) __score7++;
            if (__jsonProps.Contains("messageId")) __score7++;
            if (__jsonProps.Contains("runIds")) __score7++;
            if (__jsonProps.Contains("step")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("actionId")) __score8++;
            if (__jsonProps.Contains("configurationId")) __score8++;
            if (__jsonProps.Contains("conversationId")) __score8++;
            if (__jsonProps.Contains("created")) __score8++;
            if (__jsonProps.Contains("inputs")) __score8++;
            if (__jsonProps.Contains("isLastBlockingEventForStep")) __score8++;
            if (__jsonProps.Contains("messageId")) __score8++;
            if (__jsonProps.Contains("metadata")) __score8++;
            if (__jsonProps.Contains("stake")) __score8++;
            if (__jsonProps.Contains("step")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("action")) __score9++;
            if (__jsonProps.Contains("configurationId")) __score9++;
            if (__jsonProps.Contains("conversationId")) __score9++;
            if (__jsonProps.Contains("created")) __score9++;
            if (__jsonProps.Contains("messageId")) __score9++;
            if (__jsonProps.Contains("notification")) __score9++;
            if (__jsonProps.Contains("step")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("actionId")) __score10++;
            if (__jsonProps.Contains("authError")) __score10++;
            if (__jsonProps.Contains("authError.mcpServerId")) __score10++;
            if (__jsonProps.Contains("authError.message")) __score10++;
            if (__jsonProps.Contains("authError.provider")) __score10++;
            if (__jsonProps.Contains("authError.scope")) __score10++;
            if (__jsonProps.Contains("authError.toolName")) __score10++;
            if (__jsonProps.Contains("configurationId")) __score10++;
            if (__jsonProps.Contains("conversationId")) __score10++;
            if (__jsonProps.Contains("created")) __score10++;
            if (__jsonProps.Contains("messageId")) __score10++;
            if (__jsonProps.Contains("step")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("actionId")) __score11++;
            if (__jsonProps.Contains("configurationId")) __score11++;
            if (__jsonProps.Contains("conversationId")) __score11++;
            if (__jsonProps.Contains("created")) __score11++;
            if (__jsonProps.Contains("fileAuthError")) __score11++;
            if (__jsonProps.Contains("fileAuthError.connectionId")) __score11++;
            if (__jsonProps.Contains("fileAuthError.fileId")) __score11++;
            if (__jsonProps.Contains("fileAuthError.fileName")) __score11++;
            if (__jsonProps.Contains("fileAuthError.message")) __score11++;
            if (__jsonProps.Contains("fileAuthError.mimeType")) __score11++;
            if (__jsonProps.Contains("fileAuthError.toolName")) __score11++;
            if (__jsonProps.Contains("messageId")) __score11++;
            if (__jsonProps.Contains("step")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("configurationId")) __score12++;
            if (__jsonProps.Contains("created")) __score12++;
            if (__jsonProps.Contains("messageId")) __score12++;
            if (__jsonProps.Contains("step")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }

            global::Dust.PrivateGenerationTokensEvent? generationTokens = default;
            global::Dust.PrivateToolCallStartedEvent? toolCallStarted = default;
            global::Dust.PrivateAgentActionSuccessEvent? agentActionSuccess = default;
            global::Dust.PrivateAgentMessageSuccessEvent? agentMessageSuccess = default;
            global::Dust.PrivateAgentErrorEvent? agentError = default;
            global::Dust.PrivateAgentGenerationCancelledEvent? agentGenerationCancelled = default;
            global::Dust.PrivateToolErrorEvent? toolError = default;
            global::Dust.PrivateToolParamsEvent? toolParams = default;
            global::Dust.PrivateToolApproveExecutionEvent? toolApproveExecution = default;
            global::Dust.PrivateToolNotificationEvent? toolNotification = default;
            global::Dust.PrivateToolPersonalAuthRequiredEvent? toolPersonalAuthRequired = default;
            global::Dust.PrivateToolFileAuthRequiredEvent? toolFileAuthRequired = default;
            global::Dust.PrivateAgentContextPrunedEvent? agentContextPruned = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateGenerationTokensEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateGenerationTokensEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateGenerationTokensEvent).Name}");
                        generationTokens = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolCallStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolCallStartedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolCallStartedEvent).Name}");
                        toolCallStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentActionSuccessEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentActionSuccessEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentActionSuccessEvent).Name}");
                        agentActionSuccess = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageSuccessEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageSuccessEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentMessageSuccessEvent).Name}");
                        agentMessageSuccess = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentErrorEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentErrorEvent).Name}");
                        agentError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentGenerationCancelledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentGenerationCancelledEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentGenerationCancelledEvent).Name}");
                        agentGenerationCancelled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolErrorEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolErrorEvent).Name}");
                        toolError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolParamsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolParamsEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolParamsEvent).Name}");
                        toolParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolApproveExecutionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolApproveExecutionEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolApproveExecutionEvent).Name}");
                        toolApproveExecution = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolNotificationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolNotificationEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolNotificationEvent).Name}");
                        toolNotification = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolPersonalAuthRequiredEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolPersonalAuthRequiredEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolPersonalAuthRequiredEvent).Name}");
                        toolPersonalAuthRequired = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolFileAuthRequiredEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolFileAuthRequiredEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolFileAuthRequiredEvent).Name}");
                        toolFileAuthRequired = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentContextPrunedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentContextPrunedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentContextPrunedEvent).Name}");
                        agentContextPruned = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (generationTokens == null && toolCallStarted == null && agentActionSuccess == null && agentMessageSuccess == null && agentError == null && agentGenerationCancelled == null && toolError == null && toolParams == null && toolApproveExecution == null && toolNotification == null && toolPersonalAuthRequired == null && toolFileAuthRequired == null && agentContextPruned == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateGenerationTokensEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateGenerationTokensEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateGenerationTokensEvent).Name}");
                    generationTokens = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolCallStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolCallStartedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolCallStartedEvent).Name}");
                    toolCallStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentActionSuccessEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentActionSuccessEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentActionSuccessEvent).Name}");
                    agentActionSuccess = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageSuccessEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageSuccessEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentMessageSuccessEvent).Name}");
                    agentMessageSuccess = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentErrorEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentErrorEvent).Name}");
                    agentError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentGenerationCancelledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentGenerationCancelledEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentGenerationCancelledEvent).Name}");
                    agentGenerationCancelled = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolErrorEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolErrorEvent).Name}");
                    toolError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolParamsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolParamsEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolParamsEvent).Name}");
                    toolParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolApproveExecutionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolApproveExecutionEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolApproveExecutionEvent).Name}");
                    toolApproveExecution = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolNotificationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolNotificationEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolNotificationEvent).Name}");
                    toolNotification = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolPersonalAuthRequiredEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolPersonalAuthRequiredEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolPersonalAuthRequiredEvent).Name}");
                    toolPersonalAuthRequired = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolFileAuthRequiredEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolFileAuthRequiredEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolFileAuthRequiredEvent).Name}");
                    toolFileAuthRequired = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentContextPrunedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentContextPrunedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentContextPrunedEvent).Name}");
                    agentContextPruned = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dust.PrivateAgentMessageEvent(
                generationTokens,

                toolCallStarted,

                agentActionSuccess,

                agentMessageSuccess,

                agentError,

                agentGenerationCancelled,

                toolError,

                toolParams,

                toolApproveExecution,

                toolNotification,

                toolPersonalAuthRequired,

                toolFileAuthRequired,

                agentContextPruned
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.PrivateAgentMessageEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGenerationTokens)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateGenerationTokensEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateGenerationTokensEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateGenerationTokensEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerationTokens!, typeInfo);
            }
            else if (value.IsToolCallStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolCallStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolCallStartedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolCallStartedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallStarted!, typeInfo);
            }
            else if (value.IsAgentActionSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentActionSuccessEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentActionSuccessEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentActionSuccessEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentActionSuccess!, typeInfo);
            }
            else if (value.IsAgentMessageSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageSuccessEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageSuccessEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentMessageSuccessEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentMessageSuccess!, typeInfo);
            }
            else if (value.IsAgentError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentError!, typeInfo);
            }
            else if (value.IsAgentGenerationCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentGenerationCancelledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentGenerationCancelledEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentGenerationCancelledEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentGenerationCancelled!, typeInfo);
            }
            else if (value.IsToolError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolError!, typeInfo);
            }
            else if (value.IsToolParams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolParamsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolParamsEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolParamsEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolParams!, typeInfo);
            }
            else if (value.IsToolApproveExecution)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolApproveExecutionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolApproveExecutionEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolApproveExecutionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolApproveExecution!, typeInfo);
            }
            else if (value.IsToolNotification)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolNotificationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolNotificationEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolNotificationEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolNotification!, typeInfo);
            }
            else if (value.IsToolPersonalAuthRequired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolPersonalAuthRequiredEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolPersonalAuthRequiredEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolPersonalAuthRequiredEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolPersonalAuthRequired!, typeInfo);
            }
            else if (value.IsToolFileAuthRequired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolFileAuthRequiredEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolFileAuthRequiredEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateToolFileAuthRequiredEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolFileAuthRequired!, typeInfo);
            }
            else if (value.IsAgentContextPruned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentContextPrunedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentContextPrunedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentContextPrunedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentContextPruned!, typeInfo);
            }
        }
    }
}