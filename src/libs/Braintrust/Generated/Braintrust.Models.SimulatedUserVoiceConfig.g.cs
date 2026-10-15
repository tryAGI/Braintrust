
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulatedUserVoiceConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid VoiceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking_rate")]
        public double? SpeakingRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulatedUserVoiceConfig" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="language"></param>
        /// <param name="accent"></param>
        /// <param name="speakingRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulatedUserVoiceConfig(
            global::System.Guid voiceId,
            string? language,
            string? accent,
            double? speakingRate)
        {
            this.VoiceId = voiceId;
            this.Language = language;
            this.Accent = accent;
            this.SpeakingRate = speakingRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulatedUserVoiceConfig" /> class.
        /// </summary>
        public SimulatedUserVoiceConfig()
        {
        }

    }
}