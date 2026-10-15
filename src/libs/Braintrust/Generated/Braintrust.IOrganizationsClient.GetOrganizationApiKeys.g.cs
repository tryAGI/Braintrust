#nullable enable

namespace Braintrust
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// List organization API keys<br/>
        /// List all API keys associated with users in an organization, sorted by creation date with the newest keys first. An organization-scoped API key determines the organization; otherwise, provide `org_id`. If `org_id` does not match the organization-scoped key's organization, or the caller is not an owner of the organization, no keys are returned. Responses include key metadata only; key secrets are never returned. To list service tokens, use `GET /v1/service_token`.
        /// </summary>
        /// <param name="limit">
        /// Limit the number of objects to return<br/>
        /// Default Value: 1000
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
        /// <param name="apiKeyName">
        /// Name of the api_key to search for
        /// </param>
        /// <param name="orgId">
        /// Identify the organization to list API keys for
        /// </param>
        /// <param name="createdAfter">
        /// Include API keys created at or after this timestamp
        /// </param>
        /// <param name="createdBefore">
        /// Include API keys created at or before this timestamp
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.GetOrganizationApiKeysResponse> GetOrganizationApiKeysAsync(
            int? limit = default,
            global::System.Guid? startingAfter = default,
            global::System.Guid? endingBefore = default,
            global::Braintrust.Ids? ids = default,
            string? apiKeyName = default,
            global::System.Guid? orgId = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organization API keys<br/>
        /// List all API keys associated with users in an organization, sorted by creation date with the newest keys first. An organization-scoped API key determines the organization; otherwise, provide `org_id`. If `org_id` does not match the organization-scoped key's organization, or the caller is not an owner of the organization, no keys are returned. Responses include key metadata only; key secrets are never returned. To list service tokens, use `GET /v1/service_token`.
        /// </summary>
        /// <param name="limit">
        /// Limit the number of objects to return<br/>
        /// Default Value: 1000
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
        /// <param name="apiKeyName">
        /// Name of the api_key to search for
        /// </param>
        /// <param name="orgId">
        /// Identify the organization to list API keys for
        /// </param>
        /// <param name="createdAfter">
        /// Include API keys created at or after this timestamp
        /// </param>
        /// <param name="createdBefore">
        /// Include API keys created at or before this timestamp
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.GetOrganizationApiKeysResponse>> GetOrganizationApiKeysAsResponseAsync(
            int? limit = default,
            global::System.Guid? startingAfter = default,
            global::System.Guid? endingBefore = default,
            global::Braintrust.Ids? ids = default,
            string? apiKeyName = default,
            global::System.Guid? orgId = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}