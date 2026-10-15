
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSimulatedUser
    {
        /// <summary>
        /// Name of the simulated user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateSimulatedUser" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the simulated user
        /// </param>
        /// <param name="instructions">
        /// The simulated user's role, scenario, and behavior
        /// </param>
        /// <param name="voiceConfig"></param>
        /// <param name="goal">
        /// The simulated user's objective, used to decide when to end the conversation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSimulatedUser(
            string name,
            string instructions,
            global::Braintrust.SimulatedUserVoiceConfig voiceConfig,
            string? goal)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Goal = goal;
            this.VoiceConfig = voiceConfig ?? throw new global::System.ArgumentNullException(nameof(voiceConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSimulatedUser" /> class.
        /// </summary>
        public CreateSimulatedUser()
        {
        }

    }
}