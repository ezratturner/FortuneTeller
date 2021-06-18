using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuckyNumber;
using LuckyNumber.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace servicestests.LuckyNumberTests
{
    public class luckynumbertests
    {
        [Fact]
        public void GetTest()
        {
            LuckyNumberController luckyNumberController = new LuckyNumberController();
            var luckynumberControllerResult = luckyNumberController.Get();

            Assert.NotNull(luckynumberControllerResult);
            Assert.IsType<ActionResult<string>>(luckynumberControllerResult);
        }

    }
}