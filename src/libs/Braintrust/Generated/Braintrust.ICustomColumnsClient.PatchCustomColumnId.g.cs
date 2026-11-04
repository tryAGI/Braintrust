#nullable enable

namespace Braintrust
{
    public partial interface ICustomColumnsClient
    {
        /// <summary>
        /// Partially update custom column<br/>
        /// Update the name or expression of a custom column. Fields that are omitted are left unchanged. Requires update permission on the scoping object.
        /// </summary>
        /// <param name="columnId">
        /// CustomColumn id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.CustomColumn> PatchCustomColumnIdAsync(
            global::System.Guid columnId,

            global::Braintrust.PatchCustomColumn request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update custom column<br/>
        /// Update the name or expression of a custom column. Fields that are omitted are left unchanged. Requires update permission on the scoping object.
        /// </summary>
        /// <param name="columnId">
        /// CustomColumn id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.CustomColumn>> PatchCustomColumnIdAsResponseAsync(
            global::System.Guid columnId,

            global::Braintrust.PatchCustomColumn request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update custom column<br/>
        /// Update the name or expression of a custom column. Fields that are omitted are left unchanged. Requires update permission on the scoping object.
        /// </summary>
        /// <param name="columnId">
        /// CustomColumn id
        /// </param>
        /// <param name="name">
        /// The name of the custom column
        /// </param>
        /// <param name="expr">
        /// The expression used to extract the value for the custom column
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.CustomColumn> PatchCustomColumnIdAsync(
            global::System.Guid columnId,
            string? name = default,
            string? expr = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}