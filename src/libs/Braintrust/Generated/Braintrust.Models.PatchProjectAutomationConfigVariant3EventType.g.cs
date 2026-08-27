
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum PatchProjectAutomationConfigVariant3EventType
    {
        /// <summary>
        ///
        /// </summary>
        AsyncQuery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant3EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant3EventType value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant3EventType.AsyncQuery => "async_query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant3EventType? ToEnum(string value)
        {
            return value switch
            {
                "async_query" => PatchProjectAutomationConfigVariant3EventType.AsyncQuery,
                _ => null,
            };
        }
    }
}