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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("created")) __score0++;
            if (__jsonProps.Contains("message")) __score0++;
            if (__jsonProps.Contains("messageId")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("configurationId")) __score1++;
            if (__jsonProps.Contains("created")) __score1++;
            if (__jsonProps.Contains("message")) __score1++;
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
            if (__jsonProps.Contains("title")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("created")) __score4++;
            if (__jsonProps.Contains("suggestion")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("created")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("created")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::Dust.PrivateUserMessageNewEvent? userMessageNew = default;
            global::Dust.PrivateAgentMessageNewEvent? agentMessageNew = default;
            global::Dust.PrivateAgentMessageDoneEvent? agentMessageDone = default;
            global::Dust.PrivateConversationTitleEvent? conversationTitle = default;
            global::Dust.PrivateButlerSuggestionCreatedEvent? butlerSuggestionCreated = default;
            global::Dust.PrivateButlerThinkingEvent? butlerThinking = default;
            global::Dust.PrivateButlerDoneEvent? butlerDone = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        userMessageNew = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateUserMessageNewEvent>(__rawJson, options);
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
                        agentMessageNew = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentMessageNewEvent>(__rawJson, options);
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
                        agentMessageDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentMessageDoneEvent>(__rawJson, options);
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
                        conversationTitle = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateConversationTitleEvent>(__rawJson, options);
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
                        butlerSuggestionCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateButlerSuggestionCreatedEvent>(__rawJson, options);
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
                        butlerThinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateButlerThinkingEvent>(__rawJson, options);
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
                        butlerDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateButlerDoneEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (userMessageNew == null && agentMessageNew == null && agentMessageDone == null && conversationTitle == null && butlerSuggestionCreated == null && butlerThinking == null && butlerDone == null)
            {
                try
                {
                    userMessageNew = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateUserMessageNewEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    agentMessageNew = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentMessageNewEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    agentMessageDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentMessageDoneEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationTitle = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateConversationTitleEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    butlerSuggestionCreated = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateButlerSuggestionCreatedEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    butlerThinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateButlerThinkingEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    butlerDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateButlerDoneEvent>(__rawJson, options);
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

                conversationTitle,

                butlerSuggestionCreated,

                butlerThinking,

                butlerDone
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

            if (value.IsUserMessageNew)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessageNew, typeof(global::Dust.PrivateUserMessageNewEvent), options);
            }
            else if (value.IsAgentMessageNew)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentMessageNew, typeof(global::Dust.PrivateAgentMessageNewEvent), options);
            }
            else if (value.IsAgentMessageDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentMessageDone, typeof(global::Dust.PrivateAgentMessageDoneEvent), options);
            }
            else if (value.IsConversationTitle)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationTitle, typeof(global::Dust.PrivateConversationTitleEvent), options);
            }
            else if (value.IsButlerSuggestionCreated)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ButlerSuggestionCreated, typeof(global::Dust.PrivateButlerSuggestionCreatedEvent), options);
            }
            else if (value.IsButlerThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ButlerThinking, typeof(global::Dust.PrivateButlerThinkingEvent), options);
            }
            else if (value.IsButlerDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ButlerDone, typeof(global::Dust.PrivateButlerDoneEvent), options);
            }
        }
    }
}