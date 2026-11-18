
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataConversationConfigVariant2Modality
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataConversationConfigVariant2ModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataConversationConfigVariant2Modality value)
        {
            return value switch
            {
                FunctionDataConversationConfigVariant2Modality.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataConversationConfigVariant2Modality? ToEnum(string value)
        {
            return value switch
            {
                "text" => FunctionDataConversationConfigVariant2Modality.Text,
                _ => null,
            };
        }
    }
}