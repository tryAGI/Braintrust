
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataConversationConfigVariant2AgentVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Acp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataConversationConfigVariant2AgentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataConversationConfigVariant2AgentVariant2Type value)
        {
            return value switch
            {
                FunctionDataConversationConfigVariant2AgentVariant2Type.Acp => "acp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataConversationConfigVariant2AgentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "acp" => FunctionDataConversationConfigVariant2AgentVariant2Type.Acp,
                _ => null,
            };
        }
    }
}