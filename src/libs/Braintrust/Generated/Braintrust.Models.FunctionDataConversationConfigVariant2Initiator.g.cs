
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Who speaks first in the conversation<br/>
    /// Default Value: agent
    /// </summary>
    public enum FunctionDataConversationConfigVariant2Initiator
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
    public static class FunctionDataConversationConfigVariant2InitiatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataConversationConfigVariant2Initiator value)
        {
            return value switch
            {
                FunctionDataConversationConfigVariant2Initiator.Agent => "agent",
                FunctionDataConversationConfigVariant2Initiator.SimulatedUser => "simulated_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataConversationConfigVariant2Initiator? ToEnum(string value)
        {
            return value switch
            {
                "agent" => FunctionDataConversationConfigVariant2Initiator.Agent,
                "simulated_user" => FunctionDataConversationConfigVariant2Initiator.SimulatedUser,
                _ => null,
            };
        }
    }
}