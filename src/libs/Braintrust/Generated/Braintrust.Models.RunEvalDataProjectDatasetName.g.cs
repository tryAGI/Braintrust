
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Project and dataset name
    /// </summary>
    public sealed partial class RunEvalDataProjectDatasetName
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// The version of the dataset to evaluate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_version")]
        public string? DatasetVersion { get; set; }

        /// <summary>
        /// The environment tag that resolves to the dataset version to evaluate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_environment")]
        public string? DatasetEnvironment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_internal_btql")]
        public global::System.Collections.Generic.Dictionary<string, object?>? InternalBtql { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataProjectDatasetName" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="datasetName"></param>
        /// <param name="datasetVersion">
        /// The version of the dataset to evaluate
        /// </param>
        /// <param name="datasetEnvironment">
        /// The environment tag that resolves to the dataset version to evaluate
        /// </param>
        /// <param name="internalBtql"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunEvalDataProjectDatasetName(
            string projectName,
            string datasetName,
            string? datasetVersion,
            string? datasetEnvironment,
            global::System.Collections.Generic.Dictionary<string, object?>? internalBtql)
        {
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.DatasetVersion = datasetVersion;
            this.DatasetEnvironment = datasetEnvironment;
            this.InternalBtql = internalBtql;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataProjectDatasetName" /> class.
        /// </summary>
        public RunEvalDataProjectDatasetName()
        {
        }

    }
}