using CsvHelper;
using CsvHelper.Configuration;
using MapVisApi.Configuration;
using MapVisApi.Services.Pipelines.Models;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.IO;


namespace MapVisApi.Services.Pipelines
{
    public class VirginiaLandmarkPipeLine : IPipeline
    {
        private readonly AppSettingsOptions? _settings;

        public VirginiaLandmarkPipeLine(IOptions<AppSettingsOptions> options)
        {
            _settings = options.Value;
        }

        public PipelineResponse Injest()
        {
            PipelineResponse response = new PipelineResponse(PipelineType.VirginiaLandmarks);

            //Construct our filepath
            response.DataFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Virginia_Landmarks.csv");

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };

            using (var reader = new StreamReader(response.DataFilePath))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<LandmarkCSVModel>();
                foreach(var record in records)
                {
                    response.ParsedData.Add(record);
                }
                    
            }

            response.Success = true;

            return response;

        }
    }
}
