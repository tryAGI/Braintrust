
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Who speaks first in the conversation<br/>
    /// Default Value: agent
    /// </summary>
    public enum FunctionDataConversationConfigVariant1Initiator
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
    public static class FunctionDataConversationConfigVariant1InitiatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataConversationConfigVariant1Initiator value)
        {
            return value switch
            {
                FunctionDataConversationConfigVariant1Initiator.Agent => "agent",
                FunctionDataConversationConfigVariant1Initiator.SimulatedUser => "simulated_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataConversationConfigVariant1Initiator? ToEnum(string value)
        {
            return value switch
            {
                "agent" => FunctionDataConversationConfigVariant1Initiator.Agent,
                "simulated_user" => FunctionDataConversationConfigVariant1Initiator.SimulatedUser,
                _ => null,
            };
        }
    }
}