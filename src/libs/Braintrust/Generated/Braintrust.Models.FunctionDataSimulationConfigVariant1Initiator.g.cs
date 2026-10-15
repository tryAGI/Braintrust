
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Who speaks first in the conversation<br/>
    /// Default Value: agent
    /// </summary>
    public enum FunctionDataSimulationConfigVariant1Initiator
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        SimulatedUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataSimulationConfigVariant1InitiatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataSimulationConfigVariant1Initiator value)
        {
            return value switch
            {
                FunctionDataSimulationConfigVariant1Initiator.Agent => "agent",
                FunctionDataSimulationConfigVariant1Initiator.SimulatedUser => "simulated_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataSimulationConfigVariant1Initiator? ToEnum(string value)
        {
            return value switch
            {
                "agent" => FunctionDataSimulationConfigVariant1Initiator.Agent,
                "simulated_user" => FunctionDataSimulationConfigVariant1Initiator.SimulatedUser,
                _ => null,
            };
        }
    }
}