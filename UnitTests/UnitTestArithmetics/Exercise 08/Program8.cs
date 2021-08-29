using System;
using System.Collections.Generic;

namespace FooCorpOvertime
{
    public class Program8
    {
        public static string checkEmployeeHours(int hoursWorked, decimal wePayThismuch)
        {
            int maxHoursWeAllow = 60;
            int weeklyNormalHours = 40;
            int overtimeHours = 0;
            overtimeHours = hoursWorked - weeklyNormalHours;
            decimal normalPay = 8.00M;
            decimal overtimeHourlyPay = wePayThismuch * 1.5M;

            decimal returnThisAsTotalPay = 0;

            if (hoursWorked > maxHoursWeAllow)
            {
                Console.WriteLine("Error, he/she works too much");
                return "Error, he/she works too much";
            }
            else if (wePayThismuch < normalPay)
            {
                Console.WriteLine("Error, we can not pay this little");
                return "Error, we can not pay this little";
            }
            else
            {
                if (hoursWorked - weeklyNormalHours > 0)//if overtime
                {
                    returnThisAsTotalPay += (overtimeHours * overtimeHourlyPay);//add overtime pay
                    returnThisAsTotalPay += (weeklyNormalHours * wePayThismuch);//add max possible regular pay
                }
                else//no overtime
                {
                    returnThisAsTotalPay += hoursWorked * wePayThismuch;//add earned regular pay
                }

                Console.WriteLine($"total pay: {returnThisAsTotalPay}");
                return $"total pay: {decimal.Round(returnThisAsTotalPay, 2) }";
            }
        }

        public static string[] checkAllEmployees(object[] arrOfWorkersPayHours)
        {
            List<string> halfResult = new List<string>();
            foreach (object[] worker in arrOfWorkersPayHours)
            {
                int employeeNumber = (int)worker[0];
                decimal pay = (decimal)worker[1];
                int hours = (int)worker[2];

                halfResult.Add(checkEmployeeHours(hours, pay));
            }
            return halfResult.ToArray();
        }

        static void Main(string[] args)
        {
            object[] allEmployees = new object[]
            {//  employee nr., hourly pay, hours worked
                new object[] { 1, 7.50M, 35 },
                new object[] { 2, 8.20M, 47 },
                new object[] { 3, 10.00M, 73 },
                new object[] { 4, 10.00M, 59 }
            };

        checkAllEmployees(allEmployees);
        }
    }
}
