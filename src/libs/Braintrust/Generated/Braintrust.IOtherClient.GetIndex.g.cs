#nullable enable

namespace Braintrust
{
    public partial interface IOtherClient
    {
        /// <summary>
        /// Hello world endpoint<br/>
        /// Default endpoint. Simply replies with 'Hello, World!'. Authorization is not required
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetIndexAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}