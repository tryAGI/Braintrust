#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class PreprocessorIdPreprocessorGlobalTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.PreprocessorIdPreprocessorGlobalType>
    {
        /// <inheritdoc />
        public override global::Braintrust.PreprocessorIdPreprocessorGlobalType Read(
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
                        return global::Braintrust.PreprocessorIdPreprocessorGlobalTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.PreprocessorIdPreprocessorGlobalType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.PreprocessorIdPreprocessorGlobalType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.PreprocessorIdPreprocessorGlobalType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Braintrust.PreprocessorIdPreprocessorGlobalTypeExtensions.ToValueString(value));
        }
    }
}
