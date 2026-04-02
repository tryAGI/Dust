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
            if (__jsonProps.Contains("classification")) __score0++;
            if (__jsonProps.Contains("configurationId")) __score0++;
            if (__jsonProps.Contains("created")) __score0++;
            if (__jsonProps.Contains("delimiterClassification")) __score0++;
            if (__jsonProps.Contains("messageId")) __score0++;
            if (__jsonProps.Contains("step")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("action")) __score1++;
            if (__jsonProps.Contains("configurationId")) __score1++;
            if (__jsonProps.Contains("created")) __score1++;
            if (__jsonProps.Contains("messageId")) __score1++;
            if (__jsonProps.Contains("step")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("configurationId")) __score2++;
            if (__jsonProps.Contains("created")) __score2++;
            if (__jsonProps.Contains("message")) __score2++;
            if (__jsonProps.Contains("messageId")) __score2++;
            if (__jsonProps.Contains("runIds")) __score2++;
            if (__jsonProps.Contains("step")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("configurationId")) __score3++;
            if (__jsonProps.Contains("created")) __score3++;
            if (__jsonProps.Contains("error")) __score3++;
            if (__jsonProps.Contains("messageId")) __score3++;
            if (__jsonProps.Contains("runIds")) __score3++;
            if (__jsonProps.Contains("step")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("configurationId")) __score4++;
            if (__jsonProps.Contains("created")) __score4++;
            if (__jsonProps.Contains("messageId")) __score4++;
            if (__jsonProps.Contains("step")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("configurationId")) __score5++;
            if (__jsonProps.Contains("conversationId")) __score5++;
            if (__jsonProps.Contains("created")) __score5++;
            if (__jsonProps.Contains("error")) __score5++;
            if (__jsonProps.Contains("isLastBlockingEventForStep")) __score5++;
            if (__jsonProps.Contains("messageId")) __score5++;
            if (__jsonProps.Contains("step")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("action")) __score6++;
            if (__jsonProps.Contains("configurationId")) __score6++;
            if (__jsonProps.Contains("created")) __score6++;
            if (__jsonProps.Contains("messageId")) __score6++;
            if (__jsonProps.Contains("runIds")) __score6++;
            if (__jsonProps.Contains("step")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("actionId")) __score7++;
            if (__jsonProps.Contains("configurationId")) __score7++;
            if (__jsonProps.Contains("conversationId")) __score7++;
            if (__jsonProps.Contains("created")) __score7++;
            if (__jsonProps.Contains("inputs")) __score7++;
            if (__jsonProps.Contains("isLastBlockingEventForStep")) __score7++;
            if (__jsonProps.Contains("messageId")) __score7++;
            if (__jsonProps.Contains("metadata")) __score7++;
            if (__jsonProps.Contains("stake")) __score7++;
            if (__jsonProps.Contains("step")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("action")) __score8++;
            if (__jsonProps.Contains("configurationId")) __score8++;
            if (__jsonProps.Contains("conversationId")) __score8++;
            if (__jsonProps.Contains("created")) __score8++;
            if (__jsonProps.Contains("messageId")) __score8++;
            if (__jsonProps.Contains("notification")) __score8++;
            if (__jsonProps.Contains("step")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("actionId")) __score9++;
            if (__jsonProps.Contains("authError")) __score9++;
            if (__jsonProps.Contains("configurationId")) __score9++;
            if (__jsonProps.Contains("conversationId")) __score9++;
            if (__jsonProps.Contains("created")) __score9++;
            if (__jsonProps.Contains("messageId")) __score9++;
            if (__jsonProps.Contains("step")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("actionId")) __score10++;
            if (__jsonProps.Contains("configurationId")) __score10++;
            if (__jsonProps.Contains("conversationId")) __score10++;
            if (__jsonProps.Contains("created")) __score10++;
            if (__jsonProps.Contains("fileAuthError")) __score10++;
            if (__jsonProps.Contains("messageId")) __score10++;
            if (__jsonProps.Contains("step")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("configurationId")) __score11++;
            if (__jsonProps.Contains("created")) __score11++;
            if (__jsonProps.Contains("messageId")) __score11++;
            if (__jsonProps.Contains("step")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
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

            global::Dust.PrivateGenerationTokensEvent? generationTokens = default;
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
                        generationTokens = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateGenerationTokensEvent>(__rawJson, options);
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
                        agentActionSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentActionSuccessEvent>(__rawJson, options);
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
                        agentMessageSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentMessageSuccessEvent>(__rawJson, options);
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
                        agentError = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentErrorEvent>(__rawJson, options);
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
                        agentGenerationCancelled = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentGenerationCancelledEvent>(__rawJson, options);
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
                        toolError = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolErrorEvent>(__rawJson, options);
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
                        toolParams = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolParamsEvent>(__rawJson, options);
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
                        toolApproveExecution = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolApproveExecutionEvent>(__rawJson, options);
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
                        toolNotification = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolNotificationEvent>(__rawJson, options);
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
                        toolPersonalAuthRequired = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolPersonalAuthRequiredEvent>(__rawJson, options);
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
                        toolFileAuthRequired = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolFileAuthRequiredEvent>(__rawJson, options);
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
                        agentContextPruned = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentContextPrunedEvent>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (generationTokens == null && agentActionSuccess == null && agentMessageSuccess == null && agentError == null && agentGenerationCancelled == null && toolError == null && toolParams == null && toolApproveExecution == null && toolNotification == null && toolPersonalAuthRequired == null && toolFileAuthRequired == null && agentContextPruned == null)
            {
                try
                {
                    generationTokens = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateGenerationTokensEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    agentActionSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentActionSuccessEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    agentMessageSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentMessageSuccessEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    agentError = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentErrorEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    agentGenerationCancelled = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentGenerationCancelledEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolError = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolErrorEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolParams = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolParamsEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolApproveExecution = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolApproveExecutionEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolNotification = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolNotificationEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolPersonalAuthRequired = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolPersonalAuthRequiredEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolFileAuthRequired = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateToolFileAuthRequiredEvent>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    agentContextPruned = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateAgentContextPrunedEvent>(__rawJson, options);
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

            if (value.IsGenerationTokens)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerationTokens, typeof(global::Dust.PrivateGenerationTokensEvent), options);
            }
            else if (value.IsAgentActionSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentActionSuccess, typeof(global::Dust.PrivateAgentActionSuccessEvent), options);
            }
            else if (value.IsAgentMessageSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentMessageSuccess, typeof(global::Dust.PrivateAgentMessageSuccessEvent), options);
            }
            else if (value.IsAgentError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentError, typeof(global::Dust.PrivateAgentErrorEvent), options);
            }
            else if (value.IsAgentGenerationCancelled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentGenerationCancelled, typeof(global::Dust.PrivateAgentGenerationCancelledEvent), options);
            }
            else if (value.IsToolError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolError, typeof(global::Dust.PrivateToolErrorEvent), options);
            }
            else if (value.IsToolParams)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolParams, typeof(global::Dust.PrivateToolParamsEvent), options);
            }
            else if (value.IsToolApproveExecution)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolApproveExecution, typeof(global::Dust.PrivateToolApproveExecutionEvent), options);
            }
            else if (value.IsToolNotification)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolNotification, typeof(global::Dust.PrivateToolNotificationEvent), options);
            }
            else if (value.IsToolPersonalAuthRequired)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolPersonalAuthRequired, typeof(global::Dust.PrivateToolPersonalAuthRequiredEvent), options);
            }
            else if (value.IsToolFileAuthRequired)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolFileAuthRequired, typeof(global::Dust.PrivateToolFileAuthRequiredEvent), options);
            }
            else if (value.IsAgentContextPruned)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentContextPruned, typeof(global::Dust.PrivateAgentContextPrunedEvent), options);
            }
        }
    }
}