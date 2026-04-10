#nullable enable

namespace Braintrust
{
    public partial interface ISpanIframesClient
    {
        /// <summary>
        /// Get span_iframe<br/>
        /// Get a span_iframe object by its id
        /// </summary>
        /// <param name="spanIframeId">
        /// SpanIframe id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.SpanIFrame> GetSpanIframeIdAsync(
            global::System.Guid spanIframeId,
            global::Braintrust.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}