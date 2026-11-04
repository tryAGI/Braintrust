#nullable enable

namespace Braintrust
{
    public partial interface ICustomColumnsClient
    {
        /// <summary>
        /// Delete custom column<br/>
        /// Delete a custom column object by its id. Requires delete permission on the scoping object.
        /// </summary>
        /// <param name="columnId">
        /// CustomColumn id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.CustomColumn> DeleteCustomColumnIdAsync(
            global::System.Guid columnId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete custom column<br/>
        /// Delete a custom column object by its id. Requires delete permission on the scoping object.
        /// </summary>
        /// <param name="columnId">
        /// CustomColumn id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.CustomColumn>> DeleteCustomColumnIdAsResponseAsync(
            global::System.Guid columnId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}