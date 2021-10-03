using System;
namespace Exercise3
{
    class Program3
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbersArr = {20, 30, 25, 35, -16, 60, -100};
            int sum = 0;
            int numOfElements = numbersArr.Length;

            Console.WriteLine("[{0}]", string.Join(", ", numbersArr));

            foreach (int number in numbersArr)
            {
                sum += number;
            }

            decimal average = sum / numOfElements;
            Console.WriteLine("Average value of the array elements is : " + average);
            Console.ReadKey();
        }
    }
}
