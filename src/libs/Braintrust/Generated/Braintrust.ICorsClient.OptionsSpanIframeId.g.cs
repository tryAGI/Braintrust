#nullable enable

namespace Braintrust
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/span_iframe/{span_iframe_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="spanIframeId">
        /// SpanIframe id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsSpanIframeIdAsync(
            global::System.Guid spanIframeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}