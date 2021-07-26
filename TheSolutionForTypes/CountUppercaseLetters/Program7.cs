using System;

namespace CountUppercaseLetters
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write some text and press enter");

            string inputString = Console.ReadLine();
            int numberOfUppercaseLetters = 0;

            foreach (char symbol in inputString)
            {
                if (char.IsUpper(symbol)) numberOfUppercaseLetters++;
            }

            Console.WriteLine($"{numberOfUppercaseLetters} upper case letters found in the provided sentence");
        }
    }
}
