
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FunctionDataSimulationConfigVariant1AgentVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionDataSimulationConfigVariant1AgentVariant1TypeJsonConverter))]
        public global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant1Type Type { get; set; }

        /// <summary>
        /// The WebSocket URL of the LiveKit project hosting the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// The name of the LiveKit agent to dispatch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataSimulationConfigVariant1AgentVariant1" /> class.
        /// </summary>
        /// <param name="serverUrl">
        /// The WebSocket URL of the LiveKit project hosting the agent
        /// </param>
        /// <param name="agentName">
        /// The name of the LiveKit agent to dispatch
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataSimulationConfigVariant1AgentVariant1(
            string serverUrl,
            string agentName,
            global::Braintrust.FunctionDataSimulationConfigVariant1AgentVariant1Type type)
        {
            this.Type = type;
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataSimulationConfigVariant1AgentVariant1" /> class.
        /// </summary>
        public FunctionDataSimulationConfigVariant1AgentVariant1()
        {
        }

    }
}