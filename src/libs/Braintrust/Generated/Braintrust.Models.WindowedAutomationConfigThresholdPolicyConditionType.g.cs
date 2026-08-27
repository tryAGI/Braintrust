
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum WindowedAutomationConfigThresholdPolicyConditionType
    {
        /// <summary>
        ///
        /// </summary>
        Threshold,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigThresholdPolicyConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigThresholdPolicyConditionType value)
        {
            return value switch
            {
                WindowedAutomationConfigThresholdPolicyConditionType.Threshold => "threshold",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigThresholdPolicyConditionType? ToEnum(string value)
        {
            return value switch
            {
                "threshold" => WindowedAutomationConfigThresholdPolicyConditionType.Threshold,
                _ => null,
            };
        }
    }
}