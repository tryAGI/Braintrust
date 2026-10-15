
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchSimulatedUser
    {
        /// <summary>
        /// Name of the simulated user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The simulated user's role, scenario, and behavior
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The simulated user's objective. Set to null to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goal")]
        public string? Goal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_config")]
        public global::Braintrust.SimulatedUserVoiceConfig? VoiceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchSimulatedUser" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the simulated user
        /// </param>
        /// <param name="instructions">
        /// The simulated user's role, scenario, and behavior
        /// </param>
        /// <param name="goal">
        /// The simulated user's objective. Set to null to clear it.
        /// </param>
        /// <param name="voiceConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchSimulatedUser(
            string? name,
            string? instructions,
            string? goal,
            global::Braintrust.SimulatedUserVoiceConfig? voiceConfig)
        {
            this.Name = name;
            this.Instructions = instructions;
            this.Goal = goal;
            this.VoiceConfig = voiceConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchSimulatedUser" /> class.
        /// </summary>
        public PatchSimulatedUser()
        {
        }

    }
}