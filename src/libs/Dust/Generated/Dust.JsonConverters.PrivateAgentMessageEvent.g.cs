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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateAgentMessageEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Dust.PrivateGenerationTokensEvent? generationTokens = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.GenerationTokens)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateGenerationTokensEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateGenerationTokensEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateGenerationTokensEvent)}");
                generationTokens = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateToolCallStartedEvent? toolCallStarted = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.ToolCallStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolCallStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolCallStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateToolCallStartedEvent)}");
                toolCallStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateAgentActionSuccessEvent? agentActionSuccess = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.AgentActionSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentActionSuccessEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentActionSuccessEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateAgentActionSuccessEvent)}");
                agentActionSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateAgentMessageSuccessEvent? agentMessageSuccess = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.AgentMessageSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageSuccessEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageSuccessEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateAgentMessageSuccessEvent)}");
                agentMessageSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateAgentErrorEvent? agentError = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.AgentError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateAgentErrorEvent)}");
                agentError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateAgentGenerationCancelledEvent? agentGenerationCancelled = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.AgentGenerationCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentGenerationCancelledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentGenerationCancelledEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateAgentGenerationCancelledEvent)}");
                agentGenerationCancelled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateToolErrorEvent? toolError = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.ToolError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateToolErrorEvent)}");
                toolError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateToolParamsEvent? toolParams = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.ToolParams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolParamsEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolParamsEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateToolParamsEvent)}");
                toolParams = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateToolApproveExecutionEvent? toolApproveExecution = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.ToolApproveExecution)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolApproveExecutionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolApproveExecutionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateToolApproveExecutionEvent)}");
                toolApproveExecution = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateToolNotificationEvent? toolNotification = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.ToolNotification)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolNotificationEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolNotificationEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateToolNotificationEvent)}");
                toolNotification = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateToolPersonalAuthRequiredEvent? toolPersonalAuthRequired = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.ToolPersonalAuthRequired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolPersonalAuthRequiredEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolPersonalAuthRequiredEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateToolPersonalAuthRequiredEvent)}");
                toolPersonalAuthRequired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateToolFileAuthRequiredEvent? toolFileAuthRequired = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.ToolFileAuthRequired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateToolFileAuthRequiredEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateToolFileAuthRequiredEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateToolFileAuthRequiredEvent)}");
                toolFileAuthRequired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateAgentContextPrunedEvent? agentContextPruned = default;
            if (discriminator?.Type == global::Dust.PrivateAgentMessageEventDiscriminatorType.AgentContextPruned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentContextPrunedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentContextPrunedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateAgentContextPrunedEvent)}");
                agentContextPruned = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Dust.PrivateAgentMessageEvent(
                discriminator?.Type,
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