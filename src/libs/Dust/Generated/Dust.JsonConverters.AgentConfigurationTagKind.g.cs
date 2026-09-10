#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentConfigurationTagKindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.AgentConfigurationTagKind>
    {
        /// <inheritdoc />
        public override global::Dust.AgentConfigurationTagKind Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Dust.AgentConfigurationTagKindExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.AgentConfigurationTagKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.AgentConfigurationTagKind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.AgentConfigurationTagKind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Dust.AgentConfigurationTagKindExtensions.ToValueString(value));
        }
    }
}
