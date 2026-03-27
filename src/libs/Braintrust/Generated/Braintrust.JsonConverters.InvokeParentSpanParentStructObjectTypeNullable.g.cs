#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class InvokeParentSpanParentStructObjectTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.InvokeParentSpanParentStructObjectType?>
    {
        /// <inheritdoc />
        public override global::Braintrust.InvokeParentSpanParentStructObjectType? Read(
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
                        return global::Braintrust.InvokeParentSpanParentStructObjectTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.InvokeParentSpanParentStructObjectType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.InvokeParentSpanParentStructObjectType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.InvokeParentSpanParentStructObjectType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Braintrust.InvokeParentSpanParentStructObjectTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
