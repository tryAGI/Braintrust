
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// A dictionary with additional data about the test example, model outputs, or just about anything else that's relevant, that you can use to help find and analyze examples later. For example, you could log the `prompt`, example's `id`, or anything else that would be useful to slice/dice later. The values in `metadata` can be any JSON-serializable type, but its keys must be strings
    /// </summary>
    public sealed partial class InsertDatasetEventMetadata
    {
        /// <summary>
        /// The model used for this example
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The service tier requested for this LLM call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_service_tier")]
        public string? RequestedServiceTier { get; set; }

        /// <summary>
        /// The service tier that served this LLM call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("served_service_tier")]
        public string? ServedServiceTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDatasetEventMetadata" /> class.
        /// </summary>
        /// <param name="model">
        /// The model used for this example
        /// </param>
        /// <param name="requestedServiceTier">
        /// The service tier requested for this LLM call
        /// </param>
        /// <param name="servedServiceTier">
        /// The service tier that served this LLM call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsertDatasetEventMetadata(
            string? model,
            string? requestedServiceTier,
            string? servedServiceTier)
        {
            this.Model = model;
            this.RequestedServiceTier = requestedServiceTier;
            this.ServedServiceTier = servedServiceTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDatasetEventMetadata" /> class.
        /// </summary>
        public InsertDatasetEventMetadata()
        {
        }

    }
}