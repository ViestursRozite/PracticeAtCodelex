using System;
using System.Collections.Generic;

namespace FooCorpOvertime
{
    class Program8
    {
        static void Main(string[] args)
        {

            //Write a method that takes the base pay and hours worked as parameters,
            //and prints the total pay or an error.
            //Write a main method that calls this method for each of these employees:



            object[] allEmployees = new object[]
            {//       employee, hourly pay, hours worked
                new object[] { 1, 7.50M, 35 },
                new object[] { 2, 8.20M, 47 },
                new object[] { 3, 10.00M, 73 }
            };
            
            void checkEmployeeHours(int hoursWorked, decimal wePayThismuch)
            {
                int maxHoursWeAllow = 60;
                int weeklyNormalHours = 40;
                int overtimeHours = 0;
                decimal normalPay = 8.00M;
                decimal overtimeHourlyPay = wePayThismuch * 1.5M;
                
                decimal returnThisAsTotalPay = 0;

                if (hoursWorked > maxHoursWeAllow)
                {
                    Console.WriteLine("Error, he/she works too much");
                    return;
                }
                else if (wePayThismuch < normalPay)
                {
                    Console.WriteLine("Error, we can not pay this little");
                }
                else
                {
                    overtimeHours = hoursWorked - weeklyNormalHours > 0 ? hoursWorked - weeklyNormalHours : 0;

                    returnThisAsTotalPay += overtimeHours > 0 ? overtimeHours * overtimeHourlyPay : 0 ;//add overtime pay
                    returnThisAsTotalPay += overtimeHours > 0 ? weeklyNormalHours * wePayThismuch : 0;//add max regular pay

                    if (returnThisAsTotalPay == 0) returnThisAsTotalPay += hoursWorked * wePayThismuch ;//add erned regular pay

                    Console.WriteLine($"total pay: {returnThisAsTotalPay}");
                }

                
            }

            void checkAllEmployees(object[] arrOfWorkersPayHours)
            {
                foreach (object[] worker in arrOfWorkersPayHours)
                {
                    int employeeNumber = (int)worker[0];
                    decimal pay = (decimal)worker[1];
                    int hours = (int)worker[2];

                    checkEmployeeHours(hours, pay);
                }
            }

            checkAllEmployees(allEmployees);


        }
    }
}
