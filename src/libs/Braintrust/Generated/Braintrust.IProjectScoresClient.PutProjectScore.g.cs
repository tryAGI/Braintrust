#nullable enable

namespace Braintrust
{
    public partial interface IProjectScoresClient
    {
        /// <summary>
        /// Create or replace project_score<br/>
        /// Create or replace project_score. If there is an existing project_score in the project with the same name as the one specified in the request, will replace the existing project_score with the provided fields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectScore> PutProjectScoreAsync(

            global::Braintrust.CreateProjectScore request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace project_score<br/>
        /// Create or replace project_score. If there is an existing project_score in the project with the same name as the one specified in the request, will replace the existing project_score with the provided fields
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
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectScore> PutProjectScoreAsync(
            global::System.Guid projectId,
            string name,
            global::Braintrust.ProjectScoreType scoreType,
            string? description = default,
            global::Braintrust.ProjectScoreCategories? categories = default,
            global::Braintrust.ProjectScoreConfig? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}