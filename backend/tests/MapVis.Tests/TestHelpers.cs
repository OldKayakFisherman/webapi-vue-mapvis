using MapVisApi.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapVis.Tests
{
    public static class TestHelpers
    {
        public static IOptions<AppSettingsOptions> GetCommonOptions()
        {
            var options = Options.Create(new AppSettingsOptions()
            {
                RefreshData = true,
                DatabaseFilename = "mvs.sqlite3"
            });

            return options;
        }
    }
}
