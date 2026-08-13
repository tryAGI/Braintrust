
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// A project group is a collection of projects which can inherit access from project-group ACLs
    /// </summary>
    public sealed partial class ProjectGroup
    {
        /// <summary>
        /// Unique identifier for the project group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Unique id for the organization that the project group belongs under<br/>
        /// It is forbidden to change the org after creating a project group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// Identifies the user who created the project group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Date of project group creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

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
        /// Date of project group deletion, or null if the project group is still active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Sorted ids of active projects in this project group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> MemberProjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGroup" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the project group
        /// </param>
        /// <param name="orgId">
        /// Unique id for the organization that the project group belongs under<br/>
        /// It is forbidden to change the org after creating a project group
        /// </param>
        /// <param name="name">
        /// Name of the project group
        /// </param>
        /// <param name="memberProjects">
        /// Sorted ids of active projects in this project group
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the project group
        /// </param>
        /// <param name="created">
        /// Date of project group creation
        /// </param>
        /// <param name="description">
        /// Textual description of the project group
        /// </param>
        /// <param name="deletedAt">
        /// Date of project group deletion, or null if the project group is still active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectGroup(
            global::System.Guid id,
            global::System.Guid orgId,
            string name,
            global::System.Collections.Generic.IList<global::System.Guid> memberProjects,
            global::System.Guid? userId,
            global::System.DateTime? created,
            string? description,
            global::System.DateTime? deletedAt)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.UserId = userId;
            this.Created = created;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.DeletedAt = deletedAt;
            this.MemberProjects = memberProjects ?? throw new global::System.ArgumentNullException(nameof(memberProjects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGroup" /> class.
        /// </summary>
        public ProjectGroup()
        {
        }

    }
}