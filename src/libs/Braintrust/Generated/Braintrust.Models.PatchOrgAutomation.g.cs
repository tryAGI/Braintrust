
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrgAutomation
    {
        /// <summary>
        /// Name of the project automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Textual description of the project automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The configuration for the org automation rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Braintrust.PatchOrgAutomationConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrgAutomation" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project automation
        /// </param>
        /// <param name="description">
        /// Textual description of the project automation
        /// </param>
        /// <param name="config">
        /// The configuration for the org automation rule
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrgAutomation(
            string? name,
            string? description,
            global::Braintrust.PatchOrgAutomationConfig? config)
        {
            this.Name = name;
            this.Description = description;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrgAutomation" /> class.
        /// </summary>
        public PatchOrgAutomation()
        {
        }

    }
}