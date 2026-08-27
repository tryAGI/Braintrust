
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// How the lifecycle changes when the calculation returns no data
    /// </summary>
    public enum WindowedAutomationConfigThresholdPolicyNoDataBehavior
    {
        /// <summary>
        ///
        /// </summary>
        Alert,
        /// <summary>
        ///
        /// </summary>
        KeepLast,
        /// <summary>
        ///
        /// </summary>
        Resolve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigThresholdPolicyNoDataBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigThresholdPolicyNoDataBehavior value)
        {
            return value switch
            {
                WindowedAutomationConfigThresholdPolicyNoDataBehavior.Alert => "alert",
                WindowedAutomationConfigThresholdPolicyNoDataBehavior.KeepLast => "keep_last",
                WindowedAutomationConfigThresholdPolicyNoDataBehavior.Resolve => "resolve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigThresholdPolicyNoDataBehavior? ToEnum(string value)
        {
            return value switch
            {
                "alert" => WindowedAutomationConfigThresholdPolicyNoDataBehavior.Alert,
                "keep_last" => WindowedAutomationConfigThresholdPolicyNoDataBehavior.KeepLast,
                "resolve" => WindowedAutomationConfigThresholdPolicyNoDataBehavior.Resolve,
                _ => null,
            };
        }
    }
}