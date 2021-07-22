using System;

namespace PositiveNegativeNumber
{
    class Program2
    {
        static void Main(string[] args)
        {
            //         get input
            Console.WriteLine("Enter the number.");
            decimal input = 0;
            decimal.TryParse(Console.ReadLine(), out input);
           
            if (input > 0)
            {
                Console.WriteLine("Number is positive");
            } 
            else if (input < 0) 
            {
                Console.WriteLine("Number is negative");
            } 
            else 
            {
                Console.WriteLine("Number is zero");
            }

            Console.ReadKey();
        }
    }
}
