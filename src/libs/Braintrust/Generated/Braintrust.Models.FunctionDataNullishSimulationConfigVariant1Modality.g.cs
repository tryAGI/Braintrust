
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Default Value: voice
    /// </summary>
    public enum FunctionDataNullishSimulationConfigVariant1Modality
    {
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishSimulationConfigVariant1ModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishSimulationConfigVariant1Modality value)
        {
            return value switch
            {
                FunctionDataNullishSimulationConfigVariant1Modality.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishSimulationConfigVariant1Modality? ToEnum(string value)
        {
            return value switch
            {
                "voice" => FunctionDataNullishSimulationConfigVariant1Modality.Voice,
                _ => null,
            };
        }
    }
}