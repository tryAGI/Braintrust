#nullable enable

namespace Braintrust
{
    public partial interface IProjectTagsClient
    {
        /// <summary>
        /// Delete project_tag<br/>
        /// Delete a project_tag object by its id
        /// </summary>
        /// <param name="projectTagId">
        /// ProjectTag id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectTag> DeleteProjectTagIdAsync(
            global::System.Guid projectTagId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}