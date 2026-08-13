
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    public enum OrgAutomationConfigEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Retention,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgAutomationConfigEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgAutomationConfigEventType value)
        {
            return value switch
            {
                OrgAutomationConfigEventType.Retention => "retention",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgAutomationConfigEventType? ToEnum(string value)
        {
            return value switch
            {
                "retention" => OrgAutomationConfigEventType.Retention,
                _ => null,
            };
        }
    }
}