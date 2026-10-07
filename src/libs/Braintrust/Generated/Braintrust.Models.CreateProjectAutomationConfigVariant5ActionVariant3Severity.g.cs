
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectAutomationConfigVariant5ActionVariant3Severity
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
    public static class CreateProjectAutomationConfigVariant5ActionVariant3SeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant5ActionVariant3Severity value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant5ActionVariant3Severity.Critical => "critical",
                CreateProjectAutomationConfigVariant5ActionVariant3Severity.Error => "error",
                CreateProjectAutomationConfigVariant5ActionVariant3Severity.Info => "info",
                CreateProjectAutomationConfigVariant5ActionVariant3Severity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant5ActionVariant3Severity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => CreateProjectAutomationConfigVariant5ActionVariant3Severity.Critical,
                "error" => CreateProjectAutomationConfigVariant5ActionVariant3Severity.Error,
                "info" => CreateProjectAutomationConfigVariant5ActionVariant3Severity.Info,
                "warning" => CreateProjectAutomationConfigVariant5ActionVariant3Severity.Warning,
                _ => null,
            };
        }
    }
}