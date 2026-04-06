using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Sixtyfour.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class SixtyfourOpenApiClientRunnerTests : FixturedUnitTest
{
    public SixtyfourOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
