
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchProjectSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id_fields")]
        public global::System.Collections.Generic.IList<global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<string>>>? UserIdFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectSettings" /> class.
        /// </summary>
        /// <param name="userIdFields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchProjectSettings(
            global::System.Collections.Generic.IList<global::Braintrust.AnyOf<string, global::System.Collections.Generic.IList<string>>>? userIdFields)
        {
            this.UserIdFields = userIdFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectSettings" /> class.
        /// </summary>
        public PatchProjectSettings()
        {
        }

    }
}