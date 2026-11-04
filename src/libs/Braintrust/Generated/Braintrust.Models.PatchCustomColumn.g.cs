
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchCustomColumn
    {
        /// <summary>
        /// The name of the custom column
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The expression used to extract the value for the custom column
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expr")]
        public string? Expr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCustomColumn" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the custom column
        /// </param>
        /// <param name="expr">
        /// The expression used to extract the value for the custom column
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCustomColumn(
            string? name,
            string? expr)
        {
            this.Name = name;
            this.Expr = expr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCustomColumn" /> class.
        /// </summary>
        public PatchCustomColumn()
        {
        }

    }
}