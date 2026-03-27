#nullable enable

namespace Braintrust.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeBundleLocationExperimentPositionScorerTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Braintrust.CodeBundleLocationExperimentPositionScorerType>
    {
        /// <inheritdoc />
        public override global::Braintrust.CodeBundleLocationExperimentPositionScorerType Read(
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
                        return global::Braintrust.CodeBundleLocationExperimentPositionScorerTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Braintrust.CodeBundleLocationExperimentPositionScorerType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Braintrust.CodeBundleLocationExperimentPositionScorerType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Braintrust.CodeBundleLocationExperimentPositionScorerType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Braintrust.CodeBundleLocationExperimentPositionScorerTypeExtensions.ToValueString(value));
        }
    }
}
