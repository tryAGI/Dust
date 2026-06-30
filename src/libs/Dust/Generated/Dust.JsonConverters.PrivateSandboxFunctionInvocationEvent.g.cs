#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public class PrivateSandboxFunctionInvocationEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.PrivateSandboxFunctionInvocationEvent>
    {
        /// <inheritdoc />
        public override global::Dust.PrivateSandboxFunctionInvocationEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateSandboxFunctionInvocationEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateSandboxFunctionInvocationEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateSandboxFunctionInvocationEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Dust.PrivateSandboxFunctionInvocationCreatedEvent? sandboxFunctionInvocationCreated = default;
            if (discriminator?.Type == global::Dust.PrivateSandboxFunctionInvocationEventDiscriminatorType.SandboxFunctionInvocationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateSandboxFunctionInvocationCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateSandboxFunctionInvocationCreatedEvent)}");
                sandboxFunctionInvocationCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Dust.PrivateSandboxFunctionInvocationResultEvent? sandboxFunctionInvocationResult = default;
            if (discriminator?.Type == global::Dust.PrivateSandboxFunctionInvocationEventDiscriminatorType.SandboxFunctionInvocationResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateSandboxFunctionInvocationResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateSandboxFunctionInvocationResultEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Dust.PrivateSandboxFunctionInvocationResultEvent)}");
                sandboxFunctionInvocationResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Dust.PrivateSandboxFunctionInvocationEvent(
                discriminator?.Type,
                sandboxFunctionInvocationCreated,

                sandboxFunctionInvocationResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.PrivateSandboxFunctionInvocationEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSandboxFunctionInvocationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateSandboxFunctionInvocationCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateSandboxFunctionInvocationCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SandboxFunctionInvocationCreated!, typeInfo);
            }
            else if (value.IsSandboxFunctionInvocationResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateSandboxFunctionInvocationResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateSandboxFunctionInvocationResultEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateSandboxFunctionInvocationResultEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SandboxFunctionInvocationResult!, typeInfo);
            }
        }
    }
}