using System;

namespace CanThisMake15
{
    public class Program1
    {
        public static bool CheckFor15(string[] numsAsStrings)
        {

            if (numsAsStrings.Length != 2) return false; // end if incorrect input

            int[] holdBothNumbers = new int[2];//place nums in array
            for (int i = 0; i < 2; i++)
            {
                Int32.TryParse(numsAsStrings[i], out holdBothNumbers[i]);
            }

            bool eitherIs15 = holdBothNumbers[0] == 15 || holdBothNumbers[1] == 15 ;
            bool sumIs15 = holdBothNumbers[0] + holdBothNumbers[1] == 15 ;
            bool difIs15 = holdBothNumbers[0] - holdBothNumbers[1] == 15 ;

            if (eitherIs15 || sumIs15 || difIs15)
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }
        }
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

            CheckFor15(numsAsStrings);

            Console.ReadKey();
        }
    }
}
