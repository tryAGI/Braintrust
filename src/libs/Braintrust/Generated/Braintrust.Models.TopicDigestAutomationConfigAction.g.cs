
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// The Slack action to take when the digest is sent
    /// </summary>
    public sealed partial class TopicDigestAutomationConfigAction
    {
        /// <summary>
        /// The type of action to take
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.TopicDigestAutomationConfigActionTypeJsonConverter))]
        public global::Braintrust.TopicDigestAutomationConfigActionType Type { get; set; }

        /// <summary>
        /// The Slack workspace ID to post to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// The Slack channel ID to post to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Channel { get; set; }

        /// <summary>
        /// Custom message template for the alert
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_template")]
        public string? MessageTemplate { get; set; }

        /// <summary>
        /// Instructions for Loop to format content sent to this destination
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatting_prompt")]
        public string? FormattingPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDigestAutomationConfigAction" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// The Slack workspace ID to post to
        /// </param>
        /// <param name="channel">
        /// The Slack channel ID to post to
        /// </param>
        /// <param name="type">
        /// The type of action to take
        /// </param>
        /// <param name="messageTemplate">
        /// Custom message template for the alert
        /// </param>
        /// <param name="formattingPrompt">
        /// Instructions for Loop to format content sent to this destination
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicDigestAutomationConfigAction(
            string workspaceId,
            string channel,
            global::Braintrust.TopicDigestAutomationConfigActionType type,
            string? messageTemplate,
            string? formattingPrompt)
        {
            this.Type = type;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.Channel = channel ?? throw new global::System.ArgumentNullException(nameof(channel));
            this.MessageTemplate = messageTemplate;
            this.FormattingPrompt = formattingPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDigestAutomationConfigAction" /> class.
        /// </summary>
        public TopicDigestAutomationConfigAction()
        {
        }

    }
}