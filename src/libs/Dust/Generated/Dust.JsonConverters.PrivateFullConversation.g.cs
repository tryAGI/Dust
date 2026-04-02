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
            if (__jsonProps.Contains("actionRequired")) __score0++;
            if (__jsonProps.Contains("created")) __score0++;
            if (__jsonProps.Contains("depth")) __score0++;
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
                        privateConversation = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateConversation>(__rawJson, options);
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
                        privateFullConversationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateFullConversationVariant2>(__rawJson, options);
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
                    privateConversation = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateConversation>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    privateFullConversationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateFullConversationVariant2>(__rawJson, options);
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

            if (value.IsPrivateConversation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PrivateConversation, typeof(global::Dust.PrivateConversation), options);
            }
            else if (value.IsPrivateFullConversationVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PrivateFullConversationVariant2, typeof(global::Dust.PrivateFullConversationVariant2), options);
            }
        }
    }
}