
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Clustering and naming settings used to generate this topic map
    /// </summary>
    public sealed partial class TopicMapGenerationSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.TopicMapGenerationSettingsAlgorithmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.TopicMapGenerationSettingsAlgorithm Algorithm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension_reduction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.TopicMapGenerationSettingsDimensionReductionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.TopicMapGenerationSettingsDimensionReduction DimensionReduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_size")]
        public int? SampleSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_clusters")]
        public int? NClusters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_cluster_size")]
        public int? MinClusterSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_samples")]
        public int? MinSamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy_threshold")]
        public int? HierarchyThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("naming_model")]
        public string? NamingModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicMapGenerationSettings" /> class.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="dimensionReduction"></param>
        /// <param name="sampleSize"></param>
        /// <param name="nClusters"></param>
        /// <param name="minClusterSize"></param>
        /// <param name="minSamples"></param>
        /// <param name="hierarchyThreshold"></param>
        /// <param name="namingModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicMapGenerationSettings(
            global::Braintrust.TopicMapGenerationSettingsAlgorithm algorithm,
            global::Braintrust.TopicMapGenerationSettingsDimensionReduction dimensionReduction,
            int? sampleSize,
            int? nClusters,
            int? minClusterSize,
            int? minSamples,
            int? hierarchyThreshold,
            string? namingModel)
        {
            this.Algorithm = algorithm;
            this.DimensionReduction = dimensionReduction;
            this.SampleSize = sampleSize;
            this.NClusters = nClusters;
            this.MinClusterSize = minClusterSize;
            this.MinSamples = minSamples;
            this.HierarchyThreshold = hierarchyThreshold;
            this.NamingModel = namingModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicMapGenerationSettings" /> class.
        /// </summary>
        public TopicMapGenerationSettings()
        {
        }
    }
}