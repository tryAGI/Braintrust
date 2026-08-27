
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The materialized result format
    /// </summary>
    public enum CreateProjectAutomationConfigVariant3Format
    {
        /// <summary>
        ///
        /// </summary>
        Jsonl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectAutomationConfigVariant3FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant3Format value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant3Format.Jsonl => "jsonl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant3Format? ToEnum(string value)
        {
            return value switch
            {
                "jsonl" => CreateProjectAutomationConfigVariant3Format.Jsonl,
                _ => null,
            };
        }
    }
}