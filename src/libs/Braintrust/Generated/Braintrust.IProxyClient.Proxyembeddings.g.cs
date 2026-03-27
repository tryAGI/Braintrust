#nullable enable

namespace Braintrust
{
    public partial interface IProxyClient
    {
        /// <summary>
        /// Proxy embeddings<br/>
        /// Proxy an embeddings request to the specified model, converting its format as needed. Will cache automatically.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyembeddingsAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Proxy embeddings<br/>
        /// Proxy an embeddings request to the specified model, converting its format as needed. Will cache automatically.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ProxyembeddingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}