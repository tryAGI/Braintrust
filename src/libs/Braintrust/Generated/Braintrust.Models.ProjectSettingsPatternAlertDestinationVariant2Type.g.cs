
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    public enum ProjectSettingsPatternAlertDestinationVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSettingsPatternAlertDestinationVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSettingsPatternAlertDestinationVariant2Type value)
        {
            return value switch
            {
                ProjectSettingsPatternAlertDestinationVariant2Type.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSettingsPatternAlertDestinationVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "slack" => ProjectSettingsPatternAlertDestinationVariant2Type.Slack,
                _ => null,
            };
        }
    }
}