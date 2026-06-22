
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// An agent is a project-scoped durable object that identifies an AI agent or service emitting spans
    /// </summary>
    public sealed partial class PatchAgent
    {
        /// <summary>
        /// Name of the agent. Within a project, agent names are unique
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Textual description of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// User-controlled metadata about the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAgent" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the agent. Within a project, agent names are unique
        /// </param>
        /// <param name="description">
        /// Textual description of the agent
        /// </param>
        /// <param name="metadata">
        /// User-controlled metadata about the agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAgent(
            string? name,
            string? description,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata)
        {
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAgent" /> class.
        /// </summary>
        public PatchAgent()
        {
        }

    }
}