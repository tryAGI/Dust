#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public class PrivateFullConversationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.PrivateFullConversation>
    {
        /// <inheritdoc />
        public override global::Dust.PrivateFullConversation Read(
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
            if (__jsonProps.Contains("actionRequired")) __score0++;
            if (__jsonProps.Contains("created")) __score0++;
            if (__jsonProps.Contains("depth")) __score0++;
            if (__jsonProps.Contains("forkedChildren")) __score0++;
            if (__jsonProps.Contains("hasError")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("lastReadMs")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("requestedSpaceIds")) __score0++;
            if (__jsonProps.Contains("sId")) __score0++;
            if (__jsonProps.Contains("spaceId")) __score0++;
            if (__jsonProps.Contains("title")) __score0++;
            if (__jsonProps.Contains("triggerId")) __score0++;
            if (__jsonProps.Contains("unread")) __score0++;
            if (__jsonProps.Contains("updated")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("branchId")) __score1++;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("owner")) __score1++;
            if (__jsonProps.Contains("owner.defaultEmbeddingProvider")) __score1++;
            if (__jsonProps.Contains("owner.id")) __score1++;
            if (__jsonProps.Contains("owner.metadata")) __score1++;
            if (__jsonProps.Contains("owner.name")) __score1++;
            if (__jsonProps.Contains("owner.role")) __score1++;
            if (__jsonProps.Contains("owner.sId")) __score1++;
            if (__jsonProps.Contains("owner.segmentation")) __score1++;
            if (__jsonProps.Contains("owner.ssoEnforced")) __score1++;
            if (__jsonProps.Contains("owner.whiteListedProviders")) __score1++;
            if (__jsonProps.Contains("visibility")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Dust.PrivateConversation? privateConversation = default;
            global::Dust.PrivateFullConversationVariant2? privateFullConversationVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateConversation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateConversation> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateConversation).Name}");
                        privateConversation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateFullConversationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateFullConversationVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateFullConversationVariant2).Name}");
                        privateFullConversationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (privateConversation == null && privateFullConversationVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateConversation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateConversation> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateConversation).Name}");
                    privateConversation = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateFullConversationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateFullConversationVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateFullConversationVariant2).Name}");
                    privateFullConversationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dust.PrivateFullConversation(
                privateConversation,

                privateFullConversationVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.PrivateFullConversation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPrivateConversation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateConversation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateConversation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateConversation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PrivateConversation!, typeInfo);
            }
            else if (value.IsPrivateFullConversationVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dust.PrivateFullConversationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dust.PrivateFullConversationVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dust.PrivateFullConversationVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PrivateFullConversationVariant2!, typeInfo);
            }
        }
    }
}