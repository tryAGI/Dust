#nullable enable

namespace Dust.JsonConverters
{
    /// <inheritdoc />
    public sealed class PrivateSandboxFunctionInvocationCreatedEventInvocationStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus?>
    {
        /// <inheritdoc />
        public override global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus? Read(
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
                        return global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dust.PrivateSandboxFunctionInvocationCreatedEventInvocationStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
