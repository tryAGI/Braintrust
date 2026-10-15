
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataNullishSimulationConfigVariant1AgentVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Sip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishSimulationConfigVariant1AgentVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishSimulationConfigVariant1AgentVariant3Type value)
        {
            return value switch
            {
                FunctionDataNullishSimulationConfigVariant1AgentVariant3Type.Sip => "sip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishSimulationConfigVariant1AgentVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "sip" => FunctionDataNullishSimulationConfigVariant1AgentVariant3Type.Sip,
                _ => null,
            };
        }
    }
}