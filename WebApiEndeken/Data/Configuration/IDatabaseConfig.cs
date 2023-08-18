using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEndeken.Data.Configuration
{
    public interface IDatabaseConfig
    {
        string DataBaseName { get; set; }
        string ConnecionString { get; set; }
    }
}
