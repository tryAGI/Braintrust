
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Who speaks first in the conversation<br/>
    /// Default Value: agent
    /// </summary>
    public enum FunctionDataNullishConversationConfigVariant1Initiator
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
    public static class FunctionDataNullishConversationConfigVariant1InitiatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishConversationConfigVariant1Initiator value)
        {
            return value switch
            {
                FunctionDataNullishConversationConfigVariant1Initiator.Agent => "agent",
                FunctionDataNullishConversationConfigVariant1Initiator.SimulatedUser => "simulated_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishConversationConfigVariant1Initiator? ToEnum(string value)
        {
            return value switch
            {
                "agent" => FunctionDataNullishConversationConfigVariant1Initiator.Agent,
                "simulated_user" => FunctionDataNullishConversationConfigVariant1Initiator.SimulatedUser,
                _ => null,
            };
        }
    }
}