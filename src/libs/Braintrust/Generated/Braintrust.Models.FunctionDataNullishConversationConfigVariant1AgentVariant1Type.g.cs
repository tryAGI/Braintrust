
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataNullishConversationConfigVariant1AgentVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Livekit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishConversationConfigVariant1AgentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishConversationConfigVariant1AgentVariant1Type value)
        {
            return value switch
            {
                FunctionDataNullishConversationConfigVariant1AgentVariant1Type.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishConversationConfigVariant1AgentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => FunctionDataNullishConversationConfigVariant1AgentVariant1Type.Livekit,
                _ => null,
            };
        }
    }
}