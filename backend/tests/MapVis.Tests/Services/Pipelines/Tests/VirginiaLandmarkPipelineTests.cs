using MapVisApi.Configuration;
using MapVisApi.Services.Pipelines;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using NUnit.Framework.Constraints;

namespace MapVis.Tests.Services.Pipelines.Tests;

public class VirginiaLandmarkPipelineTests
{
    [Test]
    public void TestInjest()
    {
        var options = TestHelpers.GetCommonOptions();

        PipelineResponse response = new VirginiaLandmarkPipeLine(options).Injest();

        Assert.IsTrue(response.Success);
        Assert.IsTrue(response.PipelineType == PipelineType.VirginiaLandmarks);
        Assert.IsTrue(response.ParsedData.Count > 0);
        Assert.IsTrue(response.ImportCount > 0);

    }
}
