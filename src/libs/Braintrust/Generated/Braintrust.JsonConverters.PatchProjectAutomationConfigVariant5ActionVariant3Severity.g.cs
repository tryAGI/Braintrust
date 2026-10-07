#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchProjectAutomationConfigVariant5ActionVariant3SeverityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Severity>
    {
        /// <inheritdoc />
        public override global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Severity Read(
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
                        return global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3SeverityExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Severity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Severity);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3Severity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Braintrust.PatchProjectAutomationConfigVariant5ActionVariant3SeverityExtensions.ToValueString(value));
        }
    }
}
