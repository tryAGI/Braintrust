
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Lowest severity that sends Pattern alerts: `low`, `medium`, or `high`. New and reactivated Patterns below it don't send alerts, and raising an active Pattern's severity to it or above sends one. Patterns without a severity count as low. Informational Patterns follow `pattern_alert_informational` instead. Unset or null uses medium.
    /// </summary>
    public enum ProjectSettingsPatternAlertMinSeverity
    {
        /// <summary>
        /// `low`, `medium`, or `high`. New and reactivated Patterns below it don't send alerts, and raising an active Pattern's severity to it or above sends one. Patterns without a severity count as low. Informational Patterns follow `pattern_alert_informational` instead. Unset or null uses medium.
        /// </summary>
        High,
        /// <summary>
        /// `low`, `medium`, or `high`. New and reactivated Patterns below it don't send alerts, and raising an active Pattern's severity to it or above sends one. Patterns without a severity count as low. Informational Patterns follow `pattern_alert_informational` instead. Unset or null uses medium.
        /// </summary>
        Low,
        /// <summary>
        /// `low`, `medium`, or `high`. New and reactivated Patterns below it don't send alerts, and raising an active Pattern's severity to it or above sends one. Patterns without a severity count as low. Informational Patterns follow `pattern_alert_informational` instead. Unset or null uses medium.
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSettingsPatternAlertMinSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSettingsPatternAlertMinSeverity value)
        {
            return value switch
            {
                ProjectSettingsPatternAlertMinSeverity.High => "high",
                ProjectSettingsPatternAlertMinSeverity.Low => "low",
                ProjectSettingsPatternAlertMinSeverity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSettingsPatternAlertMinSeverity? ToEnum(string value)
        {
            return value switch
            {
                "high" => ProjectSettingsPatternAlertMinSeverity.High,
                "low" => ProjectSettingsPatternAlertMinSeverity.Low,
                "medium" => ProjectSettingsPatternAlertMinSeverity.Medium,
                _ => null,
            };
        }
    }
}