using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        private AppSettings Configuration;
        public MergeController(IOptions<AppSettings> settings)
        {
            Configuration = settings.Value;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // var luckynumberService = "https://localhost:44361/";
            var luckynumberService = $"{Configuration.luckyNumberServiceURL}/luckynumber";
            var luckynumberResponse = await new HttpClient().GetStringAsync(luckynumberService);

            // var fortuneService = "https://localhost:44360/";
            var fortuneService = $"{Configuration.FortuneServiceURL}/fortune";
            var fortuneResponse = await new HttpClient().GetStringAsync(fortuneService);

            var mergedResponse = $"{luckynumberResponse} {fortuneResponse}";
            return Ok(mergedResponse);
        }
    }
}
