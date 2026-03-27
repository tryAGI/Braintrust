#nullable enable

namespace Braintrust
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Delete experiment<br/>
        /// Delete an experiment object by its id
        /// </summary>
        /// <param name="experimentId">
        /// Experiment id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Experiment> DeleteExperimentIdAsync(
            global::System.Guid experimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}