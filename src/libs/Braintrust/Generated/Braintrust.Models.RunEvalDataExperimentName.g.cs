
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Experiment whose inputs and outputs should be used as dataset inputs and expected values
    /// </summary>
    public sealed partial class RunEvalDataExperimentName
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataExperimentName" /> class.
        /// </summary>
        /// <param name="experimentName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunEvalDataExperimentName(
            string experimentName)
        {
            this.ExperimentName = experimentName ?? throw new global::System.ArgumentNullException(nameof(experimentName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataExperimentName" /> class.
        /// </summary>
        public RunEvalDataExperimentName()
        {
        }

    }
}