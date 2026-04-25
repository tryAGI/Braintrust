
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Braintrust-controlled metadata about the experiment.
    /// </summary>
    public sealed partial class PatchExperimentInternalMetadata
    {
        /// <summary>
        /// BTQL filter payload used to evaluate a subset of a linked dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_filter")]
        public global::System.Collections.Generic.Dictionary<string, object?>? DatasetFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchExperimentInternalMetadata" /> class.
        /// </summary>
        /// <param name="datasetFilter">
        /// BTQL filter payload used to evaluate a subset of a linked dataset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchExperimentInternalMetadata(
            global::System.Collections.Generic.Dictionary<string, object?>? datasetFilter)
        {
            this.DatasetFilter = datasetFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchExperimentInternalMetadata" /> class.
        /// </summary>
        public PatchExperimentInternalMetadata()
        {
        }
    }
}