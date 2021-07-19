using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal lowerBound = 1;
            const decimal upperBound = 100;

            decimal numberOfNumbers = upperBound - lowerBound + 1;
            decimal midpointOfNums = (lowerBound + upperBound) / 2;

            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {midpointOfNums * numberOfNumbers}\n" +
                $"The average is {midpointOfNums}");



        }
    }
}
