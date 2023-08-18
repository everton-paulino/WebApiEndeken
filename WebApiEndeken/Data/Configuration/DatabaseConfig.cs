Datusing System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEndeken.Data.Configuration
{
    public class DatabaseConfig : IDatabaseConfig
    {
        public string DataBaseName { get; set; }
        public string ConnecionString { get; set; }
    }
}
