
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The materialized result format
    /// </summary>
    public enum PatchProjectAutomationConfigVariant3Format
    {
        /// <summary>
        ///
        /// </summary>
        Jsonl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant3FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant3Format value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant3Format.Jsonl => "jsonl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant3Format? ToEnum(string value)
        {
            return value switch
            {
                "jsonl" => PatchProjectAutomationConfigVariant3Format.Jsonl,
                _ => null,
            };
        }
    }
}