
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Who speaks first in the conversation<br/>
    /// Default Value: agent
    /// </summary>
    public enum FunctionDataNullishConversationConfigVariant2Initiator
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
    public static class FunctionDataNullishConversationConfigVariant2InitiatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishConversationConfigVariant2Initiator value)
        {
            return value switch
            {
                FunctionDataNullishConversationConfigVariant2Initiator.Agent => "agent",
                FunctionDataNullishConversationConfigVariant2Initiator.SimulatedUser => "simulated_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishConversationConfigVariant2Initiator? ToEnum(string value)
        {
            return value switch
            {
                "agent" => FunctionDataNullishConversationConfigVariant2Initiator.Agent,
                "simulated_user" => FunctionDataNullishConversationConfigVariant2Initiator.SimulatedUser,
                _ => null,
            };
        }
    }
}