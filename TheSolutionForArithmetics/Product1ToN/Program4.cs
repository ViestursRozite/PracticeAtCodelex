using System;

namespace Product1ToN
{
    class Program4
    {
        static void Main(string[] args)
        {
            static int factorial(int number)
            {
                int result = 1;               
                for(int i = 1; i < number + 1; i++)
                {
                    result = i * result;
                }

                return result;
            }

            int output = factorial(10);

            Console.WriteLine(output);

        }
    }
}
