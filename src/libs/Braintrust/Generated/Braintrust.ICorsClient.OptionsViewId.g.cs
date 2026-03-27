#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/view/{view_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="viewId">
        /// View id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsViewIdAsync(
            global::System.Guid viewId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}