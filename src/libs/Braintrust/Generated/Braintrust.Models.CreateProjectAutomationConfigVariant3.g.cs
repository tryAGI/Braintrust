
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectAutomationConfigVariant3
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3EventTypeJsonConverter))]
        public global::Braintrust.CreateProjectAutomationConfigVariant3EventType EventType { get; set; }

        /// <summary>
        /// Whether the automation is active or paused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AutomationStatusJsonConverter))]
        public global::Braintrust.AutomationStatus? Status { get; set; }

        /// <summary>
        /// The user who submitted the async query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CreatedByUserId { get; set; }

        /// <summary>
        /// The source object type for the async query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3ObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType ObjectType { get; set; }

        /// <summary>
        /// The source object ID for the async query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// The SQL query to execute asynchronously
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The materialized result format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant3FormatJsonConverter))]
        public global::Braintrust.CreateProjectAutomationConfigVariant3Format Format { get; set; }

        /// <summary>
        /// The maximum number of result rows to write per async query batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant3" /> class.
        /// </summary>
        /// <param name="createdByUserId">
        /// The user who submitted the async query
        /// </param>
        /// <param name="objectType">
        /// The source object type for the async query
        /// </param>
        /// <param name="objectId">
        /// The source object ID for the async query
        /// </param>
        /// <param name="query">
        /// The SQL query to execute asynchronously
        /// </param>
        /// <param name="eventType">
        /// The type of automation.
        /// </param>
        /// <param name="status">
        /// Whether the automation is active or paused.
        /// </param>
        /// <param name="format">
        /// The materialized result format
        /// </param>
        /// <param name="batchSize">
        /// The maximum number of result rows to write per async query batch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectAutomationConfigVariant3(
            global::System.Guid createdByUserId,
            global::Braintrust.CreateProjectAutomationConfigVariant3ObjectType objectType,
            string objectId,
            string query,
            global::Braintrust.CreateProjectAutomationConfigVariant3EventType eventType,
            global::Braintrust.AutomationStatus? status,
            global::Braintrust.CreateProjectAutomationConfigVariant3Format format,
            int? batchSize)
        {
            this.EventType = eventType;
            this.Status = status;
            this.CreatedByUserId = createdByUserId;
            this.ObjectType = objectType;
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Format = format;
            this.BatchSize = batchSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant3" /> class.
        /// </summary>
        public CreateProjectAutomationConfigVariant3()
        {
        }

    }
}