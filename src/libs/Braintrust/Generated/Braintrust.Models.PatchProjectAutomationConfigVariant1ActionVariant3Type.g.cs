
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    public enum PatchProjectAutomationConfigVariant1ActionVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Pagerduty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant1ActionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant1ActionVariant3Type value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant1ActionVariant3Type.Pagerduty => "pagerduty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant1ActionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "pagerduty" => PatchProjectAutomationConfigVariant1ActionVariant3Type.Pagerduty,
                _ => null,
            };
        }
    }
}