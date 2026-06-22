
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum PatchProjectAutomationConfigVariant5EventType
    {
        /// <summary>
        /// 
        /// </summary>
        EnvironmentUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant5EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant5EventType value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant5EventType.EnvironmentUpdate => "environment_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant5EventType? ToEnum(string value)
        {
            return value switch
            {
                "environment_update" => PatchProjectAutomationConfigVariant5EventType.EnvironmentUpdate,
                _ => null,
            };
        }
    }
}