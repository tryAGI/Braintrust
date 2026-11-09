
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectSettingsPatternAlertDestinationVariant3Severity
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
    public static class ProjectSettingsPatternAlertDestinationVariant3SeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSettingsPatternAlertDestinationVariant3Severity value)
        {
            return value switch
            {
                ProjectSettingsPatternAlertDestinationVariant3Severity.Critical => "critical",
                ProjectSettingsPatternAlertDestinationVariant3Severity.Error => "error",
                ProjectSettingsPatternAlertDestinationVariant3Severity.Info => "info",
                ProjectSettingsPatternAlertDestinationVariant3Severity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSettingsPatternAlertDestinationVariant3Severity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => ProjectSettingsPatternAlertDestinationVariant3Severity.Critical,
                "error" => ProjectSettingsPatternAlertDestinationVariant3Severity.Error,
                "info" => ProjectSettingsPatternAlertDestinationVariant3Severity.Info,
                "warning" => ProjectSettingsPatternAlertDestinationVariant3Severity.Warning,
                _ => null,
            };
        }
    }
}