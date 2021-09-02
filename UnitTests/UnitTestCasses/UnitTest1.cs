using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;
using System;

namespace UnitTestCasses
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PriceChange_InPrice10ChangeWithMinus6_OutPrice4()
        {
            //Arrange
            Product product = new Product(10, 10, "Phone");
            var expected = 4;
            //Act
            product.PriceChange = -6;
            var resut = product.PriceChange;
            //Assert 
            Assert.AreEqual(expected, resut);
        }

        [TestMethod]
        public void PriceChange_InPrice10Plus3_OutPrice13()
        {
            //Arrange
            Product product = new Product(10, 10, "Phone");
            var expected = 13;
            //Act
            product.PriceChange = 3;
            var result = product.PriceChange;
            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AmountChange_InAmmount10Plus3_OutAmmount13()
        {
            //Arrange
            Product product = new Product(10, 10, "Phone");
            var expected = 13;
            //Act
            product.AmountChange = 3;
            var result = product.AmountChange;
            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AmountChange_InAmmount10PlusMinus6_OutAmmount4()
        {
            //Arrange
            Product product = new Product(10, 10, "Phone");
            var expected = 4;
            //Act
            product.AmountChange = -6;
            var result = product.AmountChange;
            //Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Name_InNewName_OutNewName()
        {
            //Arrange
            Product product = new Product(10, 10, "Phone");
            var expected = "Phone2";
            //Act
            product.Name = "Phone2";
            var result = product.Name;
            //Assert 
            Assert.AreEqual(expected, result);
        }
    }
}
