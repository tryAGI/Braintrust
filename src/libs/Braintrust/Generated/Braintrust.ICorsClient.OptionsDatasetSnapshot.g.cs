#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/dataset_snapshot`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsDatasetSnapshotAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}