
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WindowedAutomationConfig
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigEventTypeJsonConverter))]
        public global::Braintrust.WindowedAutomationConfigEventType EventType { get; set; }

        /// <summary>
        /// The product surface that created and manages the automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.WindowedAutomationConfigProductOriginJsonConverter))]
        public global::Braintrust.WindowedAutomationConfigProductOrigin? ProductOrigin { get; set; }

        /// <summary>
        /// Whether the automation is active or paused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.AutomationStatusJsonConverter))]
        public global::Braintrust.AutomationStatus? Status { get; set; }

        /// <summary>
        /// Optional calculation and lifecycle policy that gate scheduled delivery
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public global::Braintrust.WindowedAutomationConfigThreshold? Threshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.WindowedAutomationConfigWindow Window { get; set; }

        /// <summary>
        /// Optional Loop agent to run for each triggered window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loop")]
        public global::Braintrust.WindowedAutomationConfigLoop? Loop { get; set; }

        /// <summary>
        /// Delivery actions exposed to Loop as tools, or run directly when Loop is not configured<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigActionVariant1, global::Braintrust.WindowedAutomationConfigActionVariant2>>? Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfig" /> class.
        /// </summary>
        /// <param name="window"></param>
        /// <param name="eventType">
        /// The type of automation.
        /// </param>
        /// <param name="productOrigin">
        /// The product surface that created and manages the automation
        /// </param>
        /// <param name="status">
        /// Whether the automation is active or paused.
        /// </param>
        /// <param name="threshold">
        /// Optional calculation and lifecycle policy that gate scheduled delivery
        /// </param>
        /// <param name="loop">
        /// Optional Loop agent to run for each triggered window
        /// </param>
        /// <param name="actions">
        /// Delivery actions exposed to Loop as tools, or run directly when Loop is not configured<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfig(
            global::Braintrust.WindowedAutomationConfigWindow window,
            global::Braintrust.WindowedAutomationConfigEventType eventType,
            global::Braintrust.WindowedAutomationConfigProductOrigin? productOrigin,
            global::Braintrust.AutomationStatus? status,
            global::Braintrust.WindowedAutomationConfigThreshold? threshold,
            global::Braintrust.WindowedAutomationConfigLoop? loop,
            global::System.Collections.Generic.IList<global::Braintrust.OneOf<global::Braintrust.WindowedAutomationConfigActionVariant1, global::Braintrust.WindowedAutomationConfigActionVariant2>>? actions)
        {
            this.EventType = eventType;
            this.ProductOrigin = productOrigin;
            this.Status = status;
            this.Threshold = threshold;
            this.Window = window ?? throw new global::System.ArgumentNullException(nameof(window));
            this.Loop = loop;
            this.Actions = actions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfig" /> class.
        /// </summary>
        public WindowedAutomationConfig()
        {
        }

    }
}