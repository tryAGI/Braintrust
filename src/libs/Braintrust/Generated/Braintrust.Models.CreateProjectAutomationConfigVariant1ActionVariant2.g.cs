
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectAutomationConfigVariant1ActionVariant2
    {
        /// <summary>
        /// The type of action to take
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter))]
        public global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type Type { get; set; }

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
        /// Publish a Slack mrkdwn digest.<br/>
        /// Pattern selection requirement: include every selected Pattern whose final status is active at the end of this automation run, plus every selected Pattern that changed from active to inactive during this run (a newly inactive outcome). Exclude Patterns that were already inactive before this run and remained inactive. Do not mention excluded Patterns anywhere in the digest, including Highlights. If no selected Patterns meet these criteria, say "No current pattern outcomes." This requirement overrides conflicting formatting guidance.<br/>
        /// Include a complete "*Pattern outcomes*" section with one row for every included Pattern.<br/>
        /// Use this row format exactly:<br/>
        /// • &lt;pattern_url|Pattern title&gt; — `outcome`<br/>
        /// If a Pattern has no URL, use the plain title instead. Do not use GitHub Markdown tables or code-block tables, because links must remain clickable. Do not omit any active selected Pattern.<br/>
        /// After the outcome list, include a "*Highlights*" section with one very short paragraph, 2-3 sentences maximum. Summarize what changed or what broadly stands out among the included active Patterns. Do not introduce new claims beyond the run report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatting_prompt")]
        public string? FormattingPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant1ActionVariant2" /> class.
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
        /// Publish a Slack mrkdwn digest.<br/>
        /// Pattern selection requirement: include every selected Pattern whose final status is active at the end of this automation run, plus every selected Pattern that changed from active to inactive during this run (a newly inactive outcome). Exclude Patterns that were already inactive before this run and remained inactive. Do not mention excluded Patterns anywhere in the digest, including Highlights. If no selected Patterns meet these criteria, say "No current pattern outcomes." This requirement overrides conflicting formatting guidance.<br/>
        /// Include a complete "*Pattern outcomes*" section with one row for every included Pattern.<br/>
        /// Use this row format exactly:<br/>
        /// • &lt;pattern_url|Pattern title&gt; — `outcome`<br/>
        /// If a Pattern has no URL, use the plain title instead. Do not use GitHub Markdown tables or code-block tables, because links must remain clickable. Do not omit any active selected Pattern.<br/>
        /// After the outcome list, include a "*Highlights*" section with one very short paragraph, 2-3 sentences maximum. Summarize what changed or what broadly stands out among the included active Patterns. Do not introduce new claims beyond the run report.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectAutomationConfigVariant1ActionVariant2(
            string workspaceId,
            string channel,
            global::Braintrust.CreateProjectAutomationConfigVariant1ActionVariant2Type type,
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
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant1ActionVariant2" /> class.
        /// </summary>
        public CreateProjectAutomationConfigVariant1ActionVariant2()
        {
        }

    }
}