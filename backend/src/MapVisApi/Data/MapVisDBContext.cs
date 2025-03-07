using MapVisApi.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MapVisApi.Data
{
    public class MapVisDBContext: DbContext
    {
        private readonly AppSettingsOptions _settings;

        private string DBPath { 
            get
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    _settings.DatabaseFilename);
            }    
        }


        public MapVisDBContext(IOptions<AppSettingsOptions> options)
        {
            _settings = options.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DBPath}");


    }
}
