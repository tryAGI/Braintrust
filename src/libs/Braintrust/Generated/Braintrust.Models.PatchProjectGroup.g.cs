
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchProjectGroup
    {
        /// <summary>
        /// Name of the project group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Textual description of the project group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A list of project IDs to add to the project group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_member_projects")]
        public global::System.Collections.Generic.IList<global::System.Guid>? AddMemberProjects { get; set; }

        /// <summary>
        /// A list of project IDs to remove from the project group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_member_projects")]
        public global::System.Collections.Generic.IList<global::System.Guid>? RemoveMemberProjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectGroup" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project group
        /// </param>
        /// <param name="description">
        /// Textual description of the project group
        /// </param>
        /// <param name="addMemberProjects">
        /// A list of project IDs to add to the project group
        /// </param>
        /// <param name="removeMemberProjects">
        /// A list of project IDs to remove from the project group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchProjectGroup(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::System.Guid>? addMemberProjects,
            global::System.Collections.Generic.IList<global::System.Guid>? removeMemberProjects)
        {
            this.Name = name;
            this.Description = description;
            this.AddMemberProjects = addMemberProjects;
            this.RemoveMemberProjects = removeMemberProjects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectGroup" /> class.
        /// </summary>
        public PatchProjectGroup()
        {
        }

    }
}