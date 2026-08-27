
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum PatchOrgAutomationConfigEventType
    {
        /// <summary>
        ///
        /// </summary>
        Retention,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchOrgAutomationConfigEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrgAutomationConfigEventType value)
        {
            return value switch
            {
                PatchOrgAutomationConfigEventType.Retention => "retention",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrgAutomationConfigEventType? ToEnum(string value)
        {
            return value switch
            {
                "retention" => PatchOrgAutomationConfigEventType.Retention,
                _ => null,
            };
        }
    }
}