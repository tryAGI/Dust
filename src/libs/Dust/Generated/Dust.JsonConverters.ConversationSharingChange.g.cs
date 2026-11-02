#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public class ConversationSharingChangeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.ConversationSharingChange>
    {
        /// <inheritdoc />
        public override global::Dust.ConversationSharingChange Read(
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

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("email")) __score0++;
            if (__jsonProps.Contains("permission")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("groupName")) __score1++;
            if (__jsonProps.Contains("permission")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Dust.ConversationSharingChangeVariant1? conversationSharingChangeVariant1 = default;
            global::Dust.ConversationSharingChangeVariant2? conversationSharingChangeVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.ConversationSharingChangeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.ConversationSharingChangeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.ConversationSharingChangeVariant1).Name}");
                        conversationSharingChangeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.ConversationSharingChangeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.ConversationSharingChangeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.ConversationSharingChangeVariant2).Name}");
                        conversationSharingChangeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (conversationSharingChangeVariant1 == null && conversationSharingChangeVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.ConversationSharingChangeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.ConversationSharingChangeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.ConversationSharingChangeVariant1).Name}");
                    conversationSharingChangeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (conversationSharingChangeVariant1 == null && conversationSharingChangeVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.ConversationSharingChangeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.ConversationSharingChangeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.ConversationSharingChangeVariant2).Name}");
                    conversationSharingChangeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::Dust.ConversationSharingChange(
                conversationSharingChangeVariant1,

                conversationSharingChangeVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.ConversationSharingChange value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationSharingChangeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.ConversationSharingChangeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.ConversationSharingChangeVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.ConversationSharingChangeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConversationSharingChangeVariant1(), typeInfo);
            }
            else if (value.IsConversationSharingChangeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.ConversationSharingChangeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.ConversationSharingChangeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.ConversationSharingChangeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConversationSharingChangeVariant2(), typeInfo);
            }
        }
    }
}