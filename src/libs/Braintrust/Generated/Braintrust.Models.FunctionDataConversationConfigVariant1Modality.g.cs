
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Default Value: voice
    /// </summary>
    public enum FunctionDataConversationConfigVariant1Modality
    {
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataConversationConfigVariant1ModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataConversationConfigVariant1Modality value)
        {
            return value switch
            {
                FunctionDataConversationConfigVariant1Modality.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataConversationConfigVariant1Modality? ToEnum(string value)
        {
            return value switch
            {
                "voice" => FunctionDataConversationConfigVariant1Modality.Voice,
                _ => null,
            };
        }
    }
}