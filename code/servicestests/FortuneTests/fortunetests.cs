using Fortune.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace servicestests.FortuneTests
{
    
    public class fortunetests
    {
        [Fact]
        public void FortuneTesting()
        {
           
          //arrange
          FortuneController testfortune = new FortuneController();

          string[] Fortune = { "Mistakes happen so turn them into opportunities",
             "There is great love in your fortune",
             "Take the time to invest in yourself today",
             "Do not give up, the beginning is always the hardest",
             "Keep it up. Success is on the way", };

            //act
           var testFortuneController = testfortune.Fortune;

            //assert
           Assert.NotNull(testFortuneController);


        }
     




    }
}
