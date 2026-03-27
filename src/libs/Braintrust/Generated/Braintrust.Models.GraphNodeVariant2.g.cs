
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphNodeVariant2
    {
        /// <summary>
        /// The description of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The position of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::Braintrust.GraphNodeVariant2Position? Position { get; set; }

        /// <summary>
        /// The input to the graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.GraphNodeVariant2TypeJsonConverter))]
        public global::Braintrust.GraphNodeVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant2" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the node
        /// </param>
        /// <param name="position">
        /// The position of the node
        /// </param>
        /// <param name="type">
        /// The input to the graph
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphNodeVariant2(
            string? description,
            global::Braintrust.GraphNodeVariant2Position? position,
            global::Braintrust.GraphNodeVariant2Type type)
        {
            this.Description = description;
            this.Position = position;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant2" /> class.
        /// </summary>
        public GraphNodeVariant2()
        {
        }
    }
}