using System;

namespace minuteToYearAndDayConversion
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.Write("Write minutes that need to be converted into years and days \n" +
                "220852402  \n" +
                "like the above given example\n");

            int inputMinutes = Int32.Parse(Console.ReadLine());

            //if (inputMinutes <= 0) //←not needed to solve as written
            //{ 
            //    Console.WriteLine("invalid number has been given");
            //    return;
            //}

            int minInADay = 1440;
            int daysInYear = 365;
            int holdsMinInYear = minInADay * daysInYear;

            decimal yearsGotten = 0; //always a whole num
            decimal daysGotten = 0; //always a whole num

            //write full years
            //afterwards write full days
            yearsGotten = (inputMinutes - (inputMinutes % holdsMinInYear))/ holdsMinInYear;
            daysGotten = (inputMinutes % holdsMinInYear) / minInADay;
            
            Console.WriteLine($"The provided number of minutes converted to years and full days gives \n" +
                $"{yearsGotten} years and\n" +
                $"{daysGotten} days ");

        }
    }
}
