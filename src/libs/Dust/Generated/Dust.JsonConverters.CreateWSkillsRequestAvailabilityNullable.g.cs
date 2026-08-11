#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateWSkillsRequestAvailabilityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.CreateWSkillsRequestAvailability?>
    {
        /// <inheritdoc />
        public override global::Dust.CreateWSkillsRequestAvailability? Read(
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
                        return global::Dust.CreateWSkillsRequestAvailabilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.CreateWSkillsRequestAvailability)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.CreateWSkillsRequestAvailability?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.CreateWSkillsRequestAvailability? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dust.CreateWSkillsRequestAvailabilityExtensions.ToValueString(value.Value));
            }
        }
    }
}
