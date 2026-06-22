
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum ProjectAutomationConfigVariant5EventType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant5EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant5EventType value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant5EventType.EnvironmentUpdate => "environment_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant5EventType? ToEnum(string value)
        {
            return value switch
            {
                "environment_update" => ProjectAutomationConfigVariant5EventType.EnvironmentUpdate,
                _ => null,
            };
        }
    }
}