using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise5;
using System;

namespace UnitTestCasses
{
    [TestClass]
    public class DateTests2
    {
        [TestMethod]
        public void DateConstructor_InNewInstance_OutDay()
        {
            //Arrange
            Date date = new Date("13", "04", "1999");
            var expected = "13";
            //Act
            var result = date.Day;
            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DateConstructor_InNewInstance_OutMonth()
        {
            //Arrange
            Date date = new Date("13", "04", "1999");
            var expected = "04";
            //Act
            var result = date.Month;
            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DateConstructor_InNewInstance_OutYear()
        {
            //Arrange
            Date date = new Date("13", "04", "1999");
            var expected = "1999";
            //Act
            var result = date.Year;
            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DisplayDate_InNewInstance_MatchingString()
        {
            //Arrange
            Date date = new Date("13", "04", "1999");
            var expected = "13/04/1999";
            //Act
            var result = date.DisplayDate();
            //Assert 
            Assert.AreEqual(expected, result);
        }
    }
}
