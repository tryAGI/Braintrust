
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectAutomationConfigVariant5ActionVariant3
    {
        /// <summary>
        /// The type of action to take
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant5ActionVariant3TypeJsonConverter))]
        public global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Type Type { get; set; }

        /// <summary>
        /// The data-plane secret containing the PagerDuty routing key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_key_secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RoutingKeySecretName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.ProjectAutomationConfigVariant5ActionVariant3SeverityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Severity Severity { get; set; }

        /// <summary>
        /// Instructions for Loop to format content sent to this destination
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatting_prompt")]
        public string? FormattingPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant5ActionVariant3" /> class.
        /// </summary>
        /// <param name="routingKeySecretName">
        /// The data-plane secret containing the PagerDuty routing key
        /// </param>
        /// <param name="severity"></param>
        /// <param name="type">
        /// The type of action to take
        /// </param>
        /// <param name="formattingPrompt">
        /// Instructions for Loop to format content sent to this destination
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectAutomationConfigVariant5ActionVariant3(
            global::System.Guid routingKeySecretName,
            global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Severity severity,
            global::Braintrust.ProjectAutomationConfigVariant5ActionVariant3Type type,
            string? formattingPrompt)
        {
            this.Type = type;
            this.RoutingKeySecretName = routingKeySecretName;
            this.Severity = severity;
            this.FormattingPrompt = formattingPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant5ActionVariant3" /> class.
        /// </summary>
        public ProjectAutomationConfigVariant5ActionVariant3()
        {
        }

    }
}