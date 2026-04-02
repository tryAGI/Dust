#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public class PrivateProjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.PrivateProject>
    {
        /// <inheritdoc />
        public override global::Dust.PrivateProject Read(
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
            if (__jsonProps.Contains("createdAt")) __score0++;
            if (__jsonProps.Contains("groupIds")) __score0++;
            if (__jsonProps.Contains("isRestricted")) __score0++;
            if (__jsonProps.Contains("kind")) __score0++;
            if (__jsonProps.Contains("managementMode")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("sId")) __score0++;
            if (__jsonProps.Contains("updatedAt")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("archivedAt")) __score1++;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("isMember")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Dust.PrivateSpace? space = default;
            global::Dust.PrivateProjectVariant2? privateProjectVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        space = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateSpace>(__rawJson, options);
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
                        privateProjectVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateProjectVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (space == null && privateProjectVariant2 == null)
            {
                try
                {
                    space = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateSpace>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    privateProjectVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dust.PrivateProjectVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dust.PrivateProject(
                space,

                privateProjectVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.PrivateProject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSpace)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Space, typeof(global::Dust.PrivateSpace), options);
            }
            else if (value.IsPrivateProjectVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PrivateProjectVariant2, typeof(global::Dust.PrivateProjectVariant2), options);
            }
        }
    }
}