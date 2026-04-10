#nullable enable

namespace Braintrust
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List users<br/>
        /// List out all users. The users are sorted by creation date, with the most recently-created users coming first
        /// </summary>
        /// <param name="limit">
        /// Limit the number of objects to return
        /// </param>
        /// <param name="startingAfter">
        /// Pagination cursor id.<br/>
        /// For example, if the final item in the last page you fetched had an id of `foo`, pass `starting_after=foo` to fetch the next page. Note: you may only pass one of `starting_after` and `ending_before`
        /// </param>
        /// <param name="endingBefore">
        /// Pagination cursor id.<br/>
        /// For example, if the initial item in the last page you fetched had an id of `foo`, pass `ending_before=foo` to fetch the previous page. Note: you may only pass one of `starting_after` and `ending_before`
        /// </param>
        /// <param name="ids">
        /// Filter search results to a particular set of object IDs. To specify a list of IDs, include the query param multiple times
        /// </param>
        /// <param name="givenName">
        /// Given name of the user to search for. You may pass the param multiple times to filter for more than one given name
        /// </param>
        /// <param name="familyName">
        /// Family name of the user to search for. You may pass the param multiple times to filter for more than one family name
        /// </param>
        /// <param name="email">
        /// Email of the user to search for. You may pass the param multiple times to filter for more than one email
        /// </param>
        /// <param name="orgName">
        /// Filter search results to within a particular organization
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.GetUserResponse> GetUserAsync(
            int? limit = default,
            global::System.Guid? startingAfter = default,
            global::System.Guid? endingBefore = default,
            global::Braintrust.Ids? ids = default,
            global::Braintrust.UserGivenName? givenName = default,
            global::Braintrust.UserFamilyName? familyName = default,
            global::Braintrust.UserEmail? email = default,
            string? orgName = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}