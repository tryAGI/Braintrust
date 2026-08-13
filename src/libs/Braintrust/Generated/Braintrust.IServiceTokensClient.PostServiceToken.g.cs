#nullable enable

namespace Braintrust
{
    public partial interface IServiceTokensClient
    {
        /// <summary>
        /// Create service_token<br/>
        /// Create a new service token.<br/>
        /// When calling this endpoint, you must authenticate using a service token that has organization-owner permissions. User API keys cannot be used.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.CreateServiceTokenOutput> PostServiceTokenAsync(

            global::Braintrust.PostServiceTokenRequest request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create service_token<br/>
        /// Create a new service token.<br/>
        /// When calling this endpoint, you must authenticate using a service token that has organization-owner permissions. User API keys cannot be used.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.AutoSDKHttpResponse<global::Braintrust.CreateServiceTokenOutput>> PostServiceTokenAsResponseAsync(

            global::Braintrust.PostServiceTokenRequest request,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create service_token<br/>
        /// Create a new service token.<br/>
        /// When calling this endpoint, you must authenticate using a service token that has organization-owner permissions. User API keys cannot be used.
        /// </summary>
        /// <param name="name">
        /// Name of the service token. Does not have to be unique
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the Service token belongs in.
        /// </param>
        /// <param name="serviceAccountId">
        /// The ID of the service account to which the token should belong. To create a service account, visit [**Settings &gt; Service tokens**](https://www.braintrust.dev/app/~/configuration/org/service-tokens) in the Braintrust UI or call [`PATCH /v1/organization/members`](https://www.braintrust.dev/docs/api-reference/organizations/modify-organization-membership).
        /// </param>
        /// <param name="expiresInSeconds">
        /// Number of seconds from now after which the service token should expire. If omitted, the token never expires.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.CreateServiceTokenOutput> PostServiceTokenAsync(
            string name,
            string serviceAccountId,
            string? orgName = default,
            int? expiresInSeconds = default,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}