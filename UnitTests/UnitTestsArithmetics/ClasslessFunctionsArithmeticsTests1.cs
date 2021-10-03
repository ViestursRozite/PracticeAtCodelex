using Microsoft.VisualStudio.TestTools.UnitTesting;
using CanThisMake15;

namespace UnitTestsArithmetics
{
    [TestClass]
    public class ClasslessFunctionsArithmeticsTests1
    {
        [TestMethod]
        public void CheckFor15_InSumIs15_OutTrue()
        {
            //Arrange
            string[] stringArr = new string[] { "3", "12" };
            //Act 
            bool result = Program1.CheckFor15(stringArr);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckFor15_InDifIs15_OutTrue()
        {
            //Arrange
            string[] stringArr = new string[] { "31", "16" };
            //Act 
            bool result = Program1.CheckFor15(stringArr);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckFor15_In15_OutTrue()
        {
            //Arrange
            string[] stringArr = new string[] { "15", "1" };
            //Act 
            bool result = Program1.CheckFor15(stringArr);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckFor15_InNegativeNumThatDoesMake15_OutTrue()
        {
            //Arrange
            string[] stringArr = new string[] { "-5", "20" };
            //Act 
            bool result = Program1.CheckFor15(stringArr);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckFor15_InputResultsToMinus15_OutFalse()
        {
            //Arrange
            string[] stringArr = new string[] { "-5", "-10" };
            //Act 
            bool result = Program1.CheckFor15(stringArr);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckFor15_InWrongNumberOfParameters_OutFalse()
        {
            //Arrange
            string[] stringArr = new string[] { "1", "20", "9" };
            //Act 
            bool result = Program1.CheckFor15(stringArr);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
