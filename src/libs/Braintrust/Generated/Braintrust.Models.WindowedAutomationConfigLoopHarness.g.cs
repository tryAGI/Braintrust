
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public enum WindowedAutomationConfigLoopHarness
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeCode,
        /// <summary>
        /// 
        /// </summary>
        Codex,
        /// <summary>
        /// 
        /// </summary>
        Native,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WindowedAutomationConfigLoopHarnessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WindowedAutomationConfigLoopHarness value)
        {
            return value switch
            {
                WindowedAutomationConfigLoopHarness.ClaudeCode => "claude-code",
                WindowedAutomationConfigLoopHarness.Codex => "codex",
                WindowedAutomationConfigLoopHarness.Native => "native",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WindowedAutomationConfigLoopHarness? ToEnum(string value)
        {
            return value switch
            {
                "claude-code" => WindowedAutomationConfigLoopHarness.ClaudeCode,
                "codex" => WindowedAutomationConfigLoopHarness.Codex,
                "native" => WindowedAutomationConfigLoopHarness.Native,
                _ => null,
            };
        }
    }
}