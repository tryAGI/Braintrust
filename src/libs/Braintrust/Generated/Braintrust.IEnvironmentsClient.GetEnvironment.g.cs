#nullable enable

namespace Braintrust
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Get environment
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Environment> GetEnvironmentAsync(
            global::System.Guid environmentId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}