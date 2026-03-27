#nullable enable

namespace Braintrust
{
    public partial interface IProjectAutomationsClient
    {
        /// <summary>
        /// Delete project_automation<br/>
        /// Delete a project_automation object by its id
        /// </summary>
        /// <param name="projectAutomationId">
        /// ProjectAutomation id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectAutomation> DeleteProjectAutomationIdAsync(
            global::System.Guid projectAutomationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}