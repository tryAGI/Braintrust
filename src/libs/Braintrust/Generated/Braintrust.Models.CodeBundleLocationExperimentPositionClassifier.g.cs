
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CodeBundleLocationExperimentPositionClassifier
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.CodeBundleLocationExperimentPositionClassifierTypeJsonConverter))]
        public global::Braintrust.CodeBundleLocationExperimentPositionClassifierType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationExperimentPositionClassifier" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeBundleLocationExperimentPositionClassifier(
            int index,
            global::Braintrust.CodeBundleLocationExperimentPositionClassifierType type)
        {
            this.Type = type;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationExperimentPositionClassifier" /> class.
        /// </summary>
        public CodeBundleLocationExperimentPositionClassifier()
        {
        }

    }
}