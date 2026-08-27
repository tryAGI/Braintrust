#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class TopicMapDataSourceFacetFunctionVariant2GlobalTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType>
    {
        /// <inheritdoc />
        public override global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType Read(
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
                        return global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Braintrust.TopicMapDataSourceFacetFunctionVariant2GlobalTypeExtensions.ToValueString(value));
        }
    }
}
