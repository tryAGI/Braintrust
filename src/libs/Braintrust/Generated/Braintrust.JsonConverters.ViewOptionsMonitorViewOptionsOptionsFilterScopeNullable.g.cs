#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class ViewOptionsMonitorViewOptionsOptionsFilterScopeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.ViewOptionsMonitorViewOptionsOptionsFilterScope?>
    {
        /// <inheritdoc />
        public override global::Braintrust.ViewOptionsMonitorViewOptionsOptionsFilterScope? Read(
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
                        return global::Braintrust.ViewOptionsMonitorViewOptionsOptionsFilterScopeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.ViewOptionsMonitorViewOptionsOptionsFilterScope)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsFilterScope?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.ViewOptionsMonitorViewOptionsOptionsFilterScope? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Braintrust.ViewOptionsMonitorViewOptionsOptionsFilterScopeExtensions.ToValueString(value.Value));
            }
        }
    }
}
