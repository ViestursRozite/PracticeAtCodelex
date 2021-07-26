using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 10 natural numbers are: ");
            
            for (int j = 1; j < 11; j++) 
            {
                Console.Write(j + ", ");
            }

            Console.ReadKey();
        }
    }
}
