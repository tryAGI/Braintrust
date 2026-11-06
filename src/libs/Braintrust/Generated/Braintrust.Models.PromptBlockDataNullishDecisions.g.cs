
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptBlockDataNullishDecisions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.PromptBlockDataNullishDecisionsTypeJsonConverter))]
        public global::Braintrust.PromptBlockDataNullishDecisionsType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>> Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.PromptBlockDataNullishDecisionsQuestion, global::Braintrust.OneOf<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant1, global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2, global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3>?>> Questions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlockDataNullishDecisions" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="questions"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptBlockDataNullishDecisions(
            global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsInputVariant2Item>> input,
            global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.PromptBlockDataNullishDecisionsQuestion, global::Braintrust.OneOf<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant1, global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant2, global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3>?>> questions,
            global::Braintrust.PromptBlockDataNullishDecisionsType type)
        {
            this.Type = type;
            this.Input = input;
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlockDataNullishDecisions" /> class.
        /// </summary>
        public PromptBlockDataNullishDecisions()
        {
        }

    }
}