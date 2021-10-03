using System;

namespace Exercise2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int i, n, r;
            r = 1;//to get a not 0 result

            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            //       ↓          ↓  'n', 'i' incremented by 1 to make result != 0
            for (i = 1; i < n + 1; i++)
            {
                r *= i;
            }

            Console.WriteLine(r);//give result
            Console.ReadKey();
        }
    }
}
