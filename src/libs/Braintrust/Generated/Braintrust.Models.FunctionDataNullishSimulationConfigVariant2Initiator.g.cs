
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Who speaks first in the conversation<br/>
    /// Default Value: agent
    /// </summary>
    public enum FunctionDataNullishSimulationConfigVariant2Initiator
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
    public static class FunctionDataNullishSimulationConfigVariant2InitiatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishSimulationConfigVariant2Initiator value)
        {
            return value switch
            {
                FunctionDataNullishSimulationConfigVariant2Initiator.Agent => "agent",
                FunctionDataNullishSimulationConfigVariant2Initiator.SimulatedUser => "simulated_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishSimulationConfigVariant2Initiator? ToEnum(string value)
        {
            return value switch
            {
                "agent" => FunctionDataNullishSimulationConfigVariant2Initiator.Agent,
                "simulated_user" => FunctionDataNullishSimulationConfigVariant2Initiator.SimulatedUser,
                _ => null,
            };
        }
    }
}