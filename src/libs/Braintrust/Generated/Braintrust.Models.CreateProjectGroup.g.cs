
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectGroup
    {
        /// <summary>
        /// Name of the project group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Textual description of the project group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the project group belongs in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectGroup" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project group
        /// </param>
        /// <param name="description">
        /// Textual description of the project group
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the project group belongs in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectGroup(
            string name,
            string? description,
            string? orgName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.OrgName = orgName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectGroup" /> class.
        /// </summary>
        public CreateProjectGroup()
        {
        }

    }
}