
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeBundleLocationExperiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentTypeJsonConverter))]
        public global::Braintrust.CodeBundleLocationExperimentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvalName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer> Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationExperiment" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="evalName"></param>
        /// <param name="position"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeBundleLocationExperiment(
            string evalName,
            global::Braintrust.AnyOf<global::Braintrust.CodeBundleLocationExperimentPositionVariant1, global::Braintrust.CodeBundleLocationExperimentPositionScorer> position,
            global::Braintrust.CodeBundleLocationExperimentType type)
        {
            this.EvalName = evalName ?? throw new global::System.ArgumentNullException(nameof(evalName));
            this.Position = position;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationExperiment" /> class.
        /// </summary>
        public CodeBundleLocationExperiment()
        {
        }
    }
}