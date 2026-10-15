
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Who speaks first in the conversation<br/>
    /// Default Value: agent
    /// </summary>
    public enum FunctionDataNullishSimulationConfigVariant1Initiator
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
    public static class FunctionDataNullishSimulationConfigVariant1InitiatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishSimulationConfigVariant1Initiator value)
        {
            return value switch
            {
                FunctionDataNullishSimulationConfigVariant1Initiator.Agent => "agent",
                FunctionDataNullishSimulationConfigVariant1Initiator.SimulatedUser => "simulated_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishSimulationConfigVariant1Initiator? ToEnum(string value)
        {
            return value switch
            {
                "agent" => FunctionDataNullishSimulationConfigVariant1Initiator.Agent,
                "simulated_user" => FunctionDataNullishSimulationConfigVariant1Initiator.SimulatedUser,
                _ => null,
            };
        }
    }
}