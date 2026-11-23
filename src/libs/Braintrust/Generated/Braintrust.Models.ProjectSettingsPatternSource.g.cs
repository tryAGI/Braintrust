
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectSettingsPatternSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The project MCP server that reads this source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid McpServerId { get; set; }

        /// <summary>
        /// What the user wants Patterns to look for in this source, in their own words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsPatternSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="mcpServerId">
        /// The project MCP server that reads this source.
        /// </param>
        /// <param name="instructions">
        /// What the user wants Patterns to look for in this source, in their own words.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSettingsPatternSource(
            string type,
            global::System.Guid mcpServerId,
            string? instructions)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.McpServerId = mcpServerId;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsPatternSource" /> class.
        /// </summary>
        public ProjectSettingsPatternSource()
        {
        }

    }
}