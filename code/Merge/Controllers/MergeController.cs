using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        //lucky number url: https://localhost:44361/
        //fortune teller url: https://localhost:44360/

        private IConfiguration Configuration;
        private Microsoft.Extensions.Options.IOptions<global::servicestests.MergeTests.MergedService> @object;

        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public MergeController(Microsoft.Extensions.Options.IOptions<global::servicestests.MergeTests.MergedService> @object)
        {
            this.@object = @object;
        }

        public MergeController(Microsoft.Extensions.Options.IOptions<global::servicestests.MergeTests.MergedService> object1)
        {
            Object = object1;
        }

        public Microsoft.Extensions.Options.IOptions<global::servicestests.MergeTests.MergedService> Object { get; }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // var luckynumberService = "https://localhost:44361/";
            var luckynumberService = $"{Configuration["luckynumberServiceURL"]}/luckynumber";
            var luckynumberResponse = await new HttpClient().GetStringAsync(luckynumberService);


            // var fortuneService = "https://localhost:44360/";
            var fortuneService = $"{Configuration["fortuneServiceURL"]}/fortune";
            var fortuneResponse = await new HttpClient().GetStringAsync(fortuneService);

            var mergedResponse = $"{luckynumberResponse} {fortuneResponse}";
            return Ok(mergedResponse);
        }
    }
}
