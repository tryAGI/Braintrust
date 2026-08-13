
#nullable enable

namespace Braintrust
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrgAutomationResponse
    {
        /// <summary>
        /// A list of org_automation objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Braintrust.OrgAutomation> Objects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgAutomationResponse" /> class.
        /// </summary>
        /// <param name="objects">
        /// A list of org_automation objects
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrgAutomationResponse(
            global::System.Collections.Generic.IList<global::Braintrust.OrgAutomation> objects)
        {
            this.Objects = objects ?? throw new global::System.ArgumentNullException(nameof(objects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgAutomationResponse" /> class.
        /// </summary>
        public GetOrgAutomationResponse()
        {
        }

    }
}