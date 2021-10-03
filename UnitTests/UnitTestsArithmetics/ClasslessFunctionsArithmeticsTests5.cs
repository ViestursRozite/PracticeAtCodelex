using Microsoft.VisualStudio.TestTools.UnitTesting;
using FooCorpOvertime;

namespace UnitTestsArithmetics
{
    [TestClass]
    public class ClasslessFunctionsArithmeticsTests5
    {
        
        [TestMethod]
        public void checkEmployeeHours_InHours0AndPay0_OutTotalPayAsString()
        {
            //Arrange
            int hoursWorked = 0;
            decimal payRate = 0;
            string correct = "Error, we can not pay this little";
            //Act
            string result = Program8.CheckEmployeeHours(hoursWorked, payRate);
            //Assert 
            Assert.AreEqual(correct, result);
        }

        [TestMethod]
        public void checkEmployeeHours_InHours40AndPay800_OutTotalPayAsString()
        {
            //Arrange
            int hoursWorked = 40;
            decimal payRate = 8.00m;
            string correct = "total pay: 320.00";
            //Act
            string result = Program8.CheckEmployeeHours(hoursWorked, payRate);
            //Assert 
            Assert.AreEqual(correct, result);
        }

        [TestMethod]
        public void checkEmployeeHours_InHours60AndPay1000_OutTotalPayAsString()
        {
            //Arrange
            int hoursWorked = 60;
            decimal payRate = 10.00m;
            string correct = $"total pay: 700.00";
            //Act
            string result = Program8.CheckEmployeeHours(hoursWorked, payRate);
            //Assert 
            Assert.AreEqual(correct, result);
        }

        [TestMethod]
        public void checkEmployeeHours_InHours72AndPay1000_OutTotalPayAsString()
        {
            //Arrange
            int hoursWorked = 72;
            decimal payRate = 10.00m;
            string correct = "Error, he/she works too much";
            //Act
            string result = Program8.CheckEmployeeHours(hoursWorked, payRate);
            //Assert 
            Assert.AreEqual(correct, result);
        }

        [TestMethod]
        public void checkAllEmployees_ListOfEmployees_InstructionsForEachEmployee()
        {
            //Arrange
            object[] allEmployees = new object[]
            {//  employee nr., hourly pay, hours worked
                new object[] { 1, 7.50M, 35 },
                new object[] { 2, 8.20M, 47 },
                new object[] { 3, 10.00M, 73 },
                new object[] { 4, 10.00M, 59 }
            };
            int correct = allEmployees.Length;
            //Act
            string[] halfResult = Program8.CheckAllEmployees(allEmployees);
            int result = halfResult.Length;
            //Assert 
            Assert.AreEqual(correct, result);
        }
    }
}
