using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.ngrok.HttpClients.Abstract;

/// <summary>
/// Provides a cached HTTP client with ngrok API authentication and version headers.
/// </summary>
public interface IngrokOpenApiHttpClient : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the configured ngrok HTTP client.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The cached client.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
