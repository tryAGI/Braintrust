#nullable enable

namespace Braintrust
{
    public partial interface ISpanIframesClient
    {
        /// <summary>
        /// Delete span_iframe<br/>
        /// Delete a span_iframe object by its id
        /// </summary>
        /// <param name="spanIframeId">
        /// SpanIframe id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Braintrust.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Braintrust.SpanIFrame> DeleteSpanIframeIdAsync(
            global::System.Guid spanIframeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}