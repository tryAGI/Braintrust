#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class WindowedAutomationConfigProductOriginNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.WindowedAutomationConfigProductOrigin?>
    {
        /// <inheritdoc />
        public override global::Braintrust.WindowedAutomationConfigProductOrigin? Read(
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
                        return global::Braintrust.WindowedAutomationConfigProductOriginExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.WindowedAutomationConfigProductOrigin)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.WindowedAutomationConfigProductOrigin?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.WindowedAutomationConfigProductOrigin? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Braintrust.WindowedAutomationConfigProductOriginExtensions.ToValueString(value.Value));
            }
        }
    }
}
