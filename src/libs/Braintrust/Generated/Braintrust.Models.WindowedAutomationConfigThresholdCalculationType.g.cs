
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum WindowedAutomationConfigThresholdCalculationType
    {
        /// <summary>
        ///
        /// </summary>
        Btql,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigThresholdCalculationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigThresholdCalculationType value)
        {
            return value switch
            {
                WindowedAutomationConfigThresholdCalculationType.Btql => "btql",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigThresholdCalculationType? ToEnum(string value)
        {
            return value switch
            {
                "btql" => WindowedAutomationConfigThresholdCalculationType.Btql,
                _ => null,
            };
        }
    }
}