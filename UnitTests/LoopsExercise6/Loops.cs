using System;

namespace Exercise6
{
    public class Loops
    {
        public static void MakeTwoSeperateArrs(
            int iWantThisManyIntegers, 
            int lowerbound, 
            int upperBound, 
            int specificNumber, 
            out int[] arr1out, 
            out int[] arr2out)
        {
            Random rnd = new Random();

            int[] arr1 = new int[iWantThisManyIntegers];

            for (int i = 0; i < iWantThisManyIntegers; i++)
            {
                arr1[i] = rnd.Next(lowerbound, upperBound + 1);
            }

            int[] arr2 = (int[])arr1.Clone();

            Console.WriteLine("I have 2 arrays:");
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            Console.WriteLine("[{0}]", string.Join(", ", arr2));

            arr1[arr1.Length - 1] = specificNumber;

            Console.WriteLine("\nThey are seperate:");
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            Console.WriteLine("[{0}]", string.Join(", ", arr2));

            arr1out = arr1;
            arr2out = arr2;
        }

        public static void Main(string[] args)
        {
            int[] array1;
            int[] array2;

            MakeTwoSeperateArrs(10, 1, 100, -7, out array1, out array2);

            Console.ReadKey();
        }
    }
}
