
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchProjectAutomationConfigVariant5ActionVariant3Severity
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
    public static class PatchProjectAutomationConfigVariant5ActionVariant3SeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant5ActionVariant3Severity value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant5ActionVariant3Severity.Critical => "critical",
                PatchProjectAutomationConfigVariant5ActionVariant3Severity.Error => "error",
                PatchProjectAutomationConfigVariant5ActionVariant3Severity.Info => "info",
                PatchProjectAutomationConfigVariant5ActionVariant3Severity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant5ActionVariant3Severity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => PatchProjectAutomationConfigVariant5ActionVariant3Severity.Critical,
                "error" => PatchProjectAutomationConfigVariant5ActionVariant3Severity.Error,
                "info" => PatchProjectAutomationConfigVariant5ActionVariant3Severity.Info,
                "warning" => PatchProjectAutomationConfigVariant5ActionVariant3Severity.Warning,
                _ => null,
            };
        }
    }
}