
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Optional Loop agent to run for each triggered window
    /// </summary>
    public sealed partial class WindowedAutomationConfigLoop
    {
        /// <summary>
        /// Instructions for the Loop agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Whether to include the automation trigger payload as input<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_trigger_input")]
        public bool? IncludeTriggerInput { get; set; }

        /// <summary>
        /// The Loop agent to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentSlug { get; set; }

        /// <summary>
        /// Write tools that may run without interactive approval<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_approve_tools")]
        public global::System.Collections.Generic.IList<string>? AutoApproveTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harness")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigLoopHarnessJsonConverter))]
        public global::Braintrust.WindowedAutomationConfigLoopHarness? Harness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigLoopReasoningEffortJsonConverter))]
        public global::Braintrust.WindowedAutomationConfigLoopReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigLoop" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Instructions for the Loop agent
        /// </param>
        /// <param name="agentSlug">
        /// The Loop agent to run
        /// </param>
        /// <param name="includeTriggerInput">
        /// Whether to include the automation trigger payload as input<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoApproveTools">
        /// Write tools that may run without interactive approval<br/>
        /// Default Value: []
        /// </param>
        /// <param name="harness"></param>
        /// <param name="model"></param>
        /// <param name="reasoningEffort"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigLoop(
            string prompt,
            string agentSlug,
            bool? includeTriggerInput,
            global::System.Collections.Generic.IList<string>? autoApproveTools,
            global::Braintrust.WindowedAutomationConfigLoopHarness? harness,
            string? model,
            global::Braintrust.WindowedAutomationConfigLoopReasoningEffort? reasoningEffort)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.IncludeTriggerInput = includeTriggerInput;
            this.AgentSlug = agentSlug ?? throw new global::System.ArgumentNullException(nameof(agentSlug));
            this.AutoApproveTools = autoApproveTools;
            this.Harness = harness;
            this.Model = model;
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigLoop" /> class.
        /// </summary>
        public WindowedAutomationConfigLoop()
        {
        }

    }
}