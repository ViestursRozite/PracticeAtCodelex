using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckOddEven;

namespace UnitTestsArithmetics
{
    [TestClass]
    public class UnitTestArim2
    {
        
        [TestMethod]
        public void CheckOddEven_InOddNumber_outFalse()
        {
            //Arrange
            int num = 1;
            //Act
            bool isEven = Program2.CheckOddEven(num);
            //Assert 
            Assert.IsFalse(isEven);
        }
        [TestMethod]
        public void CheckOddEven_In2_outTrue()
        {
            //Arrange
            int num = 2;
            //Act
            bool isEven = Program2.CheckOddEven(num);
            //Assert 
            Assert.IsTrue(isEven);
        }
        [TestMethod]
        public void CheckOddEven_In0_outTrue()
        {
            //Arrange
            int num = 0;
            //Act
            bool isEven = Program2.CheckOddEven(num);
            //Assert 
            Assert.IsTrue(isEven);
        }
        [TestMethod]
        public void CheckOddEven_InMinus22_outTrue()
        {
            //Arrange
            int num = -22;
            //Act
            bool isEven = Program2.CheckOddEven(num);
            //Assert 
            Assert.IsTrue(isEven);
        }
    }
}
