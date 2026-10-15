
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Default Value: voice
    /// </summary>
    public enum FunctionDataSimulationConfigVariant1Modality
    {
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataSimulationConfigVariant1ModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataSimulationConfigVariant1Modality value)
        {
            return value switch
            {
                FunctionDataSimulationConfigVariant1Modality.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataSimulationConfigVariant1Modality? ToEnum(string value)
        {
            return value switch
            {
                "voice" => FunctionDataSimulationConfigVariant1Modality.Voice,
                _ => null,
            };
        }
    }
}