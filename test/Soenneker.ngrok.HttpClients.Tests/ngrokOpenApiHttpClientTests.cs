using Soenneker.ngrok.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.ngrok.HttpClients.Tests;

[Collection("Collection")]
public sealed class ngrokOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IngrokOpenApiHttpClient _httpclient;

    public ngrokOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IngrokOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
