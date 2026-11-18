
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataNullishConversationType
    {
        /// <summary>
        ///
        /// </summary>
        Conversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishConversationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishConversationType value)
        {
            return value switch
            {
                FunctionDataNullishConversationType.Conversation => "conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishConversationType? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => FunctionDataNullishConversationType.Conversation,
                _ => null,
            };
        }
    }
}