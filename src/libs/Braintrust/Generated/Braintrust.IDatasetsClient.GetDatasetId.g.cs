#nullable enable

namespace Braintrust
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get dataset<br/>
        /// Get a dataset object by its id
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Dataset> GetDatasetIdAsync(
            global::System.Guid datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}