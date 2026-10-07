
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectAutomationConfigVariant1ActionVariant3Severity
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
    public static class ProjectAutomationConfigVariant1ActionVariant3SeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant1ActionVariant3Severity value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant1ActionVariant3Severity.Critical => "critical",
                ProjectAutomationConfigVariant1ActionVariant3Severity.Error => "error",
                ProjectAutomationConfigVariant1ActionVariant3Severity.Info => "info",
                ProjectAutomationConfigVariant1ActionVariant3Severity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant1ActionVariant3Severity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => ProjectAutomationConfigVariant1ActionVariant3Severity.Critical,
                "error" => ProjectAutomationConfigVariant1ActionVariant3Severity.Error,
                "info" => ProjectAutomationConfigVariant1ActionVariant3Severity.Info,
                "warning" => ProjectAutomationConfigVariant1ActionVariant3Severity.Warning,
                _ => null,
            };
        }
    }
}