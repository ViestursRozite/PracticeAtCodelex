using Microsoft.VisualStudio.TestTools.UnitTesting;
using GravityCalculator;

namespace UnitTestsArithmetics
{
    [TestClass]
    public class UnitTestArim4
    {
        
        [TestMethod]
        public void DoGravity_InputNone_OutArrayFalingTimeAndFinalPosition()
        {
            //Arrange
            double correct = -490.5;
            //Act
            double result = Program7.DoGravity();
            //Assert 
            Assert.AreEqual(correct, result);
        }
    }
}
