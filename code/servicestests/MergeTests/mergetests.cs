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
        private MergedService mergedService = new MergedService()
        {
         luckyNumberServiceURL= "https://et-luckynumber.azurewebsites.net",
         FortuneServiceURL= "https://et-fortune.azurewebsites.net"
        };

       [Fact]
        public async void GetTest()
        {
           var options = new Mock<IOptions<MergedService>>();
            options.Setup(x => x.Value).Returns(mergedService);

            MergeController mergeController = new MergeController();
            var mergeControllerResult = await mergeController.Get();

           Assert.NotNull(mergeControllerResult);
           Assert.IsType<OkObjectResult>(mergeControllerResult);
        }

   }
}




