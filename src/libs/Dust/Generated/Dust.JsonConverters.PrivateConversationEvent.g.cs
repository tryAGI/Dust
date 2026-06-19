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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateConversationEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateConversationEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateConversationEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Dust.PrivateUserMessageNewEvent? userMessageNew = default;
            if (discriminator?.Type == global::Dust.PrivateConversationEventDiscriminatorType.UserMessageNew)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateUserMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateUserMessageNewEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateUserMessageNewEvent)}");
                userMessageNew = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateAgentMessageNewEvent? agentMessageNew = default;
            if (discriminator?.Type == global::Dust.PrivateConversationEventDiscriminatorType.AgentMessageNew)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageNewEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateAgentMessageNewEvent)}");
                agentMessageNew = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateAgentMessageDoneEvent? agentMessageDone = default;
            if (discriminator?.Type == global::Dust.PrivateConversationEventDiscriminatorType.AgentMessageDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateAgentMessageDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateAgentMessageDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateAgentMessageDoneEvent)}");
                agentMessageDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateCompactionMessageNewEvent? compactionMessageNew = default;
            if (discriminator?.Type == global::Dust.PrivateConversationEventDiscriminatorType.CompactionMessageNew)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateCompactionMessageNewEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateCompactionMessageNewEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateCompactionMessageNewEvent)}");
                compactionMessageNew = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateCompactionMessageDoneEvent? compactionMessageDone = default;
            if (discriminator?.Type == global::Dust.PrivateConversationEventDiscriminatorType.CompactionMessageDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateCompactionMessageDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateCompactionMessageDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateCompactionMessageDoneEvent)}");
                compactionMessageDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateConversationTitleEvent? conversationTitle = default;
            if (discriminator?.Type == global::Dust.PrivateConversationEventDiscriminatorType.ConversationTitle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateConversationTitleEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateConversationTitleEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateConversationTitleEvent)}");
                conversationTitle = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateWakeUpUpdatedEvent? wakeUpUpdated = default;
            if (discriminator?.Type == global::Dust.PrivateConversationEventDiscriminatorType.WakeUpUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateWakeUpUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateWakeUpUpdatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateWakeUpUpdatedEvent)}");
                wakeUpUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Dust.PrivateConversationEvent(
                discriminator?.Type,
                userMessageNew,

                agentMessageNew,

                agentMessageDone,

                compactionMessageNew,

                compactionMessageDone,

                conversationTitle,

                wakeUpUpdated
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
            else if (value.IsWakeUpUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateWakeUpUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateWakeUpUpdatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateWakeUpUpdatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WakeUpUpdated!, typeInfo);
            }
        }
    }
}