
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectAutomationConfigVariant1ActionVariant3Severity
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
    public static class CreateProjectAutomationConfigVariant1ActionVariant3SeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant1ActionVariant3Severity value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant1ActionVariant3Severity.Critical => "critical",
                CreateProjectAutomationConfigVariant1ActionVariant3Severity.Error => "error",
                CreateProjectAutomationConfigVariant1ActionVariant3Severity.Info => "info",
                CreateProjectAutomationConfigVariant1ActionVariant3Severity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant1ActionVariant3Severity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => CreateProjectAutomationConfigVariant1ActionVariant3Severity.Critical,
                "error" => CreateProjectAutomationConfigVariant1ActionVariant3Severity.Error,
                "info" => CreateProjectAutomationConfigVariant1ActionVariant3Severity.Info,
                "warning" => CreateProjectAutomationConfigVariant1ActionVariant3Severity.Warning,
                _ => null,
            };
        }
    }
}