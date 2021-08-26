using System;

namespace CheckOddEven
{
    class Program2
    {
        static void Main(string[] args)
        {
            void CheckOddEven(int number)
            {
                if (number % 2 != 0) 
                {
                    Console.WriteLine("Odd Number");
                    Console.WriteLine("bye!");
                    return;
                }
                Console.WriteLine("Even Number");
                Console.WriteLine("bye!");
                return;
            }

            CheckOddEven(99);
            CheckOddEven(1);
            CheckOddEven(-1);
            CheckOddEven(0);
        }
    }
}
