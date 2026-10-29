
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Required for an explicit model selection. Currently only Codex is supported.
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
        /// <summary>
        ///
        /// </summary>
        Pi,
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
                WindowedAutomationConfigLoopHarness.Pi => "pi",
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
                "pi" => WindowedAutomationConfigLoopHarness.Pi,
                _ => null,
            };
        }
    }
}