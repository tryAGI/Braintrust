
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectAutomationConfigVariant5ActionVariant1HeaderVariant1
    {
        /// <summary>
        /// The HTTP header name. Connection, Content-Length, Content-Type, Expect, Host, Idempotency-Key, Keep-Alive, Transfer-Encoding, and Upgrade are reserved and can't be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The HTTP header value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant5ActionVariant1HeaderVariant1" /> class.
        /// </summary>
        /// <param name="name">
        /// The HTTP header name. Connection, Content-Length, Content-Type, Expect, Host, Idempotency-Key, Keep-Alive, Transfer-Encoding, and Upgrade are reserved and can't be used.
        /// </param>
        /// <param name="value">
        /// The HTTP header value
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectAutomationConfigVariant5ActionVariant1HeaderVariant1(
            string name,
            string value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant5ActionVariant1HeaderVariant1" /> class.
        /// </summary>
        public ProjectAutomationConfigVariant5ActionVariant1HeaderVariant1()
        {
        }

    }
}