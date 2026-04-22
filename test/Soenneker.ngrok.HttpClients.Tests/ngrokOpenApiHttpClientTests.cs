using Soenneker.ngrok.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.ngrok.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ngrokOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IngrokOpenApiHttpClient _httpclient;

    public ngrokOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IngrokOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
