
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeBundleLocationVariant3SandboxSpecVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Braintrust.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderJsonConverter))]
        public global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider Provider { get; set; }

        /// <summary>
        /// sandbox snapshot ref
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SnapshotRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationVariant3SandboxSpecVariant1" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="snapshotRef">
        /// sandbox snapshot ref
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeBundleLocationVariant3SandboxSpecVariant1(
            string snapshotRef,
            global::Braintrust.CodeBundleLocationVariant3SandboxSpecVariant1Provider provider)
        {
            this.SnapshotRef = snapshotRef ?? throw new global::System.ArgumentNullException(nameof(snapshotRef));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationVariant3SandboxSpecVariant1" /> class.
        /// </summary>
        public CodeBundleLocationVariant3SandboxSpecVariant1()
        {
        }
    }
}