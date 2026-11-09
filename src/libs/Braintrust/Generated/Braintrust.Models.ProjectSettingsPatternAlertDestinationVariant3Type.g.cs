
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    public enum ProjectSettingsPatternAlertDestinationVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Pagerduty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSettingsPatternAlertDestinationVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSettingsPatternAlertDestinationVariant3Type value)
        {
            return value switch
            {
                ProjectSettingsPatternAlertDestinationVariant3Type.Pagerduty => "pagerduty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSettingsPatternAlertDestinationVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "pagerduty" => ProjectSettingsPatternAlertDestinationVariant3Type.Pagerduty,
                _ => null,
            };
        }
    }
}