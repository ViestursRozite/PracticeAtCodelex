using System;

namespace Exercise6
{
    class Program6
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int iWantThisManyIntegers = 10;
            int lowerbound = 1;
            int upperBound = 100;
            int specificNumber = -7;

            int[] arr1 = new int[iWantThisManyIntegers];

            for(int i = 0; i < iWantThisManyIntegers; i++)
            {
                arr1[i] = rnd.Next(lowerbound, upperBound + 1);
            }

            int[] arr2 = (int[]) arr1.Clone();

            Console.WriteLine("I have 2 arrays:");
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            Console.WriteLine("[{0}]", string.Join(", ", arr2));

            arr1[arr1.Length - 1] = specificNumber;

            Console.WriteLine("\nThey are seperate:");
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            Console.WriteLine("[{0}]", string.Join(", ", arr2));

            Console.ReadKey();
        }
    }
}
