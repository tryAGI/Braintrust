#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectAutomationConfigVariant1ActionVariant3SeverityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Severity?>
    {
        /// <inheritdoc />
        public override global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Severity? Read(
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
                        return global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3SeverityExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Severity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Severity?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3Severity? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Braintrust.ProjectAutomationConfigVariant1ActionVariant3SeverityExtensions.ToValueString(value.Value));
            }
        }
    }
}
