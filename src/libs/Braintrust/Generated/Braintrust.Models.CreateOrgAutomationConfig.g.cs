
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The configuration for the org automation rule
    /// </summary>
    public sealed partial class CreateOrgAutomationConfig
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.CreateOrgAutomationConfigEventTypeJsonConverter))]
        public global::Braintrust.CreateOrgAutomationConfigEventType EventType { get; set; }

        /// <summary>
        /// The object type that the retention policy applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.RetentionObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.RetentionObjectType ObjectType { get; set; }

        /// <summary>
        /// The number of days to retain the object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgAutomationConfig" /> class.
        /// </summary>
        /// <param name="objectType">
        /// The object type that the retention policy applies to
        /// </param>
        /// <param name="retentionDays">
        /// The number of days to retain the object
        /// </param>
        /// <param name="eventType">
        /// The type of automation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrgAutomationConfig(
            global::Braintrust.RetentionObjectType objectType,
            int retentionDays,
            global::Braintrust.CreateOrgAutomationConfigEventType eventType)
        {
            this.EventType = eventType;
            this.ObjectType = objectType;
            this.RetentionDays = retentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgAutomationConfig" /> class.
        /// </summary>
        public CreateOrgAutomationConfig()
        {
        }

    }
}