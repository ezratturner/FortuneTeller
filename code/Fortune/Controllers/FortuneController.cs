using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Fortune.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FortuneController : ControllerBase
    {
        //generate a random string
       // private static readonly char[] Fortune = new[]

        [HttpGet]
        public ActionResult<string> Get()
      {

            Random r = new Random();
            string[] fortune = new []
         {
             "Mistakes happen so turn them into opportunities",
             "There is great love in your fortune",
             "Take the time to invest in yourself today",
             "Do not give up, the beginning is always the hardest",
             "Keep it up. Success is on the way",
        };

            int index = r.Next(0, fortune.Length-1);
            string result = fortune[index];

            return result;
       }
    }
}
