#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/project_score/{project_score_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="projectScoreId">
        /// ProjectScore id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsProjectScoreIdAsync(
            global::System.Guid projectScoreId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}