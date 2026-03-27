#nullable enable

namespace Braintrust
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project<br/>
        /// Get a project object by its id
        /// </summary>
        /// <param name="projectId">
        /// Project id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Project> GetProjectIdAsync(
            global::System.Guid projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}