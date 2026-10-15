
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FunctionDataNullishSimulationConfigVariant1AgentVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.FunctionDataNullishSimulationConfigVariant1AgentVariant2TypeJsonConverter))]
        public global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishSimulationConfigVariant1AgentVariant2" /> class.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataNullishSimulationConfigVariant1AgentVariant2(
            string phoneNumber,
            global::Braintrust.FunctionDataNullishSimulationConfigVariant1AgentVariant2Type type)
        {
            this.Type = type;
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishSimulationConfigVariant1AgentVariant2" /> class.
        /// </summary>
        public FunctionDataNullishSimulationConfigVariant1AgentVariant2()
        {
        }

    }
}