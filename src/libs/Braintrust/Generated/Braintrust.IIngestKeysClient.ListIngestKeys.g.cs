#nullable enable

namespace Braintrust
{
    public partial interface IIngestKeysClient
    {
        /// <summary>
        /// List ingest keys<br/>
        /// List ingest keys for a project, newest first, including their complete copyable configuration URLs. The URL is null when the organization's API URL cannot be used for ingest keys. Requires project create_acls permission. Token hashes are never returned.
        /// </summary>
        /// <param name="projectId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.ListIngestKeysResponse> ListIngestKeysAsync(
            global::System.Guid projectId,
            int? limit = default,
            global::System.Guid? startingAfter = default,
            global::System.Guid? endingBefore = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List ingest keys<br/>
        /// List ingest keys for a project, newest first, including their complete copyable configuration URLs. The URL is null when the organization's API URL cannot be used for ingest keys. Requires project create_acls permission. Token hashes are never returned.
        /// </summary>
        /// <param name="projectId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.ListIngestKeysResponse>> ListIngestKeysAsResponseAsync(
            global::System.Guid projectId,
            int? limit = default,
            global::System.Guid? startingAfter = default,
            global::System.Guid? endingBefore = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}