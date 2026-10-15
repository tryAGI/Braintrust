#nullable enable

namespace Braintrust
{
    public partial interface ISimulatedUsersClient
    {
        /// <summary>
        /// List simulated users<br/>
        /// List simulated users in a project, ordered by UUID. Requires project read permission.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="ids"></param>
        /// <param name="simulatedUserName"></param>
        /// <param name="limit">
        /// Limit the number of objects to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="startingAfter">
        /// Pagination cursor id.<br/>
        /// For example, if the final item in the last page you fetched had an id of `foo`, pass `starting_after=foo` to fetch the next page. Note: you may only pass one of `starting_after` and `ending_before`
        /// </param>
        /// <param name="endingBefore">
        /// Pagination cursor id.<br/>
        /// For example, if the initial item in the last page you fetched had an id of `foo`, pass `ending_before=foo` to fetch the previous page. Note: you may only pass one of `starting_after` and `ending_before`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ListSimulatedUsersResponse> ListSimulatedUsersAsync(
            global::System.Guid projectId,
            global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>? ids = default,
            string? simulatedUserName = default,
            int? limit = default,
            global::System.Guid? startingAfter = default,
            global::System.Guid? endingBefore = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List simulated users<br/>
        /// List simulated users in a project, ordered by UUID. Requires project read permission.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="ids"></param>
        /// <param name="simulatedUserName"></param>
        /// <param name="limit">
        /// Limit the number of objects to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="startingAfter">
        /// Pagination cursor id.<br/>
        /// For example, if the final item in the last page you fetched had an id of `foo`, pass `starting_after=foo` to fetch the next page. Note: you may only pass one of `starting_after` and `ending_before`
        /// </param>
        /// <param name="endingBefore">
        /// Pagination cursor id.<br/>
        /// For example, if the initial item in the last page you fetched had an id of `foo`, pass `ending_before=foo` to fetch the previous page. Note: you may only pass one of `starting_after` and `ending_before`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.ListSimulatedUsersResponse>> ListSimulatedUsersAsResponseAsync(
            global::System.Guid projectId,
            global::Braintrust.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>? ids = default,
            string? simulatedUserName = default,
            int? limit = default,
            global::System.Guid? startingAfter = default,
            global::System.Guid? endingBefore = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}