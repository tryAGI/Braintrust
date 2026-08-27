
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum CreateOrgAutomationConfigEventType
    {
        /// <summary>
        ///
        /// </summary>
        Retention,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOrgAutomationConfigEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrgAutomationConfigEventType value)
        {
            return value switch
            {
                CreateOrgAutomationConfigEventType.Retention => "retention",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrgAutomationConfigEventType? ToEnum(string value)
        {
            return value switch
            {
                "retention" => CreateOrgAutomationConfigEventType.Retention,
                _ => null,
            };
        }
    }
}