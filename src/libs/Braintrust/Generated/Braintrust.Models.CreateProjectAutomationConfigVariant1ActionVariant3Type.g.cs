
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    public enum CreateProjectAutomationConfigVariant1ActionVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Pagerduty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectAutomationConfigVariant1ActionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant1ActionVariant3Type value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant1ActionVariant3Type.Pagerduty => "pagerduty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant1ActionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "pagerduty" => CreateProjectAutomationConfigVariant1ActionVariant3Type.Pagerduty,
                _ => null,
            };
        }
    }
}