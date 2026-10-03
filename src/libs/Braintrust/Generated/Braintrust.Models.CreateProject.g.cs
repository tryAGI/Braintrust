
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProject
    {
        /// <summary>
        /// Name of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Textual description of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the project belongs in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// Create the project within the named project group in this organization. Requires project_group:update and either project_group_projects:create on the group or org_project:create on the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_group_name")]
        public string? ProjectGroupName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProject" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description">
        /// Textual description of the project
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the project belongs in.
        /// </param>
        /// <param name="projectGroupName">
        /// Create the project within the named project group in this organization. Requires project_group:update and either project_group_projects:create on the group or org_project:create on the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProject(
            string name,
            string? description,
            string? orgName,
            string? projectGroupName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.OrgName = orgName;
            this.ProjectGroupName = projectGroupName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProject" /> class.
        /// </summary>
        public CreateProject()
        {
        }

    }
}