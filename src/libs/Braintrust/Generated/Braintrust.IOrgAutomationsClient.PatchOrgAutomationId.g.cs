#nullable enable

namespace Braintrust
{
    public partial interface IOrgAutomationsClient
    {
        /// <summary>
        /// Partially update org_automation<br/>
        /// Partially update a org_automation object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="orgAutomationId">
        /// OrgAutomation id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.OrgAutomation> PatchOrgAutomationIdAsync(
            global::System.Guid orgAutomationId,

            global::Braintrust.PatchOrgAutomation request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update org_automation<br/>
        /// Partially update a org_automation object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="orgAutomationId">
        /// OrgAutomation id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.OrgAutomation>> PatchOrgAutomationIdAsResponseAsync(
            global::System.Guid orgAutomationId,

            global::Braintrust.PatchOrgAutomation request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update org_automation<br/>
        /// Partially update a org_automation object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="orgAutomationId">
        /// OrgAutomation id
        /// </param>
        /// <param name="name">
        /// Name of the project automation
        /// </param>
        /// <param name="description">
        /// Textual description of the project automation
        /// </param>
        /// <param name="config">
        /// The configuration for the org automation rule
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.OrgAutomation> PatchOrgAutomationIdAsync(
            global::System.Guid orgAutomationId,
            string? name = default,
            string? description = default,
            global::Braintrust.PatchOrgAutomationConfig? config = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}