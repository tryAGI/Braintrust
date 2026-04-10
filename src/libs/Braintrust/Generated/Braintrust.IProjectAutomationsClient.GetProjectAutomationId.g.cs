#nullable enable

namespace Braintrust
{
    public partial interface IProjectAutomationsClient
    {
        /// <summary>
        /// Get project_automation<br/>
        /// Get a project_automation object by its id
        /// </summary>
        /// <param name="projectAutomationId">
        /// ProjectAutomation id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectAutomation> GetProjectAutomationIdAsync(
            global::System.Guid projectAutomationId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}