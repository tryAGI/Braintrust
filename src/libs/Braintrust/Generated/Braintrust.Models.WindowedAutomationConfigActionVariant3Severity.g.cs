
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum WindowedAutomationConfigActionVariant3Severity
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
    public static class WindowedAutomationConfigActionVariant3SeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigActionVariant3Severity value)
        {
            return value switch
            {
                WindowedAutomationConfigActionVariant3Severity.Critical => "critical",
                WindowedAutomationConfigActionVariant3Severity.Error => "error",
                WindowedAutomationConfigActionVariant3Severity.Info => "info",
                WindowedAutomationConfigActionVariant3Severity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigActionVariant3Severity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => WindowedAutomationConfigActionVariant3Severity.Critical,
                "error" => WindowedAutomationConfigActionVariant3Severity.Error,
                "info" => WindowedAutomationConfigActionVariant3Severity.Info,
                "warning" => WindowedAutomationConfigActionVariant3Severity.Warning,
                _ => null,
            };
        }
    }
}