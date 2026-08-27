
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectScoreConfigVisibility
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<string>? Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreConfigVisibility" /> class.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="groups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectScoreConfigVisibility(
            global::System.Collections.Generic.IList<string>? users,
            global::System.Collections.Generic.IList<string>? groups)
        {
            this.Users = users;
            this.Groups = groups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreConfigVisibility" /> class.
        /// </summary>
        public ProjectScoreConfigVisibility()
        {
        }

    }
}