
#nullable enable

namespace Braintrust
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WindowedAutomationConfigActionVariant1HeaderVariant2
    {
        /// <summary>
        /// The HTTP header name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The data-plane secret containing the header value, bound to the webhook URL it was saved for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SecretName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigActionVariant1HeaderVariant2" /> class.
        /// </summary>
        /// <param name="name">
        /// The HTTP header name
        /// </param>
        /// <param name="secretName">
        /// The data-plane secret containing the header value, bound to the webhook URL it was saved for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WindowedAutomationConfigActionVariant1HeaderVariant2(
            string name,
            global::System.Guid secretName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SecretName = secretName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowedAutomationConfigActionVariant1HeaderVariant2" /> class.
        /// </summary>
        public WindowedAutomationConfigActionVariant1HeaderVariant2()
        {
        }

    }
}