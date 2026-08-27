
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The materialized result format
    /// </summary>
    public enum ProjectAutomationConfigVariant3Format
    {
        /// <summary>
        ///
        /// </summary>
        Jsonl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant3FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant3Format value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant3Format.Jsonl => "jsonl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant3Format? ToEnum(string value)
        {
            return value switch
            {
                "jsonl" => ProjectAutomationConfigVariant3Format.Jsonl,
                _ => null,
            };
        }
    }
}