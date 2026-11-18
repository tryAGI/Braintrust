
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataConversationConfigVariant2AgentVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Livekit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataConversationConfigVariant2AgentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataConversationConfigVariant2AgentVariant1Type value)
        {
            return value switch
            {
                FunctionDataConversationConfigVariant2AgentVariant1Type.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataConversationConfigVariant2AgentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => FunctionDataConversationConfigVariant2AgentVariant1Type.Livekit,
                _ => null,
            };
        }
    }
}