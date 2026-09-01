#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class PrivateFrameFunctionInvocationResponseOutcomeVariant1StatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1Status?>
    {
        /// <inheritdoc />
        public override global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1Status? Read(
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
                        return global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1StatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1Status)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1Status?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1Status? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dust.PrivateFrameFunctionInvocationResponseOutcomeVariant1StatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
