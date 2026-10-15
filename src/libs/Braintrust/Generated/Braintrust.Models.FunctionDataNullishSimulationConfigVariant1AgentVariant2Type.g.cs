
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataNullishSimulationConfigVariant1AgentVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Phone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishSimulationConfigVariant1AgentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishSimulationConfigVariant1AgentVariant2Type value)
        {
            return value switch
            {
                FunctionDataNullishSimulationConfigVariant1AgentVariant2Type.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishSimulationConfigVariant1AgentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "phone" => FunctionDataNullishSimulationConfigVariant1AgentVariant2Type.Phone,
                _ => null,
            };
        }
    }
}