#nullable enable

namespace Braintrust
{
    public partial interface IProjectScoresClient
    {
        /// <summary>
        /// Partially update project_score<br/>
        /// Partially update a project_score object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectScoreId">
        /// ProjectScore id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectScore> PatchProjectScoreIdAsync(
            global::System.Guid projectScoreId,

            global::Braintrust.PatchProjectScore request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update project_score<br/>
        /// Partially update a project_score object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectScoreId">
        /// ProjectScore id
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ProjectScore> PatchProjectScoreIdAsync(
            global::System.Guid projectScoreId,
            string? name = default,
            string? description = default,
            global::Braintrust.ProjectScoreType? scoreType = default,
            global::Braintrust.ProjectScoreCategories? categories = default,
            global::Braintrust.ProjectScoreConfig? config = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}