
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum CreateProjectAutomationConfigVariant5EventType
    {
        /// <summary>
        ///
        /// </summary>
        EnvironmentUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectAutomationConfigVariant5EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant5EventType value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant5EventType.EnvironmentUpdate => "environment_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant5EventType? ToEnum(string value)
        {
            return value switch
            {
                "environment_update" => CreateProjectAutomationConfigVariant5EventType.EnvironmentUpdate,
                _ => null,
            };
        }
    }
}