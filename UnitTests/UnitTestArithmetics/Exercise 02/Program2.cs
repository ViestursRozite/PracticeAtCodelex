using System;

namespace CheckOddEven
{
    public class Program2
    {
        public static bool CheckOddEven(int number)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine("Odd Number");
                Console.WriteLine("bye!");
                return false;
            }
            Console.WriteLine("Even Number");
            Console.WriteLine("bye!");
            return true;
        }
        static void Main(string[] args)
        {
            CheckOddEven(99);
            CheckOddEven(1);
            CheckOddEven(-1);
            CheckOddEven(0);
        }
    }
}
