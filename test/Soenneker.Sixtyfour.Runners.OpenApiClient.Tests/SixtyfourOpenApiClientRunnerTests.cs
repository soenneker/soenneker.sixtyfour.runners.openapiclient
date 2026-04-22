using Soenneker.Tests.HostedUnit;

namespace Soenneker.Sixtyfour.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SixtyfourOpenApiClientRunnerTests : HostedUnitTest
{
    public SixtyfourOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
