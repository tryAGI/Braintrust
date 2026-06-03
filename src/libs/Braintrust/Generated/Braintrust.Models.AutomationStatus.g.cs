
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Whether the automation is active or paused.
    /// </summary>
    public enum AutomationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationStatus value)
        {
            return value switch
            {
                AutomationStatus.Active => "active",
                AutomationStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => AutomationStatus.Active,
                "paused" => AutomationStatus.Paused,
                _ => null,
            };
        }
    }
}