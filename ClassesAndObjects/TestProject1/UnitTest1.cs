using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FuelConsumptionCalculator;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Car cr = new Car(0, 5, 5);
            var res = cr.CalculateConsumption();
            Assert.AreEqual(res, 1);
        }


    }
}
