using System;

namespace CanThisMake15
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can your numbers make 15? \n" +
                "write the first and second number separated by ','\n" +
                "3,15\n" +
                "like the given example of '3' and '15' above\n" +
                "your numbers:\n");

            string[] numsAsStrings = Console
                .ReadLine()
                .Split(',');

            if (numsAsStrings.Length != 2) return; // end if incorrect input

            int[] holdBothNumbers = new int[2];//place nums in array
            for(int i = 0; i < 2; i++)
            {
                Int32.TryParse(numsAsStrings[i], out holdBothNumbers[i]);
            }

            bool eitherIs15 = (holdBothNumbers[0] == 15 || holdBothNumbers[1] == 15) ? true : false;
            bool sumIs15 = (holdBothNumbers[0] + holdBothNumbers[1] == 15) ? true : false;
            bool difIs15 = (holdBothNumbers[0] - holdBothNumbers[1] == 15) ? true : false;

            if (eitherIs15 || sumIs15 || difIs15)
            {
                Console.WriteLine(true);
                return;
            }
            else
            {
                Console.WriteLine(false);
                return;
            }
            
        }
    }
}
