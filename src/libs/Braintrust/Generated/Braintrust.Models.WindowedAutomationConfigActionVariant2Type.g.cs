
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    public enum WindowedAutomationConfigActionVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigActionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigActionVariant2Type value)
        {
            return value switch
            {
                WindowedAutomationConfigActionVariant2Type.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigActionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "slack" => WindowedAutomationConfigActionVariant2Type.Slack,
                _ => null,
            };
        }
    }
}