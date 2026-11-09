
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    public enum ProjectSettingsPatternAlertDestinationVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSettingsPatternAlertDestinationVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSettingsPatternAlertDestinationVariant1Type value)
        {
            return value switch
            {
                ProjectSettingsPatternAlertDestinationVariant1Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSettingsPatternAlertDestinationVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ProjectSettingsPatternAlertDestinationVariant1Type.Webhook,
                _ => null,
            };
        }
    }
}