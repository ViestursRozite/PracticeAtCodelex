using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateArea;

namespace UnitTestsArithmetics
{
    [TestClass]
    public class UnitTestArim6
    {
        
        [TestMethod]
        public void areaOfCircle_In5_Out31Point4159265358979()
        {
            //Arrange
            int input = 5;
            double expected = 31.4159265358979;
            //Act
            double? actual = Geometry.areaOfCircle(input);
            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void areaOfCircle_InNegative_OutNull()
        {
            //Arrange
            int input = -1;
            //Act
            double? actual = Geometry.areaOfCircle(input);
            //Assert 
            Assert.IsNull(actual) ;
        }

        [TestMethod]
        public void areaOfRectangle_In6And5_Out30()
        {
            //Arrange
            int length = 6;
            int width = 5;
            //Act
            double? actual = Geometry.areaOfRectangle(length, width);
            //Assert 
            Assert.AreEqual((length * width), actual);
        }

        [TestMethod]
        public void areaOfRectangle_InNegative_OutNull()
        {
            //Act
            double? actual = Geometry.areaOfRectangle(-1, -2);
            //Assert 
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void areaOfTriangle_In6And5_Out15()
        {
            //Arrange
            int ground = 6;
            int h = 5;
            //Act
            double? actual = Geometry.areaOfTriangle(ground, h);
            //Assert 
            Assert.AreEqual((ground * h * 0.5), actual);
        }

        [TestMethod]
        public void areaOfTriangle_InNegative_OutNull()
        {
            //Act
            double? actual = Geometry.areaOfTriangle(-1, -2);
            //Assert 
            Assert.IsNull(actual);
        }
    }
}
