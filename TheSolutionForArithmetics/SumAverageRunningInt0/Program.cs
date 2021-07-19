using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sum = 0; //not needed
            const int lowerBound = 1;
            const int upperBound = 100;

            double numberOfNumbers = upperBound - lowerBound + 1;
            double averageValOfAllNums = (lowerBound + upperBound) / 2;

            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {averageValOfAllNums * numberOfNumbers}\n" +
                $"The average is {averageValOfAllNums}");



        }
    }
}
