
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicMapData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.TopicMapDataTypeJsonConverter))]
        public global::Braintrust.TopicMapDataType Type { get; set; }

        /// <summary>
        /// Materialized facet field name used when source_facet_function is absent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_facet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceFacet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_facet_function")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AllOfJsonConverter<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>?>))]
        public global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>?>? SourceFacetFunction { get; set; }

        /// <summary>
        /// The embedding model to use for embedding facet values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmbeddingModel { get; set; }

        /// <summary>
        /// Key of the topic map bundle in code_bundles bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_key")]
        public string? BundleKey { get; set; }

        /// <summary>
        /// Key of the clustering report in code_bundles bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_key")]
        public string? ReportKey { get; set; }

        /// <summary>
        /// Mapping from topic_id to topic name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_names")]
        public global::System.Collections.Generic.Dictionary<string, string>? TopicNames { get; set; }

        /// <summary>
        /// Clustering and naming settings used to generate this topic map
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_settings")]
        public global::Braintrust.TopicMapGenerationSettings? GenerationSettings { get; set; }

        /// <summary>
        /// Whether new topic generation should ignore the previously saved report during reconciliation. Defaults to false when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_reconciliation")]
        public bool? DisableReconciliation { get; set; }

        /// <summary>
        /// How reconciliation carries the previous map forward: "evolve" re-routes new samples into the previous topics before naming; "names_only" keeps the fresh clustering and carries only topic ids/names. Defaults to "names_only" when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reconcile_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.TopicMapDataReconcileModeJsonConverter))]
        public global::Braintrust.TopicMapDataReconcileMode? ReconcileMode { get; set; }

        /// <summary>
        /// Maximum distance to nearest centroid. If exceeded, returns no_match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_threshold")]
        public double? DistanceThreshold { get; set; }

        /// <summary>
        /// Per-topic-map BTQL filter that was applied when this version was generated. Absent on versions generated before this was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btql_filter")]
        public string? BtqlFilter { get; set; }

        /// <summary>
        /// Automation-level BTQL filter that was applied when this version was generated. Absent on versions generated before this was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automation_btql_filter")]
        public string? AutomationBtqlFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicMapData" /> class.
        /// </summary>
        /// <param name="sourceFacet">
        /// Materialized facet field name used when source_facet_function is absent
        /// </param>
        /// <param name="embeddingModel">
        /// The embedding model to use for embedding facet values
        /// </param>
        /// <param name="type"></param>
        /// <param name="sourceFacetFunction"></param>
        /// <param name="bundleKey">
        /// Key of the topic map bundle in code_bundles bucket
        /// </param>
        /// <param name="reportKey">
        /// Key of the clustering report in code_bundles bucket
        /// </param>
        /// <param name="topicNames">
        /// Mapping from topic_id to topic name
        /// </param>
        /// <param name="generationSettings">
        /// Clustering and naming settings used to generate this topic map
        /// </param>
        /// <param name="disableReconciliation">
        /// Whether new topic generation should ignore the previously saved report during reconciliation. Defaults to false when omitted.
        /// </param>
        /// <param name="reconcileMode">
        /// How reconciliation carries the previous map forward: "evolve" re-routes new samples into the previous topics before naming; "names_only" keeps the fresh clustering and carries only topic ids/names. Defaults to "names_only" when omitted.
        /// </param>
        /// <param name="distanceThreshold">
        /// Maximum distance to nearest centroid. If exceeded, returns no_match.
        /// </param>
        /// <param name="btqlFilter">
        /// Per-topic-map BTQL filter that was applied when this version was generated. Absent on versions generated before this was recorded.
        /// </param>
        /// <param name="automationBtqlFilter">
        /// Automation-level BTQL filter that was applied when this version was generated. Absent on versions generated before this was recorded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicMapData(
            string sourceFacet,
            string embeddingModel,
            global::Braintrust.TopicMapDataType type,
            global::Braintrust.AllOf<global::Braintrust.SavedFunctionId?, global::Braintrust.AnyOf<global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Function, global::Braintrust.TopicMapDataSourceFacetFunctionVariant2Global>?>? sourceFacetFunction,
            string? bundleKey,
            string? reportKey,
            global::System.Collections.Generic.Dictionary<string, string>? topicNames,
            global::Braintrust.TopicMapGenerationSettings? generationSettings,
            bool? disableReconciliation,
            global::Braintrust.TopicMapDataReconcileMode? reconcileMode,
            double? distanceThreshold,
            string? btqlFilter,
            string? automationBtqlFilter)
        {
            this.Type = type;
            this.SourceFacet = sourceFacet ?? throw new global::System.ArgumentNullException(nameof(sourceFacet));
            this.SourceFacetFunction = sourceFacetFunction;
            this.EmbeddingModel = embeddingModel ?? throw new global::System.ArgumentNullException(nameof(embeddingModel));
            this.BundleKey = bundleKey;
            this.ReportKey = reportKey;
            this.TopicNames = topicNames;
            this.GenerationSettings = generationSettings;
            this.DisableReconciliation = disableReconciliation;
            this.ReconcileMode = reconcileMode;
            this.DistanceThreshold = distanceThreshold;
            this.BtqlFilter = btqlFilter;
            this.AutomationBtqlFilter = automationBtqlFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicMapData" /> class.
        /// </summary>
        public TopicMapData()
        {
        }

    }
}