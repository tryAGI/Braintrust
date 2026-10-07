
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectAutomationConfigVariant5ActionVariant3Severity
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
    public static class ProjectAutomationConfigVariant5ActionVariant3SeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant5ActionVariant3Severity value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant5ActionVariant3Severity.Critical => "critical",
                ProjectAutomationConfigVariant5ActionVariant3Severity.Error => "error",
                ProjectAutomationConfigVariant5ActionVariant3Severity.Info => "info",
                ProjectAutomationConfigVariant5ActionVariant3Severity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant5ActionVariant3Severity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => ProjectAutomationConfigVariant5ActionVariant3Severity.Critical,
                "error" => ProjectAutomationConfigVariant5ActionVariant3Severity.Error,
                "info" => ProjectAutomationConfigVariant5ActionVariant3Severity.Info,
                "warning" => ProjectAutomationConfigVariant5ActionVariant3Severity.Warning,
                _ => null,
            };
        }
    }
}