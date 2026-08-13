
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum WindowedAutomationConfigLoopReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigLoopReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigLoopReasoningEffort value)
        {
            return value switch
            {
                WindowedAutomationConfigLoopReasoningEffort.High => "high",
                WindowedAutomationConfigLoopReasoningEffort.Low => "low",
                WindowedAutomationConfigLoopReasoningEffort.Max => "max",
                WindowedAutomationConfigLoopReasoningEffort.Medium => "medium",
                WindowedAutomationConfigLoopReasoningEffort.Minimal => "minimal",
                WindowedAutomationConfigLoopReasoningEffort.None => "none",
                WindowedAutomationConfigLoopReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigLoopReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => WindowedAutomationConfigLoopReasoningEffort.High,
                "low" => WindowedAutomationConfigLoopReasoningEffort.Low,
                "max" => WindowedAutomationConfigLoopReasoningEffort.Max,
                "medium" => WindowedAutomationConfigLoopReasoningEffort.Medium,
                "minimal" => WindowedAutomationConfigLoopReasoningEffort.Minimal,
                "none" => WindowedAutomationConfigLoopReasoningEffort.None,
                "xhigh" => WindowedAutomationConfigLoopReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}