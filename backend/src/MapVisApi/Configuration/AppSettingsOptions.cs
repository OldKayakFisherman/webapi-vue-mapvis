namespace MapVisApi.Configuration
{
    public class AppSettingsOptions
    {
        public required string DatabaseFilename { get; set; }
        public required bool RefreshData { get; set; }
    }
}
