
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptBlockDataDecisionsQuestionVariant3Level
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlockDataDecisionsQuestionVariant3Level" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptBlockDataDecisionsQuestionVariant3Level(
            string label,
            string? description)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlockDataDecisionsQuestionVariant3Level" /> class.
        /// </summary>
        public PromptBlockDataDecisionsQuestionVariant3Level()
        {
        }

    }
}