
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchProjectAutomationConfigVariant1ActionVariant3Severity
    {
        /// <summary>
        ///
        /// </summary>
        Critical,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Info,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant1ActionVariant3SeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant1ActionVariant3Severity value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant1ActionVariant3Severity.Critical => "critical",
                PatchProjectAutomationConfigVariant1ActionVariant3Severity.Error => "error",
                PatchProjectAutomationConfigVariant1ActionVariant3Severity.Info => "info",
                PatchProjectAutomationConfigVariant1ActionVariant3Severity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant1ActionVariant3Severity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => PatchProjectAutomationConfigVariant1ActionVariant3Severity.Critical,
                "error" => PatchProjectAutomationConfigVariant1ActionVariant3Severity.Error,
                "info" => PatchProjectAutomationConfigVariant1ActionVariant3Severity.Info,
                "warning" => PatchProjectAutomationConfigVariant1ActionVariant3Severity.Warning,
                _ => null,
            };
        }
    }
}