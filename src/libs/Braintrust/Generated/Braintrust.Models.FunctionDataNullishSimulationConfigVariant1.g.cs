
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FunctionDataNullishSimulationConfigVariant1
    {
        /// <summary>
        /// Who speaks first in the conversation<br/>
        /// Default Value: agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initiator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionDataNullishSimulationConfigVariant1InitiatorJsonConverter))]
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1Initiator? Initiator { get; set; }

        /// <summary>
        /// Maximum conversation duration in seconds<br/>
        /// Default Value: 600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Default Value: voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionDataNullishSimulationConfigVariant1ModalityJsonConverter))]
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1Modality? Modality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.OneOfJsonConverter<global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant1, global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant2, global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.OneOf<global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant1, global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant2, global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant3> Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishSimulationConfigVariant1" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="initiator">
        /// Who speaks first in the conversation<br/>
        /// Default Value: agent
        /// </param>
        /// <param name="timeoutSeconds">
        /// Maximum conversation duration in seconds<br/>
        /// Default Value: 600
        /// </param>
        /// <param name="modality">
        /// Default Value: voice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataNullishSimulationConfigVariant1(
            global::Braintrust.OneOf<global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant1, global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant2, global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant3> agent,
            global::Braintrust.FunctionDataNullishSimulationConfigVariant1Initiator? initiator,
            int? timeoutSeconds,
            global::Braintrust.FunctionDataNullishSimulationConfigVariant1Modality? modality)
        {
            this.Initiator = initiator;
            this.TimeoutSeconds = timeoutSeconds;
            this.Modality = modality;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishSimulationConfigVariant1" /> class.
        /// </summary>
        public FunctionDataNullishSimulationConfigVariant1()
        {
        }

    }
}