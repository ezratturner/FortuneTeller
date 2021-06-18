using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fortune;
using Fortune.Controllers;

namespace TestProject
{
    [TestClass]
    public class FortuneTests
    {
        [TestMethod]
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
            Assert.IsNotNull(testFortuneController);




            //create instance to test

            // define a test input and output value

            // string output = 

            // run method under test
            // double = 

            //verify the result
            //Assert.AreEqual()
        }
    }
}
