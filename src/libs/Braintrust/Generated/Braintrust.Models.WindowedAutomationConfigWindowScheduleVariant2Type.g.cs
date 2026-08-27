
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum WindowedAutomationConfigWindowScheduleVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Cron,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigWindowScheduleVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigWindowScheduleVariant2Type value)
        {
            return value switch
            {
                WindowedAutomationConfigWindowScheduleVariant2Type.Cron => "cron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigWindowScheduleVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => WindowedAutomationConfigWindowScheduleVariant2Type.Cron,
                _ => null,
            };
        }
    }
}