
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// Project-wide Slack user or agent and prompt for Pattern alert threads. Applies only to destinations in the selected workspace. Unset or null disables mentions.
    /// </summary>
    public sealed partial class ProjectSettingsPatternAlertMention
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Slack member ID of the user or agent to mention in a Pattern alert's thread to investigate the pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mention_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MentionUserId { get; set; }

        /// <summary>
        /// Username shown for the selected user or agent. Mentions use mention_user_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mention_handle")]
        public string? MentionHandle { get; set; }

        /// <summary>
        /// Message posted after the mention in a Pattern alert's thread. {{pattern}} is replaced with a link to the pattern. Defaults to "Please investigate this pattern: {{pattern}}. Review the evidence, identify the root cause, and suggest a fix."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mention_prompt")]
        public string? MentionPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsPatternAlertMention" /> class.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="mentionUserId">
        /// Slack member ID of the user or agent to mention in a Pattern alert's thread to investigate the pattern.
        /// </param>
        /// <param name="mentionHandle">
        /// Username shown for the selected user or agent. Mentions use mention_user_id.
        /// </param>
        /// <param name="mentionPrompt">
        /// Message posted after the mention in a Pattern alert's thread. {{pattern}} is replaced with a link to the pattern. Defaults to "Please investigate this pattern: {{pattern}}. Review the evidence, identify the root cause, and suggest a fix."
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSettingsPatternAlertMention(
            string workspaceId,
            string mentionUserId,
            string? mentionHandle,
            string? mentionPrompt)
        {
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.MentionUserId = mentionUserId ?? throw new global::System.ArgumentNullException(nameof(mentionUserId));
            this.MentionHandle = mentionHandle;
            this.MentionPrompt = mentionPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsPatternAlertMention" /> class.
        /// </summary>
        public ProjectSettingsPatternAlertMention()
        {
        }

    }
}