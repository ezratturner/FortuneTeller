using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LuckyNumber.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LuckyNumberController : ControllerBase
    {
        //generate random lucky number from 1-100

        [HttpGet]
        public ActionResult <int> Get()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);

            return number;
         
        }
    }

}
  
     
  
