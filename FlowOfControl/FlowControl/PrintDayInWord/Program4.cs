using System;

namespace PrintDayInWord
{
    class Program4
    {
        static void Main(string[] args)
        {
            //                ask user for day number
            Console.WriteLine("Type in a number representing one day of the week:\n");
            int input;
            int.TryParse(Console.ReadLine(), out input);

            int dayNumber = input;
            
            //                  nested if
            if (true)
            {
                if (dayNumber == 1) Console.WriteLine("Monday");
                else if (dayNumber == 2) Console.WriteLine("Tuesday");
                else if (dayNumber == 3) Console.WriteLine("Wednesday");
                else if (dayNumber == 4) Console.WriteLine("Thursday");
                else if (dayNumber == 5) Console.WriteLine("Friday");
                else if (dayNumber == 6) Console.WriteLine("Saturday");
                else if (dayNumber == 7) Console.WriteLine("Sunday");
                else Console.WriteLine("Not a valid day");
            }

            ////                switch
            //switch (dayNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Not a valid day");
            //        break;
            //}
            Console.ReadKey();
        }
    }
}
