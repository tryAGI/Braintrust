
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// A task function that runs a conversation between an agent and a simulated user.
    /// </summary>
    public sealed partial class FunctionDataSimulation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionDataSimulationTypeJsonConverter))]
        public global::Braintrust.FunctionDataSimulationType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.FunctionDataSimulationConfigVariant1, global::Braintrust.FunctionDataSimulationConfigVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.AnyOf<global::Braintrust.FunctionDataSimulationConfigVariant1, global::Braintrust.FunctionDataSimulationConfigVariant2> Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataSimulation" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataSimulation(
            global::Braintrust.AnyOf<global::Braintrust.FunctionDataSimulationConfigVariant1, global::Braintrust.FunctionDataSimulationConfigVariant2> config,
            global::Braintrust.FunctionDataSimulationType type)
        {
            this.Type = type;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataSimulation" /> class.
        /// </summary>
        public FunctionDataSimulation()
        {
        }

    }
}