#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public class PrivateConversationEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.PrivateConversationEvent>
    {
        /// <inheritdoc />
        public override global::Dust.PrivateConversationEvent Read(
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
            if (__jsonProps.Contains("created")) __score0++;
            if (__jsonProps.Contains("message")) __score0++;
            if (__jsonProps.Contains("message.content")) __score0++;
            if (__jsonProps.Contains("message.context")) __score0++;
            if (__jsonProps.Contains("message.created")) __score0++;
            if (__jsonProps.Contains("message.id")) __score0++;
            if (__jsonProps.Contains("message.mentions")) __score0++;
            if (__jsonProps.Contains("message.rank")) __score0++;
            if (__jsonProps.Contains("message.reactions")) __score0++;
            if (__jsonProps.Contains("message.richMentions")) __score0++;
            if (__jsonProps.Contains("message.sId")) __score0++;
            if (__jsonProps.Contains("message.type")) __score0++;
            if (__jsonProps.Contains("message.user")) __score0++;
            if (__jsonProps.Contains("message.version")) __score0++;
            if (__jsonProps.Contains("message.visibility")) __score0++;
            if (__jsonProps.Contains("messageId")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("configurationId")) __score1++;
            if (__jsonProps.Contains("created")) __score1++;
            if (__jsonProps.Contains("message")) __score1++;
            if (__jsonProps.Contains("message.actions")) __score1++;
            if (__jsonProps.Contains("message.agentMessageId")) __score1++;
            if (__jsonProps.Contains("message.chainOfThought")) __score1++;
            if (__jsonProps.Contains("message.completedTs")) __score1++;
            if (__jsonProps.Contains("message.completionDurationMs")) __score1++;
            if (__jsonProps.Contains("message.configuration")) __score1++;
            if (__jsonProps.Contains("message.content")) __score1++;
            if (__jsonProps.Contains("message.contents")) __score1++;
            if (__jsonProps.Contains("message.created")) __score1++;
            if (__jsonProps.Contains("message.error")) __score1++;
            if (__jsonProps.Contains("message.id")) __score1++;
            if (__jsonProps.Contains("message.parentAgentMessageId")) __score1++;
            if (__jsonProps.Contains("message.parentMessageId")) __score1++;
            if (__jsonProps.Contains("message.rank")) __score1++;
            if (__jsonProps.Contains("message.reactions")) __score1++;
            if (__jsonProps.Contains("message.richMentions")) __score1++;
            if (__jsonProps.Contains("message.sId")) __score1++;
            if (__jsonProps.Contains("message.skipToolsValidation")) __score1++;
            if (__jsonProps.Contains("message.status")) __score1++;
            if (__jsonProps.Contains("message.type")) __score1++;
            if (__jsonProps.Contains("message.version")) __score1++;
            if (__jsonProps.Contains("message.visibility")) __score1++;
            if (__jsonProps.Contains("messageId")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("configurationId")) __score2++;
            if (__jsonProps.Contains("conversationId")) __score2++;
            if (__jsonProps.Contains("created")) __score2++;
            if (__jsonProps.Contains("messageId")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("created")) __score3++;
            if (__jsonProps.Contains("message")) __score3++;
            if (__jsonProps.Contains("message.branchId")) __score3++;
            if (__jsonProps.Contains("message.compactionMessageId")) __score3++;
            if (__jsonProps.Contains("message.content")) __score3++;
            if (__jsonProps.Contains("message.created")) __score3++;
            if (__jsonProps.Contains("message.id")) __score3++;
            if (__jsonProps.Contains("message.rank")) __score3++;
            if (__jsonProps.Contains("message.sId")) __score3++;
            if (__jsonProps.Contains("message.status")) __score3++;
            if (__jsonProps.Contains("message.type")) __score3++;
            if (__jsonProps.Contains("message.version")) __score3++;
            if (__jsonProps.Contains("message.visibility")) __score3++;
            if (__jsonProps.Contains("messageId")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("created")) __score4++;
            if (__jsonProps.Contains("message")) __score4++;
            if (__jsonProps.Contains("message.branchId")) __score4++;
            if (__jsonProps.Contains("message.compactionMessageId")) __score4++;
            if (__jsonProps.Contains("message.content")) __score4++;
            if (__jsonProps.Contains("message.created")) __score4++;
            if (__jsonProps.Contains("message.id")) __score4++;
            if (__jsonProps.Contains("message.rank")) __score4++;
            if (__jsonProps.Contains("message.sId")) __score4++;
            if (__jsonProps.Contains("message.status")) __score4++;
            if (__jsonProps.Contains("message.type")) __score4++;
            if (__jsonProps.Contains("message.version")) __score4++;
            if (__jsonProps.Contains("message.visibility")) __score4++;
            if (__jsonProps.Contains("messageId")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("created")) __score5++;
            if (__jsonProps.Contains("title")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::Dust.PrivateUserMessageNewEvent? userMessageNew = default;
            global::Dust.PrivateAgentMessageNewEvent? agentMessageNew = default;
            global::Dust.PrivateAgentMessageDoneEvent? agentMessageDone = default;
            global::Dust.PrivateCompactionMessageNewEvent? compactionMessageNew = default;
            global::Dust.PrivateCompactionMessageDoneEvent? compactionMessageDone = default;
            global::Dust.PrivateConversationTitleEvent? conversationTitle = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateUserMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateUserMessageNewEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateUserMessageNewEvent).Name}");
                        userMessageNew = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageNewEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentMessageNewEvent).Name}");
                        agentMessageNew = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentMessageDoneEvent).Name}");
                        agentMessageDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateCompactionMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateCompactionMessageNewEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateCompactionMessageNewEvent).Name}");
                        compactionMessageNew = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateCompactionMessageDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateCompactionMessageDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateCompactionMessageDoneEvent).Name}");
                        compactionMessageDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateConversationTitleEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateConversationTitleEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateConversationTitleEvent).Name}");
                        conversationTitle = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (userMessageNew == null && agentMessageNew == null && agentMessageDone == null && compactionMessageNew == null && compactionMessageDone == null && conversationTitle == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateUserMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateUserMessageNewEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateUserMessageNewEvent).Name}");
                    userMessageNew = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageNewEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentMessageNewEvent).Name}");
                    agentMessageNew = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentMessageDoneEvent).Name}");
                    agentMessageDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateCompactionMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateCompactionMessageNewEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateCompactionMessageNewEvent).Name}");
                    compactionMessageNew = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateCompactionMessageDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateCompactionMessageDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateCompactionMessageDoneEvent).Name}");
                    compactionMessageDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateConversationTitleEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateConversationTitleEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateConversationTitleEvent).Name}");
                    conversationTitle = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dust.PrivateConversationEvent(
                userMessageNew,

                agentMessageNew,

                agentMessageDone,

                compactionMessageNew,

                compactionMessageDone,

                conversationTitle
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.PrivateConversationEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUserMessageNew)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateUserMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateUserMessageNewEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateUserMessageNewEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessageNew!, typeInfo);
            }
            else if (value.IsAgentMessageNew)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageNewEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentMessageNewEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentMessageNew!, typeInfo);
            }
            else if (value.IsAgentMessageDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateAgentMessageDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentMessageDone!, typeInfo);
            }
            else if (value.IsCompactionMessageNew)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateCompactionMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateCompactionMessageNewEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateCompactionMessageNewEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompactionMessageNew!, typeInfo);
            }
            else if (value.IsCompactionMessageDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateCompactionMessageDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateCompactionMessageDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateCompactionMessageDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompactionMessageDone!, typeInfo);
            }
            else if (value.IsConversationTitle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateConversationTitleEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateConversationTitleEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateConversationTitleEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationTitle!, typeInfo);
            }
        }
    }
}