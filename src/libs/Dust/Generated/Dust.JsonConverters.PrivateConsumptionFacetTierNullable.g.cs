#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class PrivateConsumptionFacetTierNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.PrivateConsumptionFacetTier?>
    {
        /// <inheritdoc />
        public override global::Dust.PrivateConsumptionFacetTier? Read(
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
                        return global::Dust.PrivateConsumptionFacetTierExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.PrivateConsumptionFacetTier)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.PrivateConsumptionFacetTier?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.PrivateConsumptionFacetTier? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dust.PrivateConsumptionFacetTierExtensions.ToValueString(value.Value));
            }
        }
    }
}
