using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Merge;
using Merge.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Microsoft.Extensions.Options;

namespace servicestests.MergeTests
{
    public class mergetests
    {
        private AppSettings appSettings = new AppSettings()
        {
            luckyNumberServiceURL = "https://et-luckynumber.azurewebsites.net",
            FortuneServiceURL = "https://et-fortune.azurewebsites.net"
        };

       [Fact]
        public async void GetTest()
        {
           var options = new Mock<IOptions<AppSettings>>();
           options.Setup(x => x.Value).Returns(appSettings);

            MergeController mergeController = new MergeController(options.Object);
            var mergeControllerResult = await mergeController.Get();

           Assert.NotNull(mergeControllerResult);
           Assert.IsType<OkObjectResult>(mergeControllerResult);
        }
   }
}




