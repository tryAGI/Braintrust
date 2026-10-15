
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulatedUser
    {
        /// <summary>
        /// Unique identifier for the simulated user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Legacy transaction id. Not returned by simulated user CRUD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_xact_id")]
        public string? XactId { get; set; }

        /// <summary>
        /// Unique identifier for the project that the simulated user belongs under
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// Name of the simulated user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Date of simulated user creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The simulated user's role, scenario, and behavior
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// The simulated user's objective, used to decide when to end the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goal")]
        public string? Goal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Braintrust.SimulatedUserVoiceConfig VoiceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulatedUser" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the simulated user
        /// </param>
        /// <param name="projectId">
        /// Unique identifier for the project that the simulated user belongs under
        /// </param>
        /// <param name="orgId">
        /// Unique identifier for the organization
        /// </param>
        /// <param name="name">
        /// Name of the simulated user
        /// </param>
        /// <param name="instructions">
        /// The simulated user's role, scenario, and behavior
        /// </param>
        /// <param name="voiceConfig"></param>
        /// <param name="xactId">
        /// Legacy transaction id. Not returned by simulated user CRUD.
        /// </param>
        /// <param name="created">
        /// Date of simulated user creation
        /// </param>
        /// <param name="goal">
        /// The simulated user's objective, used to decide when to end the conversation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulatedUser(
            global::System.Guid id,
            global::System.Guid projectId,
            global::System.Guid orgId,
            string name,
            string instructions,
            global::Braintrust.SimulatedUserVoiceConfig voiceConfig,
            string? xactId,
            global::System.DateTime? created,
            string? goal)
        {
            this.Id = id;
            this.XactId = xactId;
            this.ProjectId = projectId;
            this.OrgId = orgId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Created = created;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Goal = goal;
            this.VoiceConfig = voiceConfig ?? throw new global::System.ArgumentNullException(nameof(voiceConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulatedUser" /> class.
        /// </summary>
        public SimulatedUser()
        {
        }

    }
}