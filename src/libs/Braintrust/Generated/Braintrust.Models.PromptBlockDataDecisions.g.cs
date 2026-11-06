
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptBlockDataDecisions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.PromptBlockDataDecisionsTypeJsonConverter))]
        public global::Braintrust.PromptBlockDataDecisionsType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>> Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.PromptBlockDataDecisionsQuestion, global::Braintrust.OneOf<global::Braintrust.PromptBlockDataDecisionsQuestionVariant1, global::Braintrust.PromptBlockDataDecisionsQuestionVariant2, global::Braintrust.PromptBlockDataDecisionsQuestionVariant3>?>> Questions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlockDataDecisions" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="questions"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptBlockDataDecisions(
            global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataDecisionsInputVariant2Item>> input,
            global::System.Collections.Generic.IList<global::Braintrust.AllOf<global::Braintrust.PromptBlockDataDecisionsQuestion, global::Braintrust.OneOf<global::Braintrust.PromptBlockDataDecisionsQuestionVariant1, global::Braintrust.PromptBlockDataDecisionsQuestionVariant2, global::Braintrust.PromptBlockDataDecisionsQuestionVariant3>?>> questions,
            global::Braintrust.PromptBlockDataDecisionsType type)
        {
            this.Type = type;
            this.Input = input;
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlockDataDecisions" /> class.
        /// </summary>
        public PromptBlockDataDecisions()
        {
        }

    }
}