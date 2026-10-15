
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataNullishSimulationConfigVariant2AgentVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Acp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishSimulationConfigVariant2AgentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishSimulationConfigVariant2AgentVariant2Type value)
        {
            return value switch
            {
                FunctionDataNullishSimulationConfigVariant2AgentVariant2Type.Acp => "acp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishSimulationConfigVariant2AgentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "acp" => FunctionDataNullishSimulationConfigVariant2AgentVariant2Type.Acp,
                _ => null,
            };
        }
    }
}