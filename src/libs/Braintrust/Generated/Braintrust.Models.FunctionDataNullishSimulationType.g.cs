
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataNullishSimulationType
    {
        /// <summary>
        ///
        /// </summary>
        Simulation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishSimulationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishSimulationType value)
        {
            return value switch
            {
                FunctionDataNullishSimulationType.Simulation => "simulation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishSimulationType? ToEnum(string value)
        {
            return value switch
            {
                "simulation" => FunctionDataNullishSimulationType.Simulation,
                _ => null,
            };
        }
    }
}