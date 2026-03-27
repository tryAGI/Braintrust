#nullable enable

namespace Braintrust
{
    public partial interface IProjectScoresClient
    {
        /// <summary>
        /// Create project_score<br/>
        /// Create a new project_score. If there is an existing project_score in the project with the same name as the one specified in the request, will return the existing project_score unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectScore> PostProjectScoreAsync(

            global::Braintrust.CreateProjectScore request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project_score<br/>
        /// Create a new project_score. If there is an existing project_score in the project with the same name as the one specified in the request, will return the existing project_score unmodified
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the project score belongs under
        /// </param>
        /// <param name="name">
        /// Name of the project score
        /// </param>
        /// <param name="description">
        /// Textual description of the project score
        /// </param>
        /// <param name="scoreType">
        /// The type of the configured score
        /// </param>
        /// <param name="categories"></param>
        /// <param name="config"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectScore> PostProjectScoreAsync(
            global::System.Guid projectId,
            string name,
            global::Braintrust.ProjectScoreType scoreType,
            string? description = default,
            global::Braintrust.ProjectScoreCategories? categories = default,
            global::Braintrust.ProjectScoreConfig? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}