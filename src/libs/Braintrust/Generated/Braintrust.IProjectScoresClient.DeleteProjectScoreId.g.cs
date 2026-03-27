#nullable enable

namespace Braintrust
{
    public partial interface IProjectScoresClient
    {
        /// <summary>
        /// Delete project_score<br/>
        /// Delete a project_score object by its id
        /// </summary>
        /// <param name="projectScoreId">
        /// ProjectScore id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectScore> DeleteProjectScoreIdAsync(
            global::System.Guid projectScoreId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}