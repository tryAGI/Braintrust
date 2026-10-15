
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// A task function that runs a conversation between an agent and a simulated user.
    /// </summary>
    public sealed partial class FunctionDataNullishSimulation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionDataNullishSimulationTypeJsonConverter))]
        public global::Braintrust.FunctionDataNullishSimulationType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AnyOfJsonConverter<global::Braintrust.FunctionDataNullishSimulationConfigVariant1, global::Braintrust.FunctionDataNullishSimulationConfigVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.AnyOf<global::Braintrust.FunctionDataNullishSimulationConfigVariant1, global::Braintrust.FunctionDataNullishSimulationConfigVariant2> Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishSimulation" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataNullishSimulation(
            global::Braintrust.AnyOf<global::Braintrust.FunctionDataNullishSimulationConfigVariant1, global::Braintrust.FunctionDataNullishSimulationConfigVariant2> config,
            global::Braintrust.FunctionDataNullishSimulationType type)
        {
            this.Type = type;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishSimulation" /> class.
        /// </summary>
        public FunctionDataNullishSimulation()
        {
        }

    }
}