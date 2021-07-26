using System;

namespace Exercise5
{
    class Program5
    {
        static void Main(string[] args)
        {
            int totalLineLengthInDots = 33;
            string[] twoWords = new string[2];
            string outputString = "";
            string symbol = ".";

            Console.WriteLine("Enter the 1st word: \n");
            twoWords[0] = Console.ReadLine();

            Console.WriteLine("Enter the 2nd word: \n");
            twoWords[1] = Console.ReadLine();

            foreach(string word in twoWords)
            {
                totalLineLengthInDots -= word.Length;
            }

            outputString += twoWords[0];
            for (int i = 0; i < totalLineLengthInDots; i++)
            {
                outputString += $"{symbol}";
            }
            outputString += twoWords[1];

            Console.WriteLine("\n" + outputString);
            Console.WriteLine("length: " + outputString.Length);
        }
    }
}
