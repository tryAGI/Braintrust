#nullable enable

namespace Braintrust
{
    public partial interface IOrgAutomationsClient
    {
        /// <summary>
        /// Create org_automation<br/>
        /// Create a new org_automation. If there is an existing org_automation with the same name as the one specified in the request, will return the existing org_automation unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.OrgAutomation> PostOrgAutomationAsync(

            global::Braintrust.CreateOrgAutomation request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create org_automation<br/>
        /// Create a new org_automation. If there is an existing org_automation with the same name as the one specified in the request, will return the existing org_automation unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.OrgAutomation>> PostOrgAutomationAsResponseAsync(

            global::Braintrust.CreateOrgAutomation request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create org_automation<br/>
        /// Create a new org_automation. If there is an existing org_automation with the same name as the one specified in the request, will return the existing org_automation unmodified
        /// </summary>
        /// <param name="orgId">
        /// Unique identifier for the organization that the org automation belongs under
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
        global::System.Threading.Tasks.Task<global::Braintrust.OrgAutomation> PostOrgAutomationAsync(
            global::System.Guid orgId,
            string name,
            global::Braintrust.CreateOrgAutomationConfig config,
            string? description = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}