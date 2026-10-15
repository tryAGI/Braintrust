
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataSimulationConfigVariant1AgentVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Phone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataSimulationConfigVariant1AgentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataSimulationConfigVariant1AgentVariant2Type value)
        {
            return value switch
            {
                FunctionDataSimulationConfigVariant1AgentVariant2Type.Phone => "phone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataSimulationConfigVariant1AgentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "phone" => FunctionDataSimulationConfigVariant1AgentVariant2Type.Phone,
                _ => null,
            };
        }
    }
}