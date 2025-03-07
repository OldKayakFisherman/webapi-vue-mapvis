using MapVisApi.Services.Pipelines.Models;
using System.Collections.Generic;

namespace MapVisApi.Services.Pipelines
{
    public class PipelineResponse
    {
        public IList<IPipelineDataModel> ParsedData { get; set; } = new List<IPipelineDataModel>();
        public int ImportCount { get { return ParsedData.Count; } }
        public bool Success { get; set; } = false;

        public PipelineType PipelineType { get; set; }
        public string? DataFilePath { get; set; }

        public PipelineResponse(PipelineType pipelineType)
        {
            this.PipelineType = pipelineType;
        }

    }
}
