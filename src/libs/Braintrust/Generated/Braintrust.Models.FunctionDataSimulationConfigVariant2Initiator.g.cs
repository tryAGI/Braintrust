
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Who speaks first in the conversation<br/>
    /// Default Value: agent
    /// </summary>
    public enum FunctionDataSimulationConfigVariant2Initiator
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
    public static class FunctionDataSimulationConfigVariant2InitiatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataSimulationConfigVariant2Initiator value)
        {
            return value switch
            {
                FunctionDataSimulationConfigVariant2Initiator.Agent => "agent",
                FunctionDataSimulationConfigVariant2Initiator.SimulatedUser => "simulated_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataSimulationConfigVariant2Initiator? ToEnum(string value)
        {
            return value switch
            {
                "agent" => FunctionDataSimulationConfigVariant2Initiator.Agent,
                "simulated_user" => FunctionDataSimulationConfigVariant2Initiator.SimulatedUser,
                _ => null,
            };
        }
    }
}