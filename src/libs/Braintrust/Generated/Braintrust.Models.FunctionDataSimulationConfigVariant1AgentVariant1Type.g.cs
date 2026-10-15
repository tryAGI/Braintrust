
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataSimulationConfigVariant1AgentVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Livekit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataSimulationConfigVariant1AgentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataSimulationConfigVariant1AgentVariant1Type value)
        {
            return value switch
            {
                FunctionDataSimulationConfigVariant1AgentVariant1Type.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataSimulationConfigVariant1AgentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => FunctionDataSimulationConfigVariant1AgentVariant1Type.Livekit,
                _ => null,
            };
        }
    }
}