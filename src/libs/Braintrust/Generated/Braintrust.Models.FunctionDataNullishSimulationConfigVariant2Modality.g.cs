
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataNullishSimulationConfigVariant2Modality
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishSimulationConfigVariant2ModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishSimulationConfigVariant2Modality value)
        {
            return value switch
            {
                FunctionDataNullishSimulationConfigVariant2Modality.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishSimulationConfigVariant2Modality? ToEnum(string value)
        {
            return value switch
            {
                "text" => FunctionDataNullishSimulationConfigVariant2Modality.Text,
                _ => null,
            };
        }
    }
}