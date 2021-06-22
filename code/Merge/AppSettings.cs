using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Merge
{
    public class AppSettings
    {
        public string luckyNumberServiceURL { get; set; }
        public string FortuneServiceURL { get; set; }
    }
}
