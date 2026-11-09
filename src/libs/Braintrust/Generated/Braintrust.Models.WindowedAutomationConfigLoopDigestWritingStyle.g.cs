
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public enum WindowedAutomationConfigLoopDigestWritingStyle
    {
        /// <summary>
        ///
        /// </summary>
        Compact,
        /// <summary>
        ///
        /// </summary>
        Detailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigLoopDigestWritingStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigLoopDigestWritingStyle value)
        {
            return value switch
            {
                WindowedAutomationConfigLoopDigestWritingStyle.Compact => "compact",
                WindowedAutomationConfigLoopDigestWritingStyle.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigLoopDigestWritingStyle? ToEnum(string value)
        {
            return value switch
            {
                "compact" => WindowedAutomationConfigLoopDigestWritingStyle.Compact,
                "detailed" => WindowedAutomationConfigLoopDigestWritingStyle.Detailed,
                _ => null,
            };
        }
    }
}