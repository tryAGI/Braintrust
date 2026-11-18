
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionDataConversationType
    {
        /// <summary>
        ///
        /// </summary>
        Conversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataConversationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataConversationType value)
        {
            return value switch
            {
                FunctionDataConversationType.Conversation => "conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataConversationType? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => FunctionDataConversationType.Conversation,
                _ => null,
            };
        }
    }
}