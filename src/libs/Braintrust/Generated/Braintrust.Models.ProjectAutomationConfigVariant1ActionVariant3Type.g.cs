
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    public enum ProjectAutomationConfigVariant1ActionVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Pagerduty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant1ActionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant1ActionVariant3Type value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant1ActionVariant3Type.Pagerduty => "pagerduty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant1ActionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "pagerduty" => ProjectAutomationConfigVariant1ActionVariant3Type.Pagerduty,
                _ => null,
            };
        }
    }
}