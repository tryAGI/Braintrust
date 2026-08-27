
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// An agent is a project-scoped durable object that identifies an AI agent or service emitting spans
    /// </summary>
    public sealed partial class Agent
    {
        /// <summary>
        /// Unique identifier for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Unique identifier for the project that the agent belongs under
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// Date of agent creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Name of the agent. Within a project, agent names are unique
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Stable, URL-safe identifier for the agent, unique within its project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Agent classification: 'custom' for customer-defined agents, 'loop' for built-in Loop agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

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
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the agent
        /// </param>
        /// <param name="projectId">
        /// Unique identifier for the project that the agent belongs under
        /// </param>
        /// <param name="userId"></param>
        /// <param name="name">
        /// Name of the agent. Within a project, agent names are unique
        /// </param>
        /// <param name="slug">
        /// Stable, URL-safe identifier for the agent, unique within its project.
        /// </param>
        /// <param name="kind">
        /// Agent classification: 'custom' for customer-defined agents, 'loop' for built-in Loop agents.
        /// </param>
        /// <param name="created">
        /// Date of agent creation
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
        public Agent(
            global::System.Guid id,
            global::System.Guid projectId,
            global::System.Guid userId,
            string name,
            string slug,
            string kind,
            global::System.DateTime? created,
            string? description,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.Created = created;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }

    }
}