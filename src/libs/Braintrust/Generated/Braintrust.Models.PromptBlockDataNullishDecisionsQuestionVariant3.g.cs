
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptBlockDataNullishDecisionsQuestionVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.PromptBlockDataNullishDecisionsQuestionVariant3TypeJsonConverter))]
        public global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("levels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Level> Levels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlockDataNullishDecisionsQuestionVariant3" /> class.
        /// </summary>
        /// <param name="levels"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptBlockDataNullishDecisionsQuestionVariant3(
            global::System.Collections.Generic.IList<global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Level> levels,
            global::Braintrust.PromptBlockDataNullishDecisionsQuestionVariant3Type type)
        {
            this.Type = type;
            this.Levels = levels ?? throw new global::System.ArgumentNullException(nameof(levels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlockDataNullishDecisionsQuestionVariant3" /> class.
        /// </summary>
        public PromptBlockDataNullishDecisionsQuestionVariant3()
        {
        }

    }
}