#nullable enable

namespace Braintrust
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Get function<br/>
        /// Get a function object by its id
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="version">
        /// Retrieve prompt at a specific version.<br/>
        /// The version id can either be a transaction id (e.g. '1000192656880881099') or a version identifier (e.g. '81cd05ee665fdfb3').
        /// </param>
        /// <param name="environment">
        /// Filter by environment slug. Cannot be used together with `version`.<br/>
        /// For `GET /v1/prompt`, return prompts associated with the environment at their assigned versions. Pagination applies to the matching prompts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.Function2> GetFunctionIdAsync(
            global::System.Guid functionId,
            string? version = default,
            string? environment = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get function<br/>
        /// Get a function object by its id
        /// </summary>
        /// <param name="functionId">
        /// Function id
        /// </param>
        /// <param name="version">
        /// Retrieve prompt at a specific version.<br/>
        /// The version id can either be a transaction id (e.g. '1000192656880881099') or a version identifier (e.g. '81cd05ee665fdfb3').
        /// </param>
        /// <param name="environment">
        /// Filter by environment slug. Cannot be used together with `version`.<br/>
        /// For `GET /v1/prompt`, return prompts associated with the environment at their assigned versions. Pagination applies to the matching prompts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.Function2>> GetFunctionIdAsResponseAsync(
            global::System.Guid functionId,
            string? version = default,
            string? environment = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}