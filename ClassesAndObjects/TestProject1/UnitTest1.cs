using FuelConsumptionCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCarConstructor()
        {
            Car cr = new Car(0, 5, 5);
            var res = cr.CalculateConsumption();
            Assert.AreEqual(res, 1);
        }
    }
}
