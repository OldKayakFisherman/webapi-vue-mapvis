using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MapVisApi.Data.Entities
{
    [Table("virginia_landmarks")]
    [method: SetsRequiredMembers]
    public class VirginiaLandmarkEntity(string landmarkName, double latitude, double longitude,
        string locationType, string location)
    {
        [Key]
        public int? Id { get; set; }

        [Column("landmark_name")]
        public required string LandmarkName { get; set; } = landmarkName;

        [Column("address")]
        public string? Address { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("state")]
        public string State { get; set; } = "VA";

        [Column("zip")]
        public string? Zip { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("url")]
        public string? Url { get; set; }

        [Column("latitude")]
        public required double Latitude { get; set; } = latitude;

        [Column("longitude")]
        public required double Longitude { get; set; } = longitude;

        [Column("location_type")]
        public required string LocationType { get; set; } = locationType;

        [Column("location")]
        public required string Location { get; set; } = location;
    }
}
