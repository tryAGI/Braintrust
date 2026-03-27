#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/experiment/{experiment_id}/feedback`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="experimentId">
        /// Experiment id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsExperimentIdFeedbackAsync(
            global::System.Guid experimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}