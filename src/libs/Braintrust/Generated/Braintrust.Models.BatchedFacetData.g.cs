
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchedFacetData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.BatchedFacetDataTypeJsonConverter))]
        public global::Braintrust.BatchedFacetDataType Type { get; set; }

        /// <summary>
        /// The saved, global, or inline preprocessor to use for facet extraction. If not provided, the project default preprocessor will be used, falling back to the global 'thread' preprocessor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preprocessor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FacetPreprocessorIdJsonConverter))]
        public global::Braintrust.FacetPreprocessorId? Preprocessor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataFacet> Facets { get; set; }

        /// <summary>
        /// Topic maps that depend on facets in this batch, keyed by source facet name. Each source facet can have multiple topic maps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_maps")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>>? TopicMaps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchedFacetData" /> class.
        /// </summary>
        /// <param name="facets"></param>
        /// <param name="type"></param>
        /// <param name="preprocessor">
        /// The saved, global, or inline preprocessor to use for facet extraction. If not provided, the project default preprocessor will be used, falling back to the global 'thread' preprocessor.
        /// </param>
        /// <param name="topicMaps">
        /// Topic maps that depend on facets in this batch, keyed by source facet name. Each source facet can have multiple topic maps.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchedFacetData(
            global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataFacet> facets,
            global::Braintrust.BatchedFacetDataType type,
            global::Braintrust.FacetPreprocessorId? preprocessor,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Braintrust.BatchedFacetDataTopicMap>>? topicMaps)
        {
            this.Type = type;
            this.Preprocessor = preprocessor;
            this.Facets = facets ?? throw new global::System.ArgumentNullException(nameof(facets));
            this.TopicMaps = topicMaps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchedFacetData" /> class.
        /// </summary>
        public BatchedFacetData()
        {
        }

    }
}