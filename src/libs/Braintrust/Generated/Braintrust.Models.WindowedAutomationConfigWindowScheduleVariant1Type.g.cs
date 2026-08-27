
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum WindowedAutomationConfigWindowScheduleVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Interval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigWindowScheduleVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigWindowScheduleVariant1Type value)
        {
            return value switch
            {
                WindowedAutomationConfigWindowScheduleVariant1Type.Interval => "interval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigWindowScheduleVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "interval" => WindowedAutomationConfigWindowScheduleVariant1Type.Interval,
                _ => null,
            };
        }
    }
}