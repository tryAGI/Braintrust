
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    public enum WindowedAutomationConfigActionVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigActionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigActionVariant1Type value)
        {
            return value switch
            {
                WindowedAutomationConfigActionVariant1Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigActionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => WindowedAutomationConfigActionVariant1Type.Webhook,
                _ => null,
            };
        }
    }
}