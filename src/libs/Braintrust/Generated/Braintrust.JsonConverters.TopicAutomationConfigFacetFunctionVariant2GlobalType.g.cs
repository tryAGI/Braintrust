#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class TopicAutomationConfigFacetFunctionVariant2GlobalTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType>
    {
        /// <inheritdoc />
        public override global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType Read(
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
                        return global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Braintrust.TopicAutomationConfigFacetFunctionVariant2GlobalTypeExtensions.ToValueString(value));
        }
    }
}
