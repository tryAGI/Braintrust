#nullable enable

namespace Braintrust
{
    public partial interface IOrgAutomationsClient
    {
        /// <summary>
        /// Delete org_automation<br/>
        /// Delete a org_automation object by its id
        /// </summary>
        /// <param name="orgAutomationId">
        /// OrgAutomation id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.OrgAutomation> DeleteOrgAutomationIdAsync(
            global::System.Guid orgAutomationId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete org_automation<br/>
        /// Delete a org_automation object by its id
        /// </summary>
        /// <param name="orgAutomationId">
        /// OrgAutomation id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.OrgAutomation>> DeleteOrgAutomationIdAsResponseAsync(
            global::System.Guid orgAutomationId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}