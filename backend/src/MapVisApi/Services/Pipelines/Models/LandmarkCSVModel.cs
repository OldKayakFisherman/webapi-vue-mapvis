using CsvHelper.Configuration.Attributes;

namespace MapVisApi.Services.Pipelines.Models
{
    public class LandmarkCSVModel: IPipelineDataModel
    {

        [Index(2)]
        public string? LandmarkName { get; set; }

        [Index(3)]
        public string? Address { get; set; }

        [Index(4)]
        public string? City { get; set; }

        [Index(5)]
        public string? State { get; set; }

        [Index(6)]
        public string? Zip { get; set; }

        [Index(7)]
        public string? Phone { get; set; }

        [Index(8)]
        public string? Url { get; set; }

        [Index(9)]
        public double? Longitude { get; set; }

        [Index(10)]
        public double? Latitude { get; set; }

        [Index(13)]
        public string? LocationType { get; set; }

        [Index(16)]
        public string? Location { get; set; }

    }
}
