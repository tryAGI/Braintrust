
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Settings of the Patterns automation
    /// </summary>
    public sealed partial class WindowedAutomationConfigPatterns
    {
        /// <summary>
        /// Saved preprocessor that renders traces for the project's pattern questions. The project default when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preprocessor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.SavedPreprocessorIdJsonConverter))]
        public global::Braintrust.SavedPreprocessorId? Preprocessor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigPatterns" /> class.
        /// </summary>
        /// <param name="preprocessor">
        /// Saved preprocessor that renders traces for the project's pattern questions. The project default when unset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigPatterns(
            global::Braintrust.SavedPreprocessorId? preprocessor)
        {
            this.Preprocessor = preprocessor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigPatterns" /> class.
        /// </summary>
        public WindowedAutomationConfigPatterns()
        {
        }

    }
}